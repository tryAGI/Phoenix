#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Remove a tag from an experiment<br/>
        /// Remove a tag, identified by its node ID or name, from the experiment that owns it. This operation is idempotent and never steals a tag from another experiment: if the experiment does not currently own the tag, the request is a no-op.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="tagIdentifier">
        /// The node ID or name of the tag to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteExperimentTagAsync(
            string experimentId,
            string tagIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a tag from an experiment<br/>
        /// Remove a tag, identified by its node ID or name, from the experiment that owns it. This operation is idempotent and never steals a tag from another experiment: if the experiment does not currently own the tag, the request is a no-op.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="tagIdentifier">
        /// The node ID or name of the tag to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse> DeleteExperimentTagAsResponseAsync(
            string experimentId,
            string tagIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}