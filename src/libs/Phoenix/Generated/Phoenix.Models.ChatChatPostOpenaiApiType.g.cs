
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum ChatChatPostOpenaiApiType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletions,
        /// <summary>
        /// 
        /// </summary>
        Responses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatChatPostOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatChatPostOpenaiApiType value)
        {
            return value switch
            {
                ChatChatPostOpenaiApiType.ChatCompletions => "chat_completions",
                ChatChatPostOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatChatPostOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => ChatChatPostOpenaiApiType.ChatCompletions,
                "responses" => ChatChatPostOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}