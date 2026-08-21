
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// The trailing assistant message with the submitted approvals applied.
    /// </summary>
    public sealed partial class SubmitAgentSessionToolApprovalsResponseBody
    {
        /// <summary>
        /// ``UIMessage`` with metadata narrowed to the Phoenix wire shapes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Phoenix.PhoenixUIMessage Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolApprovalsResponseBody" /> class.
        /// </summary>
        /// <param name="data">
        /// ``UIMessage`` with metadata narrowed to the Phoenix wire shapes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitAgentSessionToolApprovalsResponseBody(
            global::Phoenix.PhoenixUIMessage data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitAgentSessionToolApprovalsResponseBody" /> class.
        /// </summary>
        public SubmitAgentSessionToolApprovalsResponseBody()
        {
        }

    }
}