
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Playground prompt editor state mounted in the current browser route.
    /// </summary>
    public sealed partial class PlaygroundContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"playground"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "playground";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InstanceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundContext" /> class.
        /// </summary>
        /// <param name="instanceIds"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundContext(
            global::System.Collections.Generic.IList<int> instanceIds,
            string type = "playground")
        {
            this.Type = type;
            this.InstanceIds = instanceIds ?? throw new global::System.ArgumentNullException(nameof(instanceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundContext" /> class.
        /// </summary>
        public PlaygroundContext()
        {
        }
    }
}