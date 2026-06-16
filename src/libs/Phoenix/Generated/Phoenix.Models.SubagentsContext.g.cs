
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// User's per-turn request to expose the subagent-spawning tool.
    /// </summary>
    public sealed partial class SubagentsContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"subagents"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "subagents";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentsContext" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubagentsContext(
            bool enabled,
            string type = "subagents")
        {
            this.Type = type;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubagentsContext" /> class.
        /// </summary>
        public SubagentsContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SubagentsContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SubagentsContext FromEnabled(bool enabled)
        {
            return new SubagentsContext
            {
                Enabled = enabled,
            };
        }

    }
}