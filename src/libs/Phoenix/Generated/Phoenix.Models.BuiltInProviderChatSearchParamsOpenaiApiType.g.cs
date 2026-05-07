
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum BuiltInProviderChatSearchParamsOpenaiApiType
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
    public static class BuiltInProviderChatSearchParamsOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuiltInProviderChatSearchParamsOpenaiApiType value)
        {
            return value switch
            {
                BuiltInProviderChatSearchParamsOpenaiApiType.ChatCompletions => "chat_completions",
                BuiltInProviderChatSearchParamsOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuiltInProviderChatSearchParamsOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => BuiltInProviderChatSearchParamsOpenaiApiType.ChatCompletions,
                "responses" => BuiltInProviderChatSearchParamsOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}