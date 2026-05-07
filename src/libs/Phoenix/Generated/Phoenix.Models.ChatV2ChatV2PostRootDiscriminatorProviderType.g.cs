
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatV2ChatV2PostRootDiscriminatorProviderType
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
    public static class ChatV2ChatV2PostRootDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatV2ChatV2PostRootDiscriminatorProviderType value)
        {
            return value switch
            {
                ChatV2ChatV2PostRootDiscriminatorProviderType.Builtin => "builtin",
                ChatV2ChatV2PostRootDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatV2ChatV2PostRootDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatV2ChatV2PostRootDiscriminatorProviderType.Builtin,
                "custom" => ChatV2ChatV2PostRootDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}