
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetUIContext
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"dataset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "dataset";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetNodeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetVersionNodeId")]
        public string? DatasetVersionNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUIContext" /> class.
        /// </summary>
        /// <param name="datasetNodeId"></param>
        /// <param name="datasetVersionNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUIContext(
            string datasetNodeId,
            string? datasetVersionNodeId,
            string type = "dataset")
        {
            this.Type = type;
            this.DatasetNodeId = datasetNodeId ?? throw new global::System.ArgumentNullException(nameof(datasetNodeId));
            this.DatasetVersionNodeId = datasetVersionNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUIContext" /> class.
        /// </summary>
        public DatasetUIContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DatasetUIContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DatasetUIContext FromDatasetNodeId(string datasetNodeId)
        {
            return new DatasetUIContext
            {
                DatasetNodeId = datasetNodeId,
            };
        }

    }
}