#nullable enable

namespace Phoenix
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Chat
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AgentSessionChatAsync(
            string sessionId,

            global::Phoenix.ChatRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<string>> AgentSessionChatAsResponseAsync(
            string sessionId,

            global::Phoenix.ChatRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="headless">
        /// Whether a headless client (terminal or scripted) is driving the turn, as opposed to the browser assistant. Selects the agent configuration the turn runs on.
        /// </param>
        /// <param name="contexts"></param>
        /// <param name="editPermission">
        /// Default Value: manual
        /// </param>
        /// <param name="requestedSkills">
        /// Skills the user explicitly requested via the prompt's slash-command affordance. The server force-loads each available skill by injecting a synthetic load_skill tool call/result at the tail of the message history. Unknown or context-unavailable names are ignored.
        /// </param>
        /// <param name="model">
        /// The model the client believes the session is set to. This is a precondition, not an instruction: the turn always runs on the session's persisted selection, and a mismatch is rejected with HTTP 409 and code ``agent_session_model_stale`` rather than silently running on — or switching to — an unexpected model. Change the session's model with ``PATCH .../agent_sessions/{session_id}``.
        /// </param>
        /// <param name="trigger">
        /// Default Value: submit-message
        /// </param>
        /// <param name="id"></param>
        /// <param name="message">
        /// The turn's new user message to append. May be omitted for client-tool continuation, where ``toolOutputs`` resolve the trailing assistant message's pending tool calls instead.
        /// </param>
        /// <param name="toolOutputs">
        /// Client-executed tool results for pending tool calls on the transcript's trailing assistant message, matched by ``toolCallId``. Submitted alone they continue the assistant turn; submitted with ``message`` they resolve dangling tool calls before the new user turn runs.
        /// </param>
        /// <param name="lastMessageId">
        /// The id of the last transcript message the client has rendered, used for optimistic concurrency. Omit when the session has no messages; required (and validated against the persisted transcript) once it does. On mismatch the server rejects the send with HTTP 409 and code ``agent_session_messages_stale`` — the client should refetch the session before retrying.
        /// </param>
        /// <param name="recordLocalTraces">
        /// Default Value: false
        /// </param>
        /// <param name="exportRemoteTraces">
        /// Default Value: false
        /// </param>
        /// <param name="instrumentUserId">
        /// When true and the request is authenticated as a PhoenixUser, attaches the user's email as the OpenInference ``user.id`` span attribute on all traced work for this request.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AgentSessionChatAsync(
            string sessionId,
            bool headless,
            global::Phoenix.AgentModelSelection model,
            string id,
            global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? contexts = default,
            global::Phoenix.ChatRequestBodyEditPermission? editPermission = default,
            global::System.Collections.Generic.IList<string>? requestedSkills = default,
            string? trigger = default,
            global::Phoenix.PhoenixUIMessage? message = default,
            global::System.Collections.Generic.IList<global::Phoenix.AnyOf<global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart, global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart>>? toolOutputs = default,
            string? lastMessageId = default,
            bool? recordLocalTraces = default,
            bool? exportRemoteTraces = default,
            bool? instrumentUserId = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}