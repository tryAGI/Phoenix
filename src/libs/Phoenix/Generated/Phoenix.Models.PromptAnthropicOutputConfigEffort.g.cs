
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAnthropicOutputConfigEffort
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
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAnthropicOutputConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAnthropicOutputConfigEffort value)
        {
            return value switch
            {
                PromptAnthropicOutputConfigEffort.High => "high",
                PromptAnthropicOutputConfigEffort.Low => "low",
                PromptAnthropicOutputConfigEffort.Max => "max",
                PromptAnthropicOutputConfigEffort.Medium => "medium",
                PromptAnthropicOutputConfigEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAnthropicOutputConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptAnthropicOutputConfigEffort.High,
                "low" => PromptAnthropicOutputConfigEffort.Low,
                "max" => PromptAnthropicOutputConfigEffort.Max,
                "medium" => PromptAnthropicOutputConfigEffort.Medium,
                "xhigh" => PromptAnthropicOutputConfigEffort.Xhigh,
                _ => null,
            };
        }
    }
}