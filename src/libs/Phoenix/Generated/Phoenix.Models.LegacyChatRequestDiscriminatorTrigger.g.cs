
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyChatRequestDiscriminatorTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        RegenerateMessage,
        /// <summary>
        /// 
        /// </summary>
        SubmitMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyChatRequestDiscriminatorTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyChatRequestDiscriminatorTrigger value)
        {
            return value switch
            {
                LegacyChatRequestDiscriminatorTrigger.RegenerateMessage => "regenerate-message",
                LegacyChatRequestDiscriminatorTrigger.SubmitMessage => "submit-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyChatRequestDiscriminatorTrigger? ToEnum(string value)
        {
            return value switch
            {
                "regenerate-message" => LegacyChatRequestDiscriminatorTrigger.RegenerateMessage,
                "submit-message" => LegacyChatRequestDiscriminatorTrigger.SubmitMessage,
                _ => null,
            };
        }
    }
}