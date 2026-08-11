
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment
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
    public static class PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment value)
        {
            return value switch
            {
                PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment.Client => "client",
                PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "client" => PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment.Client,
                "server" => PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment.Server,
                _ => null,
            };
        }
    }
}