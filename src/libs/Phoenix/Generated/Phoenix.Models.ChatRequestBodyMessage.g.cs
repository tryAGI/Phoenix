
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The turn's new user message to append. May be omitted for client-tool continuation, where ``toolOutputs`` resolve the trailing assistant message's pending tool calls instead.
    /// </summary>
    public sealed partial class ChatRequestBodyMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}