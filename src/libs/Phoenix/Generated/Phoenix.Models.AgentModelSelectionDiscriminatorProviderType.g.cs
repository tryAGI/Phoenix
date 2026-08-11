
#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentModelSelectionDiscriminatorProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Builtin,
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentModelSelectionDiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentModelSelectionDiscriminatorProviderType value)
        {
            return value switch
            {
                AgentModelSelectionDiscriminatorProviderType.Builtin => "builtin",
                AgentModelSelectionDiscriminatorProviderType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentModelSelectionDiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => AgentModelSelectionDiscriminatorProviderType.Builtin,
                "custom" => AgentModelSelectionDiscriminatorProviderType.Custom,
                _ => null,
            };
        }
    }
}