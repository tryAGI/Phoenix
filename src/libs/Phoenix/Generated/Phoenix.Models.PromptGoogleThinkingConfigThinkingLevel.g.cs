
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptGoogleThinkingConfigThinkingLevel
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptGoogleThinkingConfigThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptGoogleThinkingConfigThinkingLevel value)
        {
            return value switch
            {
                PromptGoogleThinkingConfigThinkingLevel.High => "high",
                PromptGoogleThinkingConfigThinkingLevel.Low => "low",
                PromptGoogleThinkingConfigThinkingLevel.Medium => "medium",
                PromptGoogleThinkingConfigThinkingLevel.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptGoogleThinkingConfigThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => PromptGoogleThinkingConfigThinkingLevel.High,
                "low" => PromptGoogleThinkingConfigThinkingLevel.Low,
                "medium" => PromptGoogleThinkingConfigThinkingLevel.Medium,
                "minimal" => PromptGoogleThinkingConfigThinkingLevel.Minimal,
                _ => null,
            };
        }
    }
}