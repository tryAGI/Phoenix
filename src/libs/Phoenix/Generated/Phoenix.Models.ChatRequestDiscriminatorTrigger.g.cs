
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestDiscriminatorTrigger
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
    public static class ChatRequestDiscriminatorTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestDiscriminatorTrigger value)
        {
            return value switch
            {
                ChatRequestDiscriminatorTrigger.RegenerateMessage => "regenerate-message",
                ChatRequestDiscriminatorTrigger.SubmitMessage => "submit-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestDiscriminatorTrigger? ToEnum(string value)
        {
            return value switch
            {
                "regenerate-message" => ChatRequestDiscriminatorTrigger.RegenerateMessage,
                "submit-message" => ChatRequestDiscriminatorTrigger.SubmitMessage,
                _ => null,
            };
        }
    }
}