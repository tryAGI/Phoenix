
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Machine-readable reason the request conflicted.
    /// </summary>
    public enum AgentSessionConflictErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        AgentSessionAlreadyCompact,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionBusy,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionCompactionConflict,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionMessagesStale,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionModelStale,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionToolApprovalsConflict,
        /// <summary>
        /// 
        /// </summary>
        AgentSessionToolOutputsConflict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSessionConflictErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSessionConflictErrorCode value)
        {
            return value switch
            {
                AgentSessionConflictErrorCode.AgentSessionAlreadyCompact => "agent_session_already_compact",
                AgentSessionConflictErrorCode.AgentSessionBusy => "agent_session_busy",
                AgentSessionConflictErrorCode.AgentSessionCompactionConflict => "agent_session_compaction_conflict",
                AgentSessionConflictErrorCode.AgentSessionMessagesStale => "agent_session_messages_stale",
                AgentSessionConflictErrorCode.AgentSessionModelStale => "agent_session_model_stale",
                AgentSessionConflictErrorCode.AgentSessionToolApprovalsConflict => "agent_session_tool_approvals_conflict",
                AgentSessionConflictErrorCode.AgentSessionToolOutputsConflict => "agent_session_tool_outputs_conflict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSessionConflictErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "agent_session_already_compact" => AgentSessionConflictErrorCode.AgentSessionAlreadyCompact,
                "agent_session_busy" => AgentSessionConflictErrorCode.AgentSessionBusy,
                "agent_session_compaction_conflict" => AgentSessionConflictErrorCode.AgentSessionCompactionConflict,
                "agent_session_messages_stale" => AgentSessionConflictErrorCode.AgentSessionMessagesStale,
                "agent_session_model_stale" => AgentSessionConflictErrorCode.AgentSessionModelStale,
                "agent_session_tool_approvals_conflict" => AgentSessionConflictErrorCode.AgentSessionToolApprovalsConflict,
                "agent_session_tool_outputs_conflict" => AgentSessionConflictErrorCode.AgentSessionToolOutputsConflict,
                _ => null,
            };
        }
    }
}