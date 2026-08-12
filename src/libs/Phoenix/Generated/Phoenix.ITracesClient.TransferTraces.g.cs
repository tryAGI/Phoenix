#nullable enable

namespace Phoenix
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Transfer traces to a project<br/>
        /// Move traces into a different project. This re-parents the traces rather than copying them, so they no longer appear under their original project. All traces must currently belong to the same source project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.TransferTracesResponseBody> TransferTracesAsync(

            global::Phoenix.TransferTracesRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer traces to a project<br/>
        /// Move traces into a different project. This re-parents the traces rather than copying them, so they no longer appear under their original project. All traces must currently belong to the same source project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Phoenix.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.AutoSDKHttpResponse<global::Phoenix.TransferTracesResponseBody>> TransferTracesAsResponseAsync(

            global::Phoenix.TransferTracesRequestBody request,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transfer traces to a project<br/>
        /// Move traces into a different project. This re-parents the traces rather than copying them, so they no longer appear under their original project. All traces must currently belong to the same source project.
        /// </summary>
        /// <param name="traceIdentifiers">
        /// The traces to transfer. Each identifier is either a trace ID (GlobalID) or an OpenTelemetry trace_id (hex string). Must be non-empty, and all traces must currently belong to the same source project.
        /// </param>
        /// <param name="destinationProjectIdentifier">
        /// The destination project: either project ID (GlobalID) or project name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Phoenix.TransferTracesResponseBody> TransferTracesAsync(
            global::System.Collections.Generic.IList<string> traceIdentifiers,
            string destinationProjectIdentifier,
            global::Phoenix.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}