
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlaygroundEvaluatorUIContext
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetEvaluatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetEvaluatorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PlaygroundEvaluatorUIContextKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PlaygroundEvaluatorUIContextKind Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBuiltin")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBuiltin { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isApplied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundEvaluatorUIContext" /> class.
        /// </summary>
        /// <param name="datasetEvaluatorId"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="isBuiltin"></param>
        /// <param name="isApplied"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundEvaluatorUIContext(
            string datasetEvaluatorId,
            string name,
            global::Phoenix.PlaygroundEvaluatorUIContextKind kind,
            bool isBuiltin,
            bool isApplied)
        {
            this.DatasetEvaluatorId = datasetEvaluatorId ?? throw new global::System.ArgumentNullException(nameof(datasetEvaluatorId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.IsBuiltin = isBuiltin;
            this.IsApplied = isApplied;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundEvaluatorUIContext" /> class.
        /// </summary>
        public PlaygroundEvaluatorUIContext()
        {
        }

    }
}