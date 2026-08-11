
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageMetadataPhoenixVariant1DiscriminatorType
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
    public static class MessageMetadataPhoenixVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageMetadataPhoenixVariant1DiscriminatorType value)
        {
            return value switch
            {
                MessageMetadataPhoenixVariant1DiscriminatorType.Assistant => "assistant",
                MessageMetadataPhoenixVariant1DiscriminatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageMetadataPhoenixVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageMetadataPhoenixVariant1DiscriminatorType.Assistant,
                "user" => MessageMetadataPhoenixVariant1DiscriminatorType.User,
                _ => null,
            };
        }
    }
}