
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatAgentsAgentIdSessionsSessionIdChatPostProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatAgentsAgentIdSessionsSessionIdChatPostProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatAgentsAgentIdSessionsSessionIdChatPostProviderType value)
        {
            return value switch
            {
                ChatAgentsAgentIdSessionsSessionIdChatPostProviderType.Builtin => "builtin",
                ChatAgentsAgentIdSessionsSessionIdChatPostProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatAgentsAgentIdSessionsSessionIdChatPostProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => ChatAgentsAgentIdSessionsSessionIdChatPostProviderType.Builtin,
                "custom" => ChatAgentsAgentIdSessionsSessionIdChatPostProviderType.Custom,
                _ => null,
            };
        }
    }
}