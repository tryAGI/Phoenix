
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptPerplexityInvocationParametersContentReasoningEffort
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
    public static class PromptPerplexityInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptPerplexityInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptPerplexityInvocationParametersContentReasoningEffort.None => "none",
                PromptPerplexityInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptPerplexityInvocationParametersContentReasoningEffort.Low => "low",
                PromptPerplexityInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptPerplexityInvocationParametersContentReasoningEffort.High => "high",
                PromptPerplexityInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptPerplexityInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptPerplexityInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptPerplexityInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptPerplexityInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptPerplexityInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptPerplexityInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptPerplexityInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}