
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptGroqInvocationParametersContentReasoningEffort
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
    public static class PromptGroqInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptGroqInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptGroqInvocationParametersContentReasoningEffort.None => "none",
                PromptGroqInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptGroqInvocationParametersContentReasoningEffort.Low => "low",
                PromptGroqInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptGroqInvocationParametersContentReasoningEffort.High => "high",
                PromptGroqInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptGroqInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptGroqInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptGroqInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptGroqInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptGroqInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptGroqInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptGroqInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}