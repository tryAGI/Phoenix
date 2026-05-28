
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSubmitMessageModelDiscriminatorProviderType
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
    public static class ChatSubmitMessageModelDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSubmitMessageModelDiscriminatorProviderType value)
        {
            return value switch
            {
                ChatSubmitMessageModelDiscriminatorProviderType.Builtin => "builtin",
                ChatSubmitMessageModelDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSubmitMessageModelDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatSubmitMessageModelDiscriminatorProviderType.Builtin,
                "custom" => ChatSubmitMessageModelDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}