
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// One mounted playground instance and its current model selection.<br/>
    /// ``experiment_id`` carries the relay node id of the experiment produced by<br/>
    /// this instance's last dataset-backed run, or ``None`` when the instance has<br/>
    /// not produced one. Ephemeral experiments are included: they remain queryable<br/>
    /// until the server sweeps them ~24h after their last update.
    /// </summary>
    public sealed partial class PlaygroundInstanceContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Phoenix.ModelVariant1? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentId")]
        public string? ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundInstanceContext" /> class.
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="model"></param>
        /// <param name="experimentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundInstanceContext(
            int instanceId,
            global::Phoenix.ModelVariant1? model,
            string? experimentId)
        {
            this.InstanceId = instanceId;
            this.Model = model;
            this.ExperimentId = experimentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundInstanceContext" /> class.
        /// </summary>
        public PlaygroundInstanceContext()
        {
        }

    }
}