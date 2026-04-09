using System;
using Xunit;

namespace IPGeolocation.Test.IpLocation.Support;

internal static class LiveTestGuard
{
    internal static string RequireFreeKey()
    {
        RequireFlag("IPGEO_RUN_LIVE_TESTS");
        return RequireValue("IPGEO_FREE_KEY");
    }

    internal static string RequirePaidKey()
    {
        RequireFlag("IPGEO_RUN_LIVE_HARDENING");
        return RequireValue("IPGEO_PAID_KEY");
    }

    internal static string RequirePaidKeyForLive()
    {
        RequireFlag("IPGEO_RUN_LIVE_TESTS");
        return RequireValue("IPGEO_PAID_KEY");
    }

    private static void RequireFlag(string name)
    {
        var value = Environment.GetEnvironmentVariable(name);
        Skip.IfNot(string.Equals(value, "true", StringComparison.OrdinalIgnoreCase), name + " is not enabled");
    }

    private static string RequireValue(string name)
    {
        var value = Environment.GetEnvironmentVariable(name);
        Skip.If(string.IsNullOrWhiteSpace(value), name + " is not set");

        return value.Trim();
    }
}
