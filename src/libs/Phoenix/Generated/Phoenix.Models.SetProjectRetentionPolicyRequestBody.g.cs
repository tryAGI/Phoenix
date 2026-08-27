
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetProjectRetentionPolicyRequestBody
    {
        /// <summary>
        /// The ID (GlobalID) of an existing trace retention policy to assign, or null to reset the project to the default policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectRetentionPolicyRequestBody" /> class.
        /// </summary>
        /// <param name="policyId">
        /// The ID (GlobalID) of an existing trace retention policy to assign, or null to reset the project to the default policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetProjectRetentionPolicyRequestBody(
            string? policyId)
        {
            this.PolicyId = policyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectRetentionPolicyRequestBody" /> class.
        /// </summary>
        public SetProjectRetentionPolicyRequestBody()
        {
        }

    }
}