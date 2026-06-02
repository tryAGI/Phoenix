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
        public global::Phoenix.PlaygroundInstanceContextModelVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Built-in playground model selection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundBuiltinModelContext? Builtin { get; init; }
#else
        public global::Phoenix.PlaygroundBuiltinModelContext? Builtin { get; }
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
            out global::Phoenix.PlaygroundBuiltinModelContext? value)
        {
            value = Builtin;
            return IsBuiltin;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PlaygroundBuiltinModelContext PickBuiltin() => IsBuiltin
            ? Builtin!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Builtin' but the value was {ToString()}.");

        /// <summary>
        /// Custom-provider playground model selection.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundCustomProviderModelContext? Custom { get; init; }
#else
        public global::Phoenix.PlaygroundCustomProviderModelContext? Custom { get; }
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
            out global::Phoenix.PlaygroundCustomProviderModelContext? value)
        {
            value = Custom;
            return IsCustom;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PlaygroundCustomProviderModelContext PickCustom() => IsCustom
            ? Custom!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Custom' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelVariant1(global::Phoenix.PlaygroundBuiltinModelContext value) => new ModelVariant1((global::Phoenix.PlaygroundBuiltinModelContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundBuiltinModelContext?(ModelVariant1 @this) => @this.Builtin;

        /// <summary>
        /// 
        /// </summary>
        public ModelVariant1(global::Phoenix.PlaygroundBuiltinModelContext? value)
        {
            Builtin = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ModelVariant1 FromBuiltin(global::Phoenix.PlaygroundBuiltinModelContext? value) => new ModelVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ModelVariant1(global::Phoenix.PlaygroundCustomProviderModelContext value) => new ModelVariant1((global::Phoenix.PlaygroundCustomProviderModelContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundCustomProviderModelContext?(ModelVariant1 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ModelVariant1(global::Phoenix.PlaygroundCustomProviderModelContext? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ModelVariant1 FromCustom(global::Phoenix.PlaygroundCustomProviderModelContext? value) => new ModelVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public ModelVariant1(
            global::Phoenix.PlaygroundInstanceContextModelVariant1DiscriminatorType? type,
            global::Phoenix.PlaygroundBuiltinModelContext? builtin,
            global::Phoenix.PlaygroundCustomProviderModelContext? custom
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
            global::System.Func<global::Phoenix.PlaygroundBuiltinModelContext, TResult>? builtin = null,
            global::System.Func<global::Phoenix.PlaygroundCustomProviderModelContext, TResult>? custom = null,
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
            global::System.Action<global::Phoenix.PlaygroundBuiltinModelContext>? builtin = null,

            global::System.Action<global::Phoenix.PlaygroundCustomProviderModelContext>? custom = null,
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
            global::System.Action<global::Phoenix.PlaygroundBuiltinModelContext>? builtin = null,
            global::System.Action<global::Phoenix.PlaygroundCustomProviderModelContext>? custom = null,
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
                typeof(global::Phoenix.PlaygroundBuiltinModelContext),
                Custom,
                typeof(global::Phoenix.PlaygroundCustomProviderModelContext),
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
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundBuiltinModelContext?>.Default.Equals(Builtin, other.Builtin) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundCustomProviderModelContext?>.Default.Equals(Custom, other.Custom) 
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
