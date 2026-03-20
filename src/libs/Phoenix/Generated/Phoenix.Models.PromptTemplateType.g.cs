
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTemplateType
    {
        /// <summary>
        /// 
        /// </summary>
        Str,
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTemplateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTemplateType value)
        {
            return value switch
            {
                PromptTemplateType.Str => "STR",
                PromptTemplateType.Chat => "CHAT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTemplateType? ToEnum(string value)
        {
            return value switch
            {
                "STR" => PromptTemplateType.Str,
                "CHAT" => PromptTemplateType.Chat,
                _ => null,
            };
        }
    }
}