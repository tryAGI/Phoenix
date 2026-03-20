
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptDeepSeekInvocationParametersContentReasoningEffort
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
    public static class PromptDeepSeekInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptDeepSeekInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptDeepSeekInvocationParametersContentReasoningEffort.None => "none",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Low => "low",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptDeepSeekInvocationParametersContentReasoningEffort.High => "high",
                PromptDeepSeekInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptDeepSeekInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptDeepSeekInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptDeepSeekInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptDeepSeekInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptDeepSeekInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptDeepSeekInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptDeepSeekInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}