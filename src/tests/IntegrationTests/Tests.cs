namespace Phoenix.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PhoenixClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PHOENIX_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PHOENIX_API_KEY environment variable is not found.");

        var client = new PhoenixClient(apiKey);
        
        return client;
    }
}
