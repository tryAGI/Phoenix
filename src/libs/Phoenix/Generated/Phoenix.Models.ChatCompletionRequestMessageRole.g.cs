
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestMessageRole.Assistant => "assistant",
                ChatCompletionRequestMessageRole.Developer => "developer",
                ChatCompletionRequestMessageRole.System => "system",
                ChatCompletionRequestMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionRequestMessageRole.Assistant,
                "developer" => ChatCompletionRequestMessageRole.Developer,
                "system" => ChatCompletionRequestMessageRole.System,
                "user" => ChatCompletionRequestMessageRole.User,
                _ => null,
            };
        }
    }
}