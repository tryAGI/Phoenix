
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Result payload listing which keys were upserted and which were deleted.
    /// </summary>
    public sealed partial class UpsertOrDeleteSecretsResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upserted_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UpsertedKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DeletedKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrDeleteSecretsResult" /> class.
        /// </summary>
        /// <param name="upsertedKeys"></param>
        /// <param name="deletedKeys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertOrDeleteSecretsResult(
            global::System.Collections.Generic.IList<string> upsertedKeys,
            global::System.Collections.Generic.IList<string> deletedKeys)
        {
            this.UpsertedKeys = upsertedKeys ?? throw new global::System.ArgumentNullException(nameof(upsertedKeys));
            this.DeletedKeys = deletedKeys ?? throw new global::System.ArgumentNullException(nameof(deletedKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertOrDeleteSecretsResult" /> class.
        /// </summary>
        public UpsertOrDeleteSecretsResult()
        {
        }
    }
}