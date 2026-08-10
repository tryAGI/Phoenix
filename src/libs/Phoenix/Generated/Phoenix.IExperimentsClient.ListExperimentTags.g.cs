#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// List the tags applied to an experiment<br/>
        /// List the tags currently pointing at this experiment. Tags are scoped to the experiment's dataset, so a tag appears here only while this experiment owns it.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.ListExperimentTagsResponseBody> ListExperimentTagsAsync(
            string experimentId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the tags applied to an experiment<br/>
        /// List the tags currently pointing at this experiment. Tags are scoped to the experiment's dataset, so a tag appears here only while this experiment owns it.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.ListExperimentTagsResponseBody>> ListExperimentTagsAsResponseAsync(
            string experimentId,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}