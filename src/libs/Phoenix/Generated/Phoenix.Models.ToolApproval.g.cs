
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A user's response to a tool call awaiting approval.
    /// </summary>
    public sealed partial class ToolApproval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Whether the user approved the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApproval" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="approved">
        /// Whether the user approved the tool call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApproval(
            string toolCallId,
            bool approved)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Approved = approved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApproval" /> class.
        /// </summary>
        public ToolApproval()
        {
        }

    }
}