#nullable enable

namespace Phoenix
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Assign a tag to an experiment<br/>
        /// Assign a tag to an experiment. Tags are scoped to the experiment's dataset and each tag name points at a single experiment, so assigning a tag that another experiment on the same dataset owns atomically moves the tag to this experiment. Re-assigning a tag the experiment already owns is idempotent and replaces the description. Assigning the reserved 'baseline' tag makes this experiment the dataset's baseline; ephemeral experiments cannot become the baseline.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetExperimentTagResponseBody> SetExperimentTagAsync(
            string experimentId,

            global::Phoenix.SetExperimentTagRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign a tag to an experiment<br/>
        /// Assign a tag to an experiment. Tags are scoped to the experiment's dataset and each tag name points at a single experiment, so assigning a tag that another experiment on the same dataset owns atomically moves the tag to this experiment. Re-assigning a tag the experiment already owns is idempotent and replaces the description. Assigning the reserved 'baseline' tag makes this experiment the dataset's baseline; ephemeral experiments cannot become the baseline.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SetExperimentTagResponseBody>> SetExperimentTagAsResponseAsync(
            string experimentId,

            global::Phoenix.SetExperimentTagRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign a tag to an experiment<br/>
        /// Assign a tag to an experiment. Tags are scoped to the experiment's dataset and each tag name points at a single experiment, so assigning a tag that another experiment on the same dataset owns atomically moves the tag to this experiment. Re-assigning a tag the experiment already owns is idempotent and replaces the description. Assigning the reserved 'baseline' tag makes this experiment the dataset's baseline; ephemeral experiments cannot become the baseline.
        /// </summary>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="name">
        /// The name of the tag to assign, e.g. 'baseline'. If another experiment on the same dataset already owns this tag, the tag is moved to this experiment.
        /// </param>
        /// <param name="description">
        /// An optional description of the tag (replaces any existing description)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetExperimentTagResponseBody> SetExperimentTagAsync(
            string experimentId,
            string name,
            string? description = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}