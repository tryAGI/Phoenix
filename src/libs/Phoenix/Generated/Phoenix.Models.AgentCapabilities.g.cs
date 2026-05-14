
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Runtime capability state sent by the browser for a chat turn.
    /// </summary>
    public sealed partial class AgentCapabilities
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bash.retainInactiveSessions")]
        public bool? BashRetainInactiveSessions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graphql.mutations")]
        public bool? GraphqlMutations { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session.storeSessions")]
        public bool? SessionStoreSessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCapabilities" /> class.
        /// </summary>
        /// <param name="bashRetainInactiveSessions">
        /// Default Value: false
        /// </param>
        /// <param name="graphqlMutations">
        /// Default Value: false
        /// </param>
        /// <param name="sessionStoreSessions">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCapabilities(
            bool? bashRetainInactiveSessions,
            bool? graphqlMutations,
            bool? sessionStoreSessions)
        {
            this.BashRetainInactiveSessions = bashRetainInactiveSessions;
            this.GraphqlMutations = graphqlMutations;
            this.SessionStoreSessions = sessionStoreSessions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCapabilities" /> class.
        /// </summary>
        public AgentCapabilities()
        {
        }

    }
}