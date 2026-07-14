
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoenixUIMessageMetadataVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoenixUIMessageMetadataVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoenixUIMessageMetadataVariant1DiscriminatorType value)
        {
            return value switch
            {
                PhoenixUIMessageMetadataVariant1DiscriminatorType.Assistant => "assistant",
                PhoenixUIMessageMetadataVariant1DiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoenixUIMessageMetadataVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => PhoenixUIMessageMetadataVariant1DiscriminatorType.Assistant,
                "user" => PhoenixUIMessageMetadataVariant1DiscriminatorType.User,
                _ => null,
            };
        }
    }
}