#nullable enable

namespace Phoenix
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Delete a prompt<br/>
        /// Delete a prompt and all its versions, tags, and labels by identifier.
        /// </summary>
        /// <param name="promptIdentifier">
        /// The identifier of the prompt, i.e. name or ID.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePromptAsync(
            string promptIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}