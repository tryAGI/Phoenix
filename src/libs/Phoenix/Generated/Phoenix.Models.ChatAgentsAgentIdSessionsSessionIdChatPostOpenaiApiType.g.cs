
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Default Value: responses
    /// </summary>
    public enum ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType
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
    public static class ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType value)
        {
            return value switch
            {
                ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType.ChatCompletions => "chat_completions",
                ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType.Responses => "responses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType? ToEnum(string value)
        {
            return value switch
            {
                "chat_completions" => ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType.ChatCompletions,
                "responses" => ChatAgentsAgentIdSessionsSessionIdChatPostOpenaiApiType.Responses,
                _ => null,
            };
        }
    }
}