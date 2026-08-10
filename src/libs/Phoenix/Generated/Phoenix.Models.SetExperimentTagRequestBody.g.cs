
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetExperimentTagRequestBody
    {
        /// <summary>
        /// The name of the tag to assign, e.g. 'baseline'. If another experiment on the same dataset already owns this tag, the tag is moved to this experiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description of the tag (replaces any existing description)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetExperimentTagRequestBody" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tag to assign, e.g. 'baseline'. If another experiment on the same dataset already owns this tag, the tag is moved to this experiment.
        /// </param>
        /// <param name="description">
        /// An optional description of the tag (replaces any existing description)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetExperimentTagRequestBody(
            string name,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetExperimentTagRequestBody" /> class.
        /// </summary>
        public SetExperimentTagRequestBody()
        {
        }

    }
}