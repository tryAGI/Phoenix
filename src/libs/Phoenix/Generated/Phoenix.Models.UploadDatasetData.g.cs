
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_created_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumCreatedExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_updated_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumUpdatedExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_deleted_examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDeletedExamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetData" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="versionId"></param>
        /// <param name="numCreatedExamples"></param>
        /// <param name="numUpdatedExamples"></param>
        /// <param name="numDeletedExamples"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetData(
            string datasetId,
            string versionId,
            int numCreatedExamples,
            int numUpdatedExamples,
            int numDeletedExamples)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.NumCreatedExamples = numCreatedExamples;
            this.NumUpdatedExamples = numUpdatedExamples;
            this.NumDeletedExamples = numDeletedExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetData" /> class.
        /// </summary>
        public UploadDatasetData()
        {
        }
    }
}