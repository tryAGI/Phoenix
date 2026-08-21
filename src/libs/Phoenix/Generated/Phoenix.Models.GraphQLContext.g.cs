
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Deprecated GraphQL mutations opt-in.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GraphQLContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"graphql"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string Type { get; set; } = "graphql";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mutationsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required bool MutationsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLContext" /> class.
        /// </summary>
        /// <param name="mutationsEnabled"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphQLContext(
            bool mutationsEnabled,
            string type = "graphql")
        {
            this.Type = type;
            this.MutationsEnabled = mutationsEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphQLContext" /> class.
        /// </summary>
        public GraphQLContext()
        {
        }

    }
}