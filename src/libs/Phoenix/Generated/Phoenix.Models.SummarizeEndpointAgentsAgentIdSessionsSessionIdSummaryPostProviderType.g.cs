
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType value)
        {
            return value switch
            {
                SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType.Builtin => "builtin",
                SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType.Builtin,
                "custom" => SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostProviderType.Custom,
                _ => null,
            };
        }
    }
}