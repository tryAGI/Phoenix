
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptOpenAIInvocationParametersContentReasoningEffort
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
    public static class PromptOpenAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptOpenAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptOpenAIInvocationParametersContentReasoningEffort.None => "none",
                PromptOpenAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptOpenAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptOpenAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptOpenAIInvocationParametersContentReasoningEffort.High => "high",
                PromptOpenAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptOpenAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptOpenAIInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptOpenAIInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptOpenAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptOpenAIInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptOpenAIInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptOpenAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}