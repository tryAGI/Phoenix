
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallProviderMetadataToolExecutionEnvironment
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
    public static class ToolCallProviderMetadataToolExecutionEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallProviderMetadataToolExecutionEnvironment value)
        {
            return value switch
            {
                ToolCallProviderMetadataToolExecutionEnvironment.Client => "client",
                ToolCallProviderMetadataToolExecutionEnvironment.Server => "server",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallProviderMetadataToolExecutionEnvironment? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolCallProviderMetadataToolExecutionEnvironment.Client,
                "server" => ToolCallProviderMetadataToolExecutionEnvironment.Server,
                _ => null,
            };
        }
    }
}