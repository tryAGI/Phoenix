
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTogetherInvocationParametersContentReasoningEffort
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTogetherInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTogetherInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptTogetherInvocationParametersContentReasoningEffort.None => "none",
                PromptTogetherInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptTogetherInvocationParametersContentReasoningEffort.Low => "low",
                PromptTogetherInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptTogetherInvocationParametersContentReasoningEffort.High => "high",
                PromptTogetherInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTogetherInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptTogetherInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptTogetherInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptTogetherInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptTogetherInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptTogetherInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptTogetherInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}