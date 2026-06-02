
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Dataset the user is currently viewing or has bound to a workflow.<br/>
    /// Carries the dataset's relay node id and, when known, the active version<br/>
    /// node id. These IDs scope the create-form handoff link and the sampling of<br/>
    /// active dataset examples used as prompt context; the dataset schema itself<br/>
    /// is open.
    /// </summary>
    public sealed partial class DatasetContext
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
        /// Initializes a new instance of the <see cref="DatasetContext" /> class.
        /// </summary>
        /// <param name="datasetNodeId"></param>
        /// <param name="datasetVersionNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetContext(
            string datasetNodeId,
            string? datasetVersionNodeId,
            string type = "dataset")
        {
            this.Type = type;
            this.DatasetNodeId = datasetNodeId ?? throw new global::System.ArgumentNullException(nameof(datasetNodeId));
            this.DatasetVersionNodeId = datasetVersionNodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetContext" /> class.
        /// </summary>
        public DatasetContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DatasetContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DatasetContext FromDatasetNodeId(string datasetNodeId)
        {
            return new DatasetContext
            {
                DatasetNodeId = datasetNodeId,
            };
        }

    }
}