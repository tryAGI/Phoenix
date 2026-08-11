
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// ``UIMessage.metadata`` as a registry of namespaces.
    /// </summary>
    public sealed partial class MessageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoenix")]
        public global::Phoenix.PhoenixVariant1? Phoenix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pydantic_ai")]
        public global::Phoenix.PydanticAIMessageMetadata? PydanticAi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMetadata" /> class.
        /// </summary>
        /// <param name="phoenix"></param>
        /// <param name="pydanticAi"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageMetadata(
            global::Phoenix.PhoenixVariant1? phoenix,
            global::Phoenix.PydanticAIMessageMetadata? pydanticAi)
        {
            this.Phoenix = phoenix;
            this.PydanticAi = pydanticAi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageMetadata" /> class.
        /// </summary>
        public MessageMetadata()
        {
        }

    }
}