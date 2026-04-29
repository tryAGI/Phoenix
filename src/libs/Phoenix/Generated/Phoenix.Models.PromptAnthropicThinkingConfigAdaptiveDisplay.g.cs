
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAnthropicThinkingConfigAdaptiveDisplay
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
    public static class PromptAnthropicThinkingConfigAdaptiveDisplayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAnthropicThinkingConfigAdaptiveDisplay value)
        {
            return value switch
            {
                PromptAnthropicThinkingConfigAdaptiveDisplay.Omitted => "omitted",
                PromptAnthropicThinkingConfigAdaptiveDisplay.Summarized => "summarized",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAnthropicThinkingConfigAdaptiveDisplay? ToEnum(string value)
        {
            return value switch
            {
                "omitted" => PromptAnthropicThinkingConfigAdaptiveDisplay.Omitted,
                "summarized" => PromptAnthropicThinkingConfigAdaptiveDisplay.Summarized,
                _ => null,
            };
        }
    }
}