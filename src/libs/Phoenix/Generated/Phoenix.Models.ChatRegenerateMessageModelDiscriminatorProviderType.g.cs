
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRegenerateMessageModelDiscriminatorProviderType
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
    public static class ChatRegenerateMessageModelDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRegenerateMessageModelDiscriminatorProviderType value)
        {
            return value switch
            {
                ChatRegenerateMessageModelDiscriminatorProviderType.Builtin => "builtin",
                ChatRegenerateMessageModelDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRegenerateMessageModelDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatRegenerateMessageModelDiscriminatorProviderType.Builtin,
                "custom" => ChatRegenerateMessageModelDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}