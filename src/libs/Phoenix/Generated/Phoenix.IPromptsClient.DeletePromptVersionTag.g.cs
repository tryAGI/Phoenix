#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete a tag from a prompt version<br/>
        /// Delete a tag from a specific prompt version by tag name. The tag is resolved within the scope of the prompt linked to the version.
        /// </summary>
        /// <param name="promptVersionId">
        /// The ID of the prompt version.
        /// </param>
        /// <param name="tagName">
        /// The name of the tag to delete.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptVersionTagAsync(
            string promptVersionId,
            string tagName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}