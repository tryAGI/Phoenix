
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetProjectAnnotationConfigsRequestBody
    {
        /// <summary>
        /// The complete set of annotation configuration GlobalIDs that should be assigned to the project. Configs not in this list are unassigned; an empty list clears all assignments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_config_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AnnotationConfigIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectAnnotationConfigsRequestBody" /> class.
        /// </summary>
        /// <param name="annotationConfigIds">
        /// The complete set of annotation configuration GlobalIDs that should be assigned to the project. Configs not in this list are unassigned; an empty list clears all assignments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetProjectAnnotationConfigsRequestBody(
            global::System.Collections.Generic.IList<string> annotationConfigIds)
        {
            this.AnnotationConfigIds = annotationConfigIds ?? throw new global::System.ArgumentNullException(nameof(annotationConfigIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetProjectAnnotationConfigsRequestBody" /> class.
        /// </summary>
        public SetProjectAnnotationConfigsRequestBody()
        {
        }

    }
}