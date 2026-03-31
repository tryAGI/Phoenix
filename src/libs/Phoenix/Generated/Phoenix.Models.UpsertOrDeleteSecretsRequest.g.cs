
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Request body for the PUT /secrets endpoint.
    /// </summary>
    public sealed partial class UpsertOrDeleteSecretsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue> Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrDeleteSecretsRequest" /> class.
        /// </summary>
        /// <param name="secrets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertOrDeleteSecretsRequest(
            global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue> secrets)
        {
            this.Secrets = secrets ?? throw new global::System.ArgumentNullException(nameof(secrets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrDeleteSecretsRequest" /> class.
        /// </summary>
        public UpsertOrDeleteSecretsRequest()
        {
        }
    }
}