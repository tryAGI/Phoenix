
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundUIContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"playground"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "playground";

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordExperiments")]
        public bool? RecordExperiments { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextExperimentScaffold")]
        public global::Phoenix.PlaygroundExperimentScaffoldUIContext? NextExperimentScaffold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instances")]
        public global::System.Collections.Generic.IList<global::Phoenix.PlaygroundInstanceUIContext>? Instances { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::Phoenix.PlaygroundEvaluatorUIContext>? Evaluators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundUIContext" /> class.
        /// </summary>
        /// <param name="recordExperiments">
        /// Default Value: true
        /// </param>
        /// <param name="repetitions">
        /// Default Value: 1
        /// </param>
        /// <param name="nextExperimentScaffold"></param>
        /// <param name="instances"></param>
        /// <param name="evaluators"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundUIContext(
            bool? recordExperiments,
            int? repetitions,
            global::Phoenix.PlaygroundExperimentScaffoldUIContext? nextExperimentScaffold,
            global::System.Collections.Generic.IList<global::Phoenix.PlaygroundInstanceUIContext>? instances,
            global::System.Collections.Generic.IList<global::Phoenix.PlaygroundEvaluatorUIContext>? evaluators,
            string type = "playground")
        {
            this.Type = type;
            this.RecordExperiments = recordExperiments;
            this.Repetitions = repetitions;
            this.NextExperimentScaffold = nextExperimentScaffold;
            this.Instances = instances;
            this.Evaluators = evaluators;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundUIContext" /> class.
        /// </summary>
        public PlaygroundUIContext()
        {
        }

    }
}