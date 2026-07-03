
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetDatasetLabelsRequestBody
    {
        /// <summary>
        /// The complete set of dataset label GlobalIDs to apply to the dataset. Labels not in this list are removed from the dataset; an empty list removes all labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_label_ids")]
        public global::System.Collections.Generic.IList<string>? DatasetLabelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDatasetLabelsRequestBody" /> class.
        /// </summary>
        /// <param name="datasetLabelIds">
        /// The complete set of dataset label GlobalIDs to apply to the dataset. Labels not in this list are removed from the dataset; an empty list removes all labels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetDatasetLabelsRequestBody(
            global::System.Collections.Generic.IList<string>? datasetLabelIds)
        {
            this.DatasetLabelIds = datasetLabelIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetDatasetLabelsRequestBody" /> class.
        /// </summary>
        public SetDatasetLabelsRequestBody()
        {
        }

    }
}