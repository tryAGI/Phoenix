#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {

        /// <summary>
        /// Get prompt version by ID<br/>
        /// Retrieve a specific prompt version using its unique identifier. A prompt version contains the actual template and configuration.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetPromptResponseBody> GetPromptVersionByPromptVersionIdAsync(
            string promptVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}