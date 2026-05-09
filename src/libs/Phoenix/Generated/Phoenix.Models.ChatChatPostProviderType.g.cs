
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatChatPostProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatChatPostProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatChatPostProviderType value)
        {
            return value switch
            {
                ChatChatPostProviderType.Builtin => "builtin",
                ChatChatPostProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatChatPostProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatChatPostProviderType.Builtin,
                "custom" => ChatChatPostProviderType.Custom,
                _ => null,
            };
        }
    }
}