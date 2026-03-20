#nullable enable

namespace Phoenix
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get session by ID or session_id
        /// </summary>
        /// <param name="sessionIdentifier">
        /// The session identifier: either a GlobalID or user-provided session_id string.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetSessionResponseBody> GetSessionAsync(
            string sessionIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}