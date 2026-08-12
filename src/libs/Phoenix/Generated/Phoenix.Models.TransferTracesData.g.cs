
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferTracesData
    {
        /// <summary>
        /// The number of traces that were moved to the destination project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferred_trace_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TransferredTraceCount { get; set; }

        /// <summary>
        /// The ID (GlobalID) of the project the traces were moved to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTracesData" /> class.
        /// </summary>
        /// <param name="transferredTraceCount">
        /// The number of traces that were moved to the destination project.
        /// </param>
        /// <param name="destinationProjectId">
        /// The ID (GlobalID) of the project the traces were moved to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferTracesData(
            int transferredTraceCount,
            string destinationProjectId)
        {
            this.TransferredTraceCount = transferredTraceCount;
            this.DestinationProjectId = destinationProjectId ?? throw new global::System.ArgumentNullException(nameof(destinationProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferTracesData" /> class.
        /// </summary>
        public TransferTracesData()
        {
        }

    }
}