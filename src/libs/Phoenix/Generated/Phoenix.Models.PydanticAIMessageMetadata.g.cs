
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Local pin of pydantic-ai's message-level ``pydantic_ai`` metadata<br/>
    /// namespace (its private ``_PydanticAIMessageMetadata``), merged into the<br/>
    /// assistant metadata by the stream's metadata chunk.
    /// </summary>
    public sealed partial class PydanticAIMessageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PydanticAIMessageMetadata" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PydanticAIMessageMetadata(
            global::System.DateTime? timestamp)
        {
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PydanticAIMessageMetadata" /> class.
        /// </summary>
        public PydanticAIMessageMetadata()
        {
        }

    }
}