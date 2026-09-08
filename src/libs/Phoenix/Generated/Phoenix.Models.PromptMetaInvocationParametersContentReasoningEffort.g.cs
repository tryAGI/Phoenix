
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptMetaInvocationParametersContentReasoningEffort
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
    public static class PromptMetaInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptMetaInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptMetaInvocationParametersContentReasoningEffort.High => "high",
                PromptMetaInvocationParametersContentReasoningEffort.Low => "low",
                PromptMetaInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptMetaInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptMetaInvocationParametersContentReasoningEffort.None => "none",
                PromptMetaInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptMetaInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptMetaInvocationParametersContentReasoningEffort.High,
                "low" => PromptMetaInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptMetaInvocationParametersContentReasoningEffort.Medium,
                "minimal" => PromptMetaInvocationParametersContentReasoningEffort.Minimal,
                "none" => PromptMetaInvocationParametersContentReasoningEffort.None,
                "xhigh" => PromptMetaInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}