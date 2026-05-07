
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatV2ChatV2PostRequestDiscriminatorTrigger
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
    public static class ChatV2ChatV2PostRequestDiscriminatorTriggerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatV2ChatV2PostRequestDiscriminatorTrigger value)
        {
            return value switch
            {
                ChatV2ChatV2PostRequestDiscriminatorTrigger.RegenerateMessage => "regenerate-message",
                ChatV2ChatV2PostRequestDiscriminatorTrigger.SubmitMessage => "submit-message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatV2ChatV2PostRequestDiscriminatorTrigger? ToEnum(string value)
        {
            return value switch
            {
                "regenerate-message" => ChatV2ChatV2PostRequestDiscriminatorTrigger.RegenerateMessage,
                "submit-message" => ChatV2ChatV2PostRequestDiscriminatorTrigger.SubmitMessage,
                _ => null,
            };
        }
    }
}