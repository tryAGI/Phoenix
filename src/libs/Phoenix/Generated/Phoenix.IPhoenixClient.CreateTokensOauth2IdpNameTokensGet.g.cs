#nullable enable

namespace Phoenix
{
    public partial interface IPhoenixClient
    {
        /// <summary>
        /// Create Tokens
        /// </summary>
        /// <param name="idpName"></param>
        /// <param name="state"></param>
        /// <param name="code"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="phoenixOauth2State"></param>
        /// <param name="phoenixOauth2Nonce"></param>
        /// <param name="phoenixOauth2CodeVerifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateTokensOauth2IdpNameTokensGetAsync(
            string idpName,
            string state,
            string phoenixOauth2State,
            string phoenixOauth2Nonce,
            string? code = default,
            string? error = default,
            string? errorDescription = default,
            string? phoenixOauth2CodeVerifier = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tokens
        /// </summary>
        /// <param name="idpName"></param>
        /// <param name="state"></param>
        /// <param name="code"></param>
        /// <param name="error"></param>
        /// <param name="errorDescription"></param>
        /// <param name="phoenixOauth2State"></param>
        /// <param name="phoenixOauth2Nonce"></param>
        /// <param name="phoenixOauth2CodeVerifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<string>> CreateTokensOauth2IdpNameTokensGetAsResponseAsync(
            string idpName,
            string state,
            string phoenixOauth2State,
            string phoenixOauth2Nonce,
            string? code = default,
            string? error = default,
            string? errorDescription = default,
            string? phoenixOauth2CodeVerifier = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}