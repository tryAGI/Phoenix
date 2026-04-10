#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Get prompt version by tag<br/>
        /// Retrieve a specific prompt version using its tag name. Tags are used to identify specific versions of a prompt.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="tagName">
        /// The tag of the prompt version
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetPromptResponseBody> GetPromptVersionByTagNameAsync(
            string promptIdentifier,
            string tagName,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}