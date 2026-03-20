
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptFireworksInvocationParametersContentReasoningEffort
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
    public static class PromptFireworksInvocationParametersContentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptFireworksInvocationParametersContentReasoningEffort value)
        {
            return value switch
            {
                PromptFireworksInvocationParametersContentReasoningEffort.None => "none",
                PromptFireworksInvocationParametersContentReasoningEffort.Minimal => "minimal",
                PromptFireworksInvocationParametersContentReasoningEffort.Low => "low",
                PromptFireworksInvocationParametersContentReasoningEffort.Medium => "medium",
                PromptFireworksInvocationParametersContentReasoningEffort.High => "high",
                PromptFireworksInvocationParametersContentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptFireworksInvocationParametersContentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "none" => PromptFireworksInvocationParametersContentReasoningEffort.None,
                "minimal" => PromptFireworksInvocationParametersContentReasoningEffort.Minimal,
                "low" => PromptFireworksInvocationParametersContentReasoningEffort.Low,
                "medium" => PromptFireworksInvocationParametersContentReasoningEffort.Medium,
                "high" => PromptFireworksInvocationParametersContentReasoningEffort.High,
                "xhigh" => PromptFireworksInvocationParametersContentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}