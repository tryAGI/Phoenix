
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// GraphQL runtime state.<br/>
    /// Unlike the other contexts this one always emits a block — when no instance<br/>
    /// is present the policy defaults to ``disabled`` (the safe default). Callers<br/>
    /// in the absent case should use :meth:`render_disabled_default`.
    /// </summary>
    public sealed partial class GraphQLContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"graphql"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "graphql";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mutationsEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
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

        /// <summary>
        /// Creates a new <see cref="GraphQLContext"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static GraphQLContext FromMutationsEnabled(bool mutationsEnabled)
        {
            return new GraphQLContext
            {
                MutationsEnabled = mutationsEnabled,
            };
        }

    }
}