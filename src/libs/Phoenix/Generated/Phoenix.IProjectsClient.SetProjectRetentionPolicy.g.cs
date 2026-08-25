#nullable enable

namespace Phoenix
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Set a project's trace retention policy<br/>
        /// Assign an existing trace retention policy to a project, or reset the project to the default policy with a null `policy_id`. Retention policies are standalone, reusable entities: this endpoint only changes which policy the project points at, and never creates, edits, or deletes a policy.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetProjectRetentionPolicyResponseBody> SetProjectRetentionPolicyAsync(
            string projectIdentifier,

            global::Phoenix.SetProjectRetentionPolicyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a project's trace retention policy<br/>
        /// Assign an existing trace retention policy to a project, or reset the project to the default policy with a null `policy_id`. Retention policies are standalone, reusable entities: this endpoint only changes which policy the project points at, and never creates, edits, or deletes a policy.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.SetProjectRetentionPolicyResponseBody>> SetProjectRetentionPolicyAsResponseAsync(
            string projectIdentifier,

            global::Phoenix.SetProjectRetentionPolicyRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a project's trace retention policy<br/>
        /// Assign an existing trace retention policy to a project, or reset the project to the default policy with a null `policy_id`. Retention policies are standalone, reusable entities: this endpoint only changes which policy the project points at, and never creates, edits, or deletes a policy.
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="policyId">
        /// The ID (GlobalID) of an existing trace retention policy to assign, or null to reset the project to the default policy.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.SetProjectRetentionPolicyResponseBody> SetProjectRetentionPolicyAsync(
            string projectIdentifier,
            string? policyId = default,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}