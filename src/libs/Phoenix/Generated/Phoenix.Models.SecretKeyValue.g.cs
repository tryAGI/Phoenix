
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// A single secret entry specifying a key and a required nullable value.
    /// </summary>
    public sealed partial class SecretKeyValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Provide a string to create or update the secret, or explicit null to delete it. This field is required; omitting it returns 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretKeyValue" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value">
        /// Provide a string to create or update the secret, or explicit null to delete it. This field is required; omitting it returns 422.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretKeyValue(
            string key,
            string? value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretKeyValue" /> class.
        /// </summary>
        public SecretKeyValue()
        {
        }
    }
}