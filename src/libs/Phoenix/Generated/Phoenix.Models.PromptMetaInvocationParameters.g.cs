
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptMetaInvocationParameters
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"meta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "meta";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PromptMetaInvocationParametersContent Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMetaInvocationParameters" /> class.
        /// </summary>
        /// <param name="meta"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptMetaInvocationParameters(
            global::Phoenix.PromptMetaInvocationParametersContent meta,
            string type = "meta")
        {
            this.Type = type;
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptMetaInvocationParameters" /> class.
        /// </summary>
        public PromptMetaInvocationParameters()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PromptMetaInvocationParameters"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PromptMetaInvocationParameters FromMeta(global::Phoenix.PromptMetaInvocationParametersContent meta)
        {
            return new PromptMetaInvocationParameters
            {
                Meta = meta,
            };
        }

    }
}