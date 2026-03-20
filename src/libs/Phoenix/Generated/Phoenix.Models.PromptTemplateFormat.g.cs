
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mustache,
        /// <summary>
        /// 
        /// </summary>
        FString,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateFormat value)
        {
            return value switch
            {
                PromptTemplateFormat.Mustache => "MUSTACHE",
                PromptTemplateFormat.FString => "F_STRING",
                PromptTemplateFormat.None => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "MUSTACHE" => PromptTemplateFormat.Mustache,
                "F_STRING" => PromptTemplateFormat.FString,
                "NONE" => PromptTemplateFormat.None,
                _ => null,
            };
        }
    }
}