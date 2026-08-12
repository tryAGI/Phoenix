
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferTracesRequestBody
    {
        /// <summary>
        /// The traces to transfer. Each identifier is either a trace ID (GlobalID) or an OpenTelemetry trace_id (hex string). Must be non-empty, and all traces must currently belong to the same source project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TraceIdentifiers { get; set; }

        /// <summary>
        /// The destination project: either project ID (GlobalID) or project name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_project_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationProjectIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTracesRequestBody" /> class.
        /// </summary>
        /// <param name="traceIdentifiers">
        /// The traces to transfer. Each identifier is either a trace ID (GlobalID) or an OpenTelemetry trace_id (hex string). Must be non-empty, and all traces must currently belong to the same source project.
        /// </param>
        /// <param name="destinationProjectIdentifier">
        /// The destination project: either project ID (GlobalID) or project name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferTracesRequestBody(
            global::System.Collections.Generic.IList<string> traceIdentifiers,
            string destinationProjectIdentifier)
        {
            this.TraceIdentifiers = traceIdentifiers ?? throw new global::System.ArgumentNullException(nameof(traceIdentifiers));
            this.DestinationProjectIdentifier = destinationProjectIdentifier ?? throw new global::System.ArgumentNullException(nameof(destinationProjectIdentifier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTracesRequestBody" /> class.
        /// </summary>
        public TransferTracesRequestBody()
        {
        }

    }
}