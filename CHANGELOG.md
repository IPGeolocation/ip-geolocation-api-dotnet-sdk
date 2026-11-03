# Changelog

## 3.0.1

- Hide API keys in error messages and details.
- Handle incomplete or invalid error responses.
- Fix request handling for very short or very long timeouts.
- Add Arabic (`ar`) for single and bulk lookups.

Existing public methods and .NET Standard 2.1 support remain unchanged.

## 3.0.0 - 2026-04-08

- Replaced the old generated multi-API SDK with the new .NET SDK for the IPGeolocation.io IP Location API.
- Added typed and raw single lookup methods for `/v3/ipgeo`.
- Added typed and raw bulk lookup methods for `/v3/ipgeo-bulk`.
- Added request validation, response metadata, clearer error handling, and updated public docs.
- Added unit tests, live integration tests, and live field parity tests.
