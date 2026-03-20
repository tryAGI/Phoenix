
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionTemplateDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptVersionTemplateDiscriminatorTypeJsonConverter))]
        public global::Phoenix.PromptVersionTemplateDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionTemplateDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionTemplateDiscriminator(
            global::Phoenix.PromptVersionTemplateDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionTemplateDiscriminator" /> class.
        /// </summary>
        public PromptVersionTemplateDiscriminator()
        {
        }
    }
}