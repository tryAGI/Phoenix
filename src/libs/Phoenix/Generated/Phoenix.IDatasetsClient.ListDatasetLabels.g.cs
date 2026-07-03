#nullable enable

namespace Phoenix
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List dataset labels<br/>
        /// Retrieve a paginated list of all dataset labels in the system.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (a dataset label GlobalID)
        /// </param>
        /// <param name="limit">
        /// The max number of dataset labels to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetDatasetLabelsResponseBody> ListDatasetLabelsAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List dataset labels<br/>
        /// Retrieve a paginated list of all dataset labels in the system.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (a dataset label GlobalID)
        /// </param>
        /// <param name="limit">
        /// The max number of dataset labels to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.GetDatasetLabelsResponseBody>> ListDatasetLabelsAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}