
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptMoonshotInvocationParametersContentReasoningEffort
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
    public static class PromptMoonshotInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMoonshotInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptMoonshotInvocationParametersContentReasoningEffort.None => "none",
                PromptMoonshotInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptMoonshotInvocationParametersContentReasoningEffort.Low => "low",
                PromptMoonshotInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptMoonshotInvocationParametersContentReasoningEffort.High => "high",
                PromptMoonshotInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMoonshotInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptMoonshotInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptMoonshotInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptMoonshotInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptMoonshotInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptMoonshotInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptMoonshotInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}