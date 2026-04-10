#nullable enable

namespace Phoenix
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Create a new user<br/>
        /// Create a new user with the specified configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateUserResponseBody> CreateUserAsync(

            global::Phoenix.CreateUserRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new user<br/>
        /// Create a new user with the specified configuration.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="sendWelcomeEmail">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreateUserResponseBody> CreateUserAsync(
            global::Phoenix.User user,
            bool? sendWelcomeEmail = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}