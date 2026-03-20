#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {

        /// <summary>
        /// List prompt versions<br/>
        /// Retrieve all versions of a specific prompt with pagination support. Each prompt can have multiple versions with different configurations.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded promptVersion ID)
        /// </param>
        /// <param name="limit">
        /// The max number of prompt versions to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetPromptVersionsResponseBody> ListPromptVersionsAsync(
            string promptIdentifier,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}