
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundInstanceContextModelVariant1DiscriminatorType
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
    public static class PlaygroundInstanceContextModelVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundInstanceContextModelVariant1DiscriminatorType value)
        {
            return value switch
            {
                PlaygroundInstanceContextModelVariant1DiscriminatorType.Builtin => "builtin",
                PlaygroundInstanceContextModelVariant1DiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundInstanceContextModelVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => PlaygroundInstanceContextModelVariant1DiscriminatorType.Builtin,
                "custom" => PlaygroundInstanceContextModelVariant1DiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}