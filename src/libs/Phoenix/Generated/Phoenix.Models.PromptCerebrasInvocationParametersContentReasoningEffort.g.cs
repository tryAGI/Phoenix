
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCerebrasInvocationParametersContentReasoningEffort
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
    public static class PromptCerebrasInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCerebrasInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptCerebrasInvocationParametersContentReasoningEffort.None => "none",
                PromptCerebrasInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptCerebrasInvocationParametersContentReasoningEffort.Low => "low",
                PromptCerebrasInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptCerebrasInvocationParametersContentReasoningEffort.High => "high",
                PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCerebrasInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptCerebrasInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptCerebrasInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptCerebrasInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptCerebrasInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptCerebrasInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptCerebrasInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}