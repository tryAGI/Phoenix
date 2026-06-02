
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// One mounted playground instance and its current model selection.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundInstanceContext" /> class.
        /// </summary>
        /// <param name="instanceId"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundInstanceContext(
            int instanceId,
            global::Phoenix.ModelVariant1? model)
        {
            this.InstanceId = instanceId;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundInstanceContext" /> class.
        /// </summary>
        public PlaygroundInstanceContext()
        {
        }

    }
}