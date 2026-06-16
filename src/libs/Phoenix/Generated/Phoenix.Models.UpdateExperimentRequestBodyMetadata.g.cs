
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// New metadata object for the experiment (replaces the existing metadata as a whole; null is rejected)
    /// </summary>
    public sealed partial class UpdateExperimentRequestBodyMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}