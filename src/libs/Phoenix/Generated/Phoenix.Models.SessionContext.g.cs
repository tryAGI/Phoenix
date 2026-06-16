
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Session the user is currently viewing.
    /// </summary>
    public sealed partial class SessionContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"session"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionNodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionContext" /> class.
        /// </summary>
        /// <param name="projectNodeId"></param>
        /// <param name="sessionNodeId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionContext(
            string projectNodeId,
            string sessionNodeId,
            string type = "session")
        {
            this.Type = type;
            this.ProjectNodeId = projectNodeId ?? throw new global::System.ArgumentNullException(nameof(projectNodeId));
            this.SessionNodeId = sessionNodeId ?? throw new global::System.ArgumentNullException(nameof(sessionNodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionContext" /> class.
        /// </summary>
        public SessionContext()
        {
        }

    }
}