
#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectRetentionPolicyData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The retention policy the project now uses, or null when the project falls back to the default policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_id")]
        public string? PolicyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRetentionPolicyData" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="policyId">
        /// The retention policy the project now uses, or null when the project falls back to the default policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectRetentionPolicyData(
            string projectId,
            string? policyId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.PolicyId = policyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectRetentionPolicyData" /> class.
        /// </summary>
        public ProjectRetentionPolicyData()
        {
        }

    }
}