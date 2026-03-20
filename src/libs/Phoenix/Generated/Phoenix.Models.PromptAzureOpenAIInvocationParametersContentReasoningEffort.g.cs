
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAzureOpenAIInvocationParametersContentReasoningEffort
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
    public static class PromptAzureOpenAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAzureOpenAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.None => "none",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.High => "high",
                PromptAzureOpenAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAzureOpenAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptAzureOpenAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}