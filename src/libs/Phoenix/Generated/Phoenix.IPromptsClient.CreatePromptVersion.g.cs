#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Create prompt version<br/>
        /// Create a new version for an existing prompt by identifier.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreatePromptVersionResponseBody> CreatePromptVersionAsync(
            string promptIdentifier,

            global::Phoenix.CreatePromptVersionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prompt version<br/>
        /// Create a new version for an existing prompt by identifier.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.CreatePromptVersionResponseBody>> CreatePromptVersionAsResponseAsync(
            string promptIdentifier,

            global::Phoenix.CreatePromptVersionRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create prompt version<br/>
        /// Create a new version for an existing prompt by identifier.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="version"></param>
        /// <param name="tags"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.CreatePromptVersionResponseBody> CreatePromptVersionAsync(
            string promptIdentifier,
            global::Phoenix.PromptVersionData version,
            global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTagData>? tags = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}