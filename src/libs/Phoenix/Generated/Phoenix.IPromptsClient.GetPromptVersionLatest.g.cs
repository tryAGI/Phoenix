#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {

        /// <summary>
        /// Get latest prompt version<br/>
        /// Retrieve the most recent version of a specific prompt.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetPromptResponseBody> GetPromptVersionLatestAsync(
            string promptIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}