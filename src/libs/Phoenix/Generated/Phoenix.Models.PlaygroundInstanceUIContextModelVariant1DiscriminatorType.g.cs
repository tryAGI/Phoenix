
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public enum PlaygroundInstanceUIContextModelVariant1DiscriminatorType
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
    public static class PlaygroundInstanceUIContextModelVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundInstanceUIContextModelVariant1DiscriminatorType value)
        {
            return value switch
            {
                PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Builtin => "builtin",
                PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundInstanceUIContextModelVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Builtin,
                "custom" => PlaygroundInstanceUIContextModelVariant1DiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}