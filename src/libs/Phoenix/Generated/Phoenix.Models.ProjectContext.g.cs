
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Project the user is currently viewing.<br/>
    /// ``span_filter`` carries the project-scoped span filter expression when the<br/>
    /// span filter field is mounted — empty string when the field is mounted with<br/>
    /// no condition applied, ``None`` when the field is not present at all. It<br/>
    /// describes the view in full, root-span scoping included (which is expressed<br/>
    /// within the filter DSL as ``parent_id is None``).
    /// </summary>
    public sealed partial class ProjectContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"project"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "project";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectNodeId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanFilter")]
        public string? SpanFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectContext" /> class.
        /// </summary>
        /// <param name="projectNodeId"></param>
        /// <param name="spanFilter"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectContext(
            string projectNodeId,
            string? spanFilter,
            string type = "project")
        {
            this.Type = type;
            this.ProjectNodeId = projectNodeId ?? throw new global::System.ArgumentNullException(nameof(projectNodeId));
            this.SpanFilter = spanFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectContext" /> class.
        /// </summary>
        public ProjectContext()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectContext FromProjectNodeId(string projectNodeId)
        {
            return new ProjectContext
            {
                ProjectNodeId = projectNodeId,
            };
        }

    }
}