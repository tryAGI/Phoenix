
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAnthropicThinkingConfigEnabledDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        Omitted,
        /// <summary>
        /// 
        /// </summary>
        Summarized,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptAnthropicThinkingConfigEnabledDisplayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAnthropicThinkingConfigEnabledDisplay value)
        {
            return value switch
            {
                PromptAnthropicThinkingConfigEnabledDisplay.Omitted => "omitted",
                PromptAnthropicThinkingConfigEnabledDisplay.Summarized => "summarized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAnthropicThinkingConfigEnabledDisplay? ToEnum(string value)
        {
            return value switch
            {
                "omitted" => PromptAnthropicThinkingConfigEnabledDisplay.Omitted,
                "summarized" => PromptAnthropicThinkingConfigEnabledDisplay.Summarized,
                _ => null,
            };
        }
    }
}