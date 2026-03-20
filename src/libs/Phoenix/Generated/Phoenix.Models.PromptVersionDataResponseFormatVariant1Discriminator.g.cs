
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionDataResponseFormatVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Phoenix.JsonConverters.PromptVersionDataResponseFormatVariant1DiscriminatorTypeJsonConverter))]
        public global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionDataResponseFormatVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionDataResponseFormatVariant1Discriminator(
            global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionDataResponseFormatVariant1Discriminator" /> class.
        /// </summary>
        public PromptVersionDataResponseFormatVariant1Discriminator()
        {
        }
    }
}