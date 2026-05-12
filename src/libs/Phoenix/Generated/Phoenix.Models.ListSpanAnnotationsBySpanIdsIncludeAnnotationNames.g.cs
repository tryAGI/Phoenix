
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Optional list of annotation names to include. If provided, only annotations with these names will be returned (allowlist). When omitted, the response includes every matching row regardless of name (no annotation names are excluded by default).
    /// </summary>
    public sealed partial class ListSpanAnnotationsBySpanIdsIncludeAnnotationNames
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}