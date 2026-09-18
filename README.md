# atproto-dotnet

Reusable .NET libraries and developer tools for building applications on the
[AT Protocol](https://atproto.com/). The packages are protocol-focused and do
not require .NET Aspire or any service stack.

## Packages

| Package | Purpose |
| --- | --- |
| `AtProto.Cid` | CIDv1, dag-cbor, and SHA-256 content identifiers |
| `AtProto.Cbor` | Canonical DAG-CBOR encoding and decoding |
| `AtProto.Car` | CARv1 repository archive reading and writing |
| `AtProto.Crypto` | secp256k1 and P-256 signing primitives |
| `AtProto.Lexicon` | Lexicon, NSID, and AT-URI value types |
| `AtProto.Identity` | DID documents and `did:web` resolution |
| `AtProto.Repo` | Signed commits and Merkle Search Trees |
| `AtProto.Firehose` | Firehose frame decoding and reactive ingest |
| `AtProto.OAuth` | AT Protocol OAuth, PKCE, DPoP, and client metadata primitives |
| `AtProto.Xrpc` | Framework-neutral HTTP client for XRPC queries and procedures |
| `AtProto.Lexicon.SourceGeneration` | Roslyn source generation for Lexicon schemas |

The initial extracted release is `0.3.0-preview.1`. Preview packages are
published to [GitHub Packages](https://github.com/luisquintanilla/atproto-dotnet/packages).

## Build

The repository uses the .NET 10 SDK and targets .NET 8 and .NET 10 for the
shared libraries:

```text
dotnet restore atproto-dotnet.slnx
dotnet build atproto-dotnet.slnx --configuration Release --no-restore
dotnet test atproto-dotnet.slnx --configuration Release --no-build
dotnet pack atproto-dotnet.slnx --configuration Release --no-restore --output artifacts/packages
```

The solution contains only the shared libraries, their tests, and the
developer tools. No Aspire, service, or downstream application projects are
included.

## Layout

```text
src/core/   reusable AT Protocol libraries
tests/      shared-library and generator tests
tools/      fixtures, Lexicon code generation, and source generation
lexicons/   Lexicon schemas used by the generator tests
docs/       package-specific documentation
```

See [`docs/nuget/README.md`](docs/nuget/README.md) for package usage details.

## License

Licensed under the MIT License. See [`LICENSE`](LICENSE).
