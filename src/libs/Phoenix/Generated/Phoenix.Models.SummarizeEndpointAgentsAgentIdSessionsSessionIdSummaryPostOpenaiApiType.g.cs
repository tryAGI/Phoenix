
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType value)
        {
            return value switch
            {
                SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType.ChatCompletions => "chat_completions",
                SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType.ChatCompletions,
                "responses" => SummarizeEndpointAgentsAgentIdSessionsSessionIdSummaryPostOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}