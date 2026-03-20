
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptXAIInvocationParametersContentReasoningEffort
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
    public static class PromptXAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptXAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptXAIInvocationParametersContentReasoningEffort.None => "none",
                PromptXAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptXAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptXAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptXAIInvocationParametersContentReasoningEffort.High => "high",
                PromptXAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptXAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptXAIInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptXAIInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptXAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptXAIInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptXAIInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptXAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}