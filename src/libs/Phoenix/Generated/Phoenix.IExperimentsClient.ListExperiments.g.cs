#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {

        /// <summary>
        /// List experiments by dataset<br/>
        /// Retrieve a paginated list of experiments for the specified dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded experiment ID)
        /// </param>
        /// <param name="limit">
        /// The max number of experiments to return at a time.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListExperimentsResponseBody> ListExperimentsAsync(
            string datasetId,
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}