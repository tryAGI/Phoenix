
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Tool approval in responded state (user has approved or denied).
    /// </summary>
    public sealed partial class ToolApprovalResponded
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Approved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalResponded" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="approved"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApprovalResponded(
            string id,
            bool approved,
            string? reason)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Approved = approved;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalResponded" /> class.
        /// </summary>
        public ToolApprovalResponded()
        {
        }

    }
}