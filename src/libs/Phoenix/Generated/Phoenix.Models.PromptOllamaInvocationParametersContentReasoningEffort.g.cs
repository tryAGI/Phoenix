
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptOllamaInvocationParametersContentReasoningEffort
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
    public static class PromptOllamaInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptOllamaInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptOllamaInvocationParametersContentReasoningEffort.None => "none",
                PromptOllamaInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptOllamaInvocationParametersContentReasoningEffort.Low => "low",
                PromptOllamaInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptOllamaInvocationParametersContentReasoningEffort.High => "high",
                PromptOllamaInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptOllamaInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptOllamaInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptOllamaInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptOllamaInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptOllamaInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptOllamaInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptOllamaInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}