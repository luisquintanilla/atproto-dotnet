# atproto-dotnet packages

The packages in this repository are reusable .NET building blocks for the
[AT Protocol](https://atproto.com/). They are independent of .NET Aspire and
can be referenced individually:

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

The current package line is `0.3.0-preview.1` and is distributed through
[GitHub Packages](https://github.com/luisquintanilla/atproto-dotnet/packages).
The API surface is still preview quality; pin an exact version when consuming
the packages.
