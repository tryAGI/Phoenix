
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyAssistantMetadataUIMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyAssistantMetadataUIMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyAssistantMetadataUIMessageRole value)
        {
            return value switch
            {
                LegacyAssistantMetadataUIMessageRole.Assistant => "assistant",
                LegacyAssistantMetadataUIMessageRole.System => "system",
                LegacyAssistantMetadataUIMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyAssistantMetadataUIMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LegacyAssistantMetadataUIMessageRole.Assistant,
                "system" => LegacyAssistantMetadataUIMessageRole.System,
                "user" => LegacyAssistantMetadataUIMessageRole.User,
                _ => null,
            };
        }
    }
}