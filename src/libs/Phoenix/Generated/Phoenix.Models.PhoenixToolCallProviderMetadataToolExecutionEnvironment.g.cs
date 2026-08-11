
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoenixToolCallProviderMetadataToolExecutionEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoenixToolCallProviderMetadataToolExecutionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoenixToolCallProviderMetadataToolExecutionEnvironment value)
        {
            return value switch
            {
                PhoenixToolCallProviderMetadataToolExecutionEnvironment.Client => "client",
                PhoenixToolCallProviderMetadataToolExecutionEnvironment.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoenixToolCallProviderMetadataToolExecutionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "client" => PhoenixToolCallProviderMetadataToolExecutionEnvironment.Client,
                "server" => PhoenixToolCallProviderMetadataToolExecutionEnvironment.Server,
                _ => null,
            };
        }
    }
}