

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace IPGeolocation.Client
{
    /// <summary>
    /// Provides a token to the api clients. Tokens will be rate limited based on the provided TimeSpan.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public class RateLimitProvider<TTokenBase> : TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        internal Dictionary<string, global::System.Threading.Channels.Channel<TTokenBase>> AvailableTokens { get; } = new Dictionary<string, global::System.Threading.Channels.Channel<TTokenBase>>();

        /// <summary>
        /// Instantiates a ThrottledTokenProvider. Your tokens will be rate limited based on the token's timeout.
        /// </summary>
        /// <param name="container"></param>
        public RateLimitProvider(TokenContainer<TTokenBase> container) : base(container.Tokens)
        {
            foreach(TTokenBase token in _tokens)
                token.StartTimer(token.Timeout ?? TimeSpan.FromMilliseconds(40));

            if (container is TokenContainer<ApiKeyToken> apiKeyTokenContainer)
            {
                string[] headers = apiKeyTokenContainer.Tokens.Select(t => ClientUtils.ApiKeyHeaderToString(t.Header)).Distinct().ToArray();

                foreach (string header in headers)
                {
                    global::System.Threading.Channels.BoundedChannelOptions options = new global::System.Threading.Channels.BoundedChannelOptions(apiKeyTokenContainer.Tokens.Count(t => ClientUtils.ApiKeyHeaderToString(t.Header).Equals(header)))
                    {
                        FullMode = global::System.Threading.Channels.BoundedChannelFullMode.DropWrite
                    };

                    AvailableTokens.Add(header, global::System.Threading.Channels.Channel.CreateBounded<TTokenBase>(options));
                }
            }
            else
            {
                global::System.Threading.Channels.BoundedChannelOptions options = new global::System.Threading.Channels.BoundedChannelOptions(_tokens.Length)
                {
                    FullMode = global::System.Threading.Channels.BoundedChannelFullMode.DropWrite
                };

                AvailableTokens.Add(string.Empty, global::System.Threading.Channels.Channel.CreateBounded<TTokenBase>(options));
            }

            foreach(global::System.Threading.Channels.Channel<TTokenBase> tokens in AvailableTokens.Values)
                for (int i = 0; i < _tokens.Length; i++)
                    _tokens[i].TokenBecameAvailable += ((sender) => tokens.Writer.TryWrite((TTokenBase) sender));
        }

        internal override async System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(string header = "", System.Threading.CancellationToken cancellation = default)
        {
            if (!AvailableTokens.TryGetValue(header, out global::System.Threading.Channels.Channel<TTokenBase>? tokens))
                throw new KeyNotFoundException($"Could not locate a token for header '{header}'.");

            return await tokens.Reader.ReadAsync(cancellation).ConfigureAwait(false);
        }
    }
}
