
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatChatPostRootDiscriminatorProviderType
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
    public static class ChatChatPostRootDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatChatPostRootDiscriminatorProviderType value)
        {
            return value switch
            {
                ChatChatPostRootDiscriminatorProviderType.Builtin => "builtin",
                ChatChatPostRootDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatChatPostRootDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatChatPostRootDiscriminatorProviderType.Builtin,
                "custom" => ChatChatPostRootDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}