#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Get experiment by ID
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.GetExperimentResponseBody> GetExperimentAsync(
            string experimentId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}