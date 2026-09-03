
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptZAIInvocationParametersContentReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
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
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptZAIInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptZAIInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptZAIInvocationParametersContentReasoningEffort.High => "high",
                PromptZAIInvocationParametersContentReasoningEffort.Low => "low",
                PromptZAIInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptZAIInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptZAIInvocationParametersContentReasoningEffort.None => "none",
                PromptZAIInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptZAIInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptZAIInvocationParametersContentReasoningEffort.High,
                "low" => PromptZAIInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptZAIInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptZAIInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptZAIInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptZAIInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}