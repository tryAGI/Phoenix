#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {

        /// <summary>
        /// List dataset versions
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="limit">
        /// The max number of dataset versions to return at a time<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListDatasetVersionsResponseBody> ListDatasetVersionsByDatasetIdAsync(
            string id,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}