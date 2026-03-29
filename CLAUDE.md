# CLAUDE.md -- Phoenix SDK

## Overview

Auto-generated C# SDK for [Phoenix](https://phoenix.arize.com/) (Arize AI) -- LLM observability and evaluation platform with projects, traces, spans, evaluations, experiments, datasets, prompts, annotations, and user management.
OpenAPI spec from `https://raw.githubusercontent.com/Arize-ai/phoenix/main/schemas/openapi.json`.

## Build & Test

```bash
dotnet build Phoenix.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (spec had no securitySchemes; injected via `--security-scheme Http:Header:Bearer`):

```csharp
var client = new PhoenixClient(apiKey); // PHOENIX_API_KEY env var
```

Phoenix is self-hosted by default (localhost:6006). The base URL is injected into the spec via `jq`.

## Key Files

- `src/libs/Phoenix/openapi.json` -- OpenAPI spec (3.1.0, downloaded from Arize GitHub)
- `src/libs/Phoenix/generate.sh` -- Downloads spec, adds `servers` section via `jq`, runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Phoenix/Generated/` -- **Never edit** -- auto-generated code (~1190 files)
- `src/libs/Phoenix/Extensions/PhoenixClient.AsTool.cs` -- Hand-written MEAI AIFunction tools

## Sub-client Pattern

Phoenix uses sub-clients for each API area:

```csharp
// Prompts
client.Prompts.GetPromptVersionLatestAsync(promptIdentifier: "my-prompt");
client.Prompts.GetPromptsAsync(limit: 20);

// Traces
client.Traces.ListProjectTracesAsync(projectIdentifier: "my-project", limit: 10);

// Spans
client.Spans.AnnotateSpansAsync(data: [...], sync: true);

// Projects
client.Projects.ListProjectsAsync();

// Experiments
client.Experiments.ListExperimentsAsync(datasetId: "...");

// Datasets
client.Datasets.GetDatasetsAsync();

// Annotations
client.Annotations.GetAnnotationsAsync(...);

// Annotation Configs
client.AnnotationConfigs.GetAnnotationConfigsAsync();

// Sessions
client.Sessions.GetSessionsAsync(projectId: "...");

// Users
client.Users.GetUsersAsync();
```

## MEAI Integration

`AIFunction` tools for use with any `IChatClient` (in `PhoenixClient.AsTool.cs`):

- `client.AsGetPromptTool()` -- Retrieve latest version of a prompt template by name
- `client.AsListPromptsTool(limit)` -- List all available prompt templates
- `client.AsAnnotateSpanTool(annotationName)` -- Annotate a trace span with score, label, and explanation
- `client.AsListTracesTool(limit)` -- List recent traces for a project

## Spec Notes

- OpenAPI 3.1.0 spec from Arize GitHub (`schemas/openapi.json`)
- Spec has no `servers` section -- `generate.sh` injects `http://localhost:6006` via `jq`
- Spec has no `securitySchemes` -- `--security-scheme Http:Header:Bearer` overrides at generation time
- 62 API operations across 10 sub-clients
- Uses `--exclude-deprecated-operations` flag
