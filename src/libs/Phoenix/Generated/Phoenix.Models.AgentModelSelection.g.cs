#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentModelSelection : global::System.IEquatable<AgentModelSelection>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.AgentModelSelectionDiscriminatorProviderType? ProviderType { get; }

        /// <summary>
        /// Chat against a stored custom provider record.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CustomProviderModelSelection? Custom { get; init; }
#else
        public global::Phoenix.CustomProviderModelSelection? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCustom(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.CustomProviderModelSelection? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.CustomProviderModelSelection PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");

        /// <summary>
        /// Chat against a Phoenix built-in provider.<br/>
        /// Credentials and connection details (base URL, Azure endpoint, AWS<br/>
        /// region) are resolved from the secret store first and the process<br/>
        /// environment second.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.BuiltInProviderModelSelection? Builtin { get; init; }
#else
        public global::Phoenix.BuiltInProviderModelSelection? Builtin { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Builtin))]
#endif
        public bool IsBuiltin => Builtin != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBuiltin(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.BuiltInProviderModelSelection? value)
        {
            value = Builtin;
            return IsBuiltin;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.BuiltInProviderModelSelection PickBuiltin() => IsBuiltin
            ? Builtin!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builtin' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentModelSelection(global::Phoenix.CustomProviderModelSelection value) => new AgentModelSelection((global::Phoenix.CustomProviderModelSelection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.CustomProviderModelSelection?(AgentModelSelection @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public AgentModelSelection(global::Phoenix.CustomProviderModelSelection? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentModelSelection FromCustom(global::Phoenix.CustomProviderModelSelection? value) => new AgentModelSelection(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentModelSelection(global::Phoenix.BuiltInProviderModelSelection value) => new AgentModelSelection((global::Phoenix.BuiltInProviderModelSelection?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.BuiltInProviderModelSelection?(AgentModelSelection @this) => @this.Builtin;

        /// <summary>
        /// 
        /// </summary>
        public AgentModelSelection(global::Phoenix.BuiltInProviderModelSelection? value)
        {
            Builtin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AgentModelSelection FromBuiltin(global::Phoenix.BuiltInProviderModelSelection? value) => new AgentModelSelection(value);

        /// <summary>
        /// 
        /// </summary>
        public AgentModelSelection(
            global::Phoenix.AgentModelSelectionDiscriminatorProviderType? providerType,
            global::Phoenix.CustomProviderModelSelection? custom,
            global::Phoenix.BuiltInProviderModelSelection? builtin
            )
        {
            ProviderType = providerType;

            Custom = custom;
            Builtin = builtin;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Builtin as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Custom?.ToString() ??
            Builtin?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsBuiltin || !IsCustom && IsBuiltin;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.CustomProviderModelSelection, TResult>? custom = null,
            global::System.Func<global::Phoenix.BuiltInProviderModelSelection, TResult>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsBuiltin && builtin != null)
            {
                return builtin(Builtin!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.CustomProviderModelSelection>? custom = null,

            global::System.Action<global::Phoenix.BuiltInProviderModelSelection>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.CustomProviderModelSelection>? custom = null,
            global::System.Action<global::Phoenix.BuiltInProviderModelSelection>? builtin = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::Phoenix.CustomProviderModelSelection),
                Builtin,
                typeof(global::Phoenix.BuiltInProviderModelSelection),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AgentModelSelection other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CustomProviderModelSelection?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.BuiltInProviderModelSelection?>.Default.Equals(Builtin, other.Builtin) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentModelSelection obj1, AgentModelSelection obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentModelSelection>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentModelSelection obj1, AgentModelSelection obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentModelSelection o && Equals(o);
        }
    }
}
