
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Experiment name/description/metadata the user has staged for the playground's<br/>
    /// *next* dataset-backed run, before that run has started.<br/>
    /// The playground UI lets the user pre-set how the next recorded run's experiment<br/>
    /// will be named, described, and tagged (via the ``set_playground_experiment_recording``<br/>
    /// tool or the recording form). That staged state is surfaced here so the agent can<br/>
    /// see what is already set and avoid re-staging it.<br/>
    /// Field semantics:<br/>
    /// - ``name`` / ``description``: the staged values, surfaced to the model verbatim,<br/>
    ///   or ``None`` when the user has not staged them.<br/>
    /// - ``has_metadata``: a presence flag, not the value. Only *whether* metadata has<br/>
    ///   been staged is model-relevant (so the agent knows not to re-attach it); the<br/>
    ///   metadata object itself is deliberately kept out of the prompt.<br/>
    /// A field left unstaged (``None`` / ``False``) falls back to the server default when<br/>
    /// the run starts. The scaffold is consumed once that next run begins.
    /// </summary>
    public sealed partial class PlaygroundExperimentScaffoldContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMetadata")]
        public bool? HasMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundExperimentScaffoldContext" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="hasMetadata">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundExperimentScaffoldContext(
            string? name,
            string? description,
            bool? hasMetadata)
        {
            this.Name = name;
            this.Description = description;
            this.HasMetadata = hasMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundExperimentScaffoldContext" /> class.
        /// </summary>
        public PlaygroundExperimentScaffoldContext()
        {
        }

    }
}