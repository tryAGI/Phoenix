
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Optional list of annotation identifiers to filter by. Each value must be non-empty. If omitted, `trace_ids` must be supplied. When combined with `trace_ids`, results are the AND-intersection of both filters.
    /// </summary>
    public sealed partial class ListTraceAnnotationsByTraceIdsIdentifier
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}