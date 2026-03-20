
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolsToolChoiceDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptToolsToolChoiceDiscriminatorTypeJsonConverter))]
        public global::Phoenix.PromptToolsToolChoiceDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolsToolChoiceDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptToolsToolChoiceDiscriminator(
            global::Phoenix.PromptToolsToolChoiceDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolsToolChoiceDiscriminator" /> class.
        /// </summary>
        public PromptToolsToolChoiceDiscriminator()
        {
        }
    }
}