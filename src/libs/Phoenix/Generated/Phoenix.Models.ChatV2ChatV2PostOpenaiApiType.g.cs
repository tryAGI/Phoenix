
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum ChatV2ChatV2PostOpenaiApiType
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
    public static class ChatV2ChatV2PostOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatV2ChatV2PostOpenaiApiType value)
        {
            return value switch
            {
                ChatV2ChatV2PostOpenaiApiType.ChatCompletions => "chat_completions",
                ChatV2ChatV2PostOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatV2ChatV2PostOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => ChatV2ChatV2PostOpenaiApiType.ChatCompletions,
                "responses" => ChatV2ChatV2PostOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}