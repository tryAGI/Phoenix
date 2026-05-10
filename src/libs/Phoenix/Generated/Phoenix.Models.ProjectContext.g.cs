
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Project the user is currently viewing.<br/>
    /// ``span_filter`` carries the project-scoped span filter expression when the<br/>
    /// span filter field is mounted — empty string when the field is mounted with<br/>
    /// no condition applied, ``None`` when the field is not present at all.<br/>
    /// ``root_spans_only`` carries the current state of the spans-table root vs.<br/>
    /// all toggle when that toggle is mounted — ``True`` when the table is<br/>
    /// restricted to root spans, ``False`` when it shows every span, ``None``<br/>
    /// when the toggle is not present (e.g. on the traces tab).
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rootSpansOnly")]
        public bool? RootSpansOnly { get; set; }

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
        /// <param name="rootSpansOnly"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectContext(
            string projectNodeId,
            string? spanFilter,
            bool? rootSpansOnly,
            string type = "project")
        {
            this.Type = type;
            this.ProjectNodeId = projectNodeId ?? throw new global::System.ArgumentNullException(nameof(projectNodeId));
            this.SpanFilter = spanFilter;
            this.RootSpansOnly = rootSpansOnly;
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