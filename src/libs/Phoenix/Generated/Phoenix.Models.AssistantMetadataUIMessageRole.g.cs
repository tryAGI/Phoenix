
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantMetadataUIMessageRole
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
    public static class AssistantMetadataUIMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantMetadataUIMessageRole value)
        {
            return value switch
            {
                AssistantMetadataUIMessageRole.Assistant => "assistant",
                AssistantMetadataUIMessageRole.System => "system",
                AssistantMetadataUIMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantMetadataUIMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AssistantMetadataUIMessageRole.Assistant,
                "system" => AssistantMetadataUIMessageRole.System,
                "user" => AssistantMetadataUIMessageRole.User,
                _ => null,
            };
        }
    }
}