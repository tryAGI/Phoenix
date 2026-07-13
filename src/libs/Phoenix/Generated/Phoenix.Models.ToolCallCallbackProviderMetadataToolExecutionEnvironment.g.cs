
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallCallbackProviderMetadataToolExecutionEnvironment
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
    public static class ToolCallCallbackProviderMetadataToolExecutionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallCallbackProviderMetadataToolExecutionEnvironment value)
        {
            return value switch
            {
                ToolCallCallbackProviderMetadataToolExecutionEnvironment.Client => "client",
                ToolCallCallbackProviderMetadataToolExecutionEnvironment.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallCallbackProviderMetadataToolExecutionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolCallCallbackProviderMetadataToolExecutionEnvironment.Client,
                "server" => ToolCallCallbackProviderMetadataToolExecutionEnvironment.Server,
                _ => null,
            };
        }
    }
}