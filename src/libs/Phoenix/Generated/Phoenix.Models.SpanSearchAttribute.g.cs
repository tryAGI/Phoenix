
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Filter spans by `key:value`. Key is a dot-path (e.g. `user.id`, `metadata.tier`). Value is JSON-parsed: `k:12345` is int, `k:true` is bool, otherwise string (`k:user-42`). To match a numeric- or boolean-looking STRING, JSON-quote it: `user.id:"12345"` (URL-encoded `%2212345%22`). Split is on the first `:` only, so values may contain colons (`session.id:sess:abc:123`, ISO timestamps). Repeat the param to AND filters. List-valued attributes (e.g. `tag.tags`) cannot be matched here. Returns 422 on malformed input (missing colon, empty key/value, or list/dict/null value).
    /// </summary>
    public sealed partial class SpanSearchAttribute
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}