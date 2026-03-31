
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Provide a string to create or update the secret, or explicit null to delete it. This field is required; omitting it returns 422.
    /// </summary>
    public sealed partial class SecretKeyValueValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}