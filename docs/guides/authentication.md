# Authentication

The Phoenix SDK uses Bearer token authentication. Authentication is optional for local/self-hosted instances but required for hosted Phoenix deployments.

## Basic Usage

```csharp
using Phoenix;

var client = new PhoenixClient(apiKey: Environment.GetEnvironmentVariable("PHOENIX_API_KEY")!);
```

## Self-Hosted Instances

For self-hosted Phoenix instances, you may also need to configure the base URL:

```csharp
var client = new PhoenixClient(
    apiKey: Environment.GetEnvironmentVariable("PHOENIX_API_KEY")!,
    baseUri: new Uri("http://localhost:6006"));
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `PHOENIX_API_KEY` | Your Phoenix API key (optional for local instances) |
