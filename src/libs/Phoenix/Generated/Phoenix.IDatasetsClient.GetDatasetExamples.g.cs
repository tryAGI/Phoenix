#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {

        /// <summary>
        /// Get examples from a dataset
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="versionId">
        /// The ID of the dataset version (if omitted, returns data from the latest version)
        /// </param>
        /// <param name="split">
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListDatasetExamplesResponseBody> GetDatasetExamplesAsync(
            string id,
            string? versionId = default,
            global::System.Collections.Generic.IList<string>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}