#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination
        /// </param>
        /// <param name="name">
        /// An optional dataset name to filter by
        /// </param>
        /// <param name="limit">
        /// The max number of datasets to return at a time.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListDatasetsResponseBody> ListDatasetsAsync(
            string? cursor = default,
            string? name = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}