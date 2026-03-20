#nullable enable

namespace Phoenix
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get the authenticated user<br/>
        /// Returns the profile of the currently authenticated user. When authentication is disabled, returns an anonymous user representation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetViewerResponseBody> GetViewerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}