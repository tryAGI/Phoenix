#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModelVariant1 : global::System.IEquatable<ModelVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundInstanceUIContextModelVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundBuiltinModelUIContext? Builtin { get; init; }
#else
        public global::Phoenix.PlaygroundBuiltinModelUIContext? Builtin { get; }
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
            out global::Phoenix.PlaygroundBuiltinModelUIContext? value)
        {
            value = Builtin;
            return IsBuiltin;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundBuiltinModelUIContext PickBuiltin() => IsBuiltin
            ? Builtin!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builtin' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundCustomProviderModelUIContext? Custom { get; init; }
#else
        public global::Phoenix.PlaygroundCustomProviderModelUIContext? Custom { get; }
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
            out global::Phoenix.PlaygroundCustomProviderModelUIContext? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundCustomProviderModelUIContext PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelVariant1(global::Phoenix.PlaygroundBuiltinModelUIContext value) => new ModelVariant1((global::Phoenix.PlaygroundBuiltinModelUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundBuiltinModelUIContext?(ModelVariant1 @this) => @this.Builtin;

        /// <summary>
        ///
        /// </summary>
        public ModelVariant1(global::Phoenix.PlaygroundBuiltinModelUIContext? value)
        {
            Builtin = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelVariant1 FromBuiltin(global::Phoenix.PlaygroundBuiltinModelUIContext? value) => new ModelVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelVariant1(global::Phoenix.PlaygroundCustomProviderModelUIContext value) => new ModelVariant1((global::Phoenix.PlaygroundCustomProviderModelUIContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundCustomProviderModelUIContext?(ModelVariant1 @this) => @this.Custom;

        /// <summary>
        ///
        /// </summary>
        public ModelVariant1(global::Phoenix.PlaygroundCustomProviderModelUIContext? value)
        {
            Custom = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelVariant1 FromCustom(global::Phoenix.PlaygroundCustomProviderModelUIContext? value) => new ModelVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public ModelVariant1(
            global::Phoenix.PlaygroundInstanceUIContextModelVariant1DiscriminatorType? type,
            global::Phoenix.PlaygroundBuiltinModelUIContext? builtin,
            global::Phoenix.PlaygroundCustomProviderModelUIContext? custom
            )
        {
            Type = type;

            Builtin = builtin;
            Custom = custom;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Custom as object ??
            Builtin as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Builtin?.ToString() ??
            Custom?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuiltin && !IsCustom || !IsBuiltin && IsCustom;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.PlaygroundBuiltinModelUIContext, TResult>? builtin = null,
            global::System.Func<global::Phoenix.PlaygroundCustomProviderModelUIContext, TResult>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltin && builtin != null)
            {
                return builtin(Builtin!);
            }
            else if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.PlaygroundBuiltinModelUIContext>? builtin = null,

            global::System.Action<global::Phoenix.PlaygroundCustomProviderModelUIContext>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.PlaygroundBuiltinModelUIContext>? builtin = null,
            global::System.Action<global::Phoenix.PlaygroundCustomProviderModelUIContext>? custom = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltin)
            {
                builtin?.Invoke(Builtin!);
            }
            else if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Builtin,
                typeof(global::Phoenix.PlaygroundBuiltinModelUIContext),
                Custom,
                typeof(global::Phoenix.PlaygroundCustomProviderModelUIContext),
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
        public bool Equals(ModelVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundBuiltinModelUIContext?>.Default.Equals(Builtin, other.Builtin) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundCustomProviderModelUIContext?>.Default.Equals(Custom, other.Custom)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelVariant1 obj1, ModelVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelVariant1 obj1, ModelVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelVariant1 o && Equals(o);
        }
    }
}
