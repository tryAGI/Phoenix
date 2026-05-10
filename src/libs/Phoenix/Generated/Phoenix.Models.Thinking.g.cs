#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Thinking : global::System.IEquatable<Thinking>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAnthropicThinkingConfigDisabled? Disabled { get; init; }
#else
        public global::Phoenix.PromptAnthropicThinkingConfigDisabled? Disabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDisabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PromptAnthropicThinkingConfigDisabled? value)
        {
            value = Disabled;
            return IsDisabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigDisabled PickDisabled() => IsDisabled
            ? Disabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Disabled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAnthropicThinkingConfigEnabled? Enabled { get; init; }
#else
        public global::Phoenix.PromptAnthropicThinkingConfigEnabled? Enabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enabled))]
#endif
        public bool IsEnabled => Enabled != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnabled(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PromptAnthropicThinkingConfigEnabled? value)
        {
            value = Enabled;
            return IsEnabled;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigEnabled PickEnabled() => IsEnabled
            ? Enabled!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enabled' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptive? Adaptive { get; init; }
#else
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptive? Adaptive { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Adaptive))]
#endif
        public bool IsAdaptive => Adaptive != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdaptive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PromptAnthropicThinkingConfigAdaptive? value)
        {
            value = Adaptive;
            return IsAdaptive;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptive PickAdaptive() => IsAdaptive
            ? Adaptive!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Adaptive' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Thinking(global::Phoenix.PromptAnthropicThinkingConfigDisabled value) => new Thinking((global::Phoenix.PromptAnthropicThinkingConfigDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAnthropicThinkingConfigDisabled?(Thinking @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public Thinking(global::Phoenix.PromptAnthropicThinkingConfigDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Thinking FromDisabled(global::Phoenix.PromptAnthropicThinkingConfigDisabled? value) => new Thinking(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Thinking(global::Phoenix.PromptAnthropicThinkingConfigEnabled value) => new Thinking((global::Phoenix.PromptAnthropicThinkingConfigEnabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAnthropicThinkingConfigEnabled?(Thinking @this) => @this.Enabled;

        /// <summary>
        /// 
        /// </summary>
        public Thinking(global::Phoenix.PromptAnthropicThinkingConfigEnabled? value)
        {
            Enabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Thinking FromEnabled(global::Phoenix.PromptAnthropicThinkingConfigEnabled? value) => new Thinking(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Thinking(global::Phoenix.PromptAnthropicThinkingConfigAdaptive value) => new Thinking((global::Phoenix.PromptAnthropicThinkingConfigAdaptive?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptAnthropicThinkingConfigAdaptive?(Thinking @this) => @this.Adaptive;

        /// <summary>
        /// 
        /// </summary>
        public Thinking(global::Phoenix.PromptAnthropicThinkingConfigAdaptive? value)
        {
            Adaptive = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Thinking FromAdaptive(global::Phoenix.PromptAnthropicThinkingConfigAdaptive? value) => new Thinking(value);

        /// <summary>
        /// 
        /// </summary>
        public Thinking(
            global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? type,
            global::Phoenix.PromptAnthropicThinkingConfigDisabled? disabled,
            global::Phoenix.PromptAnthropicThinkingConfigEnabled? enabled,
            global::Phoenix.PromptAnthropicThinkingConfigAdaptive? adaptive
            )
        {
            Type = type;

            Disabled = disabled;
            Enabled = enabled;
            Adaptive = adaptive;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Adaptive as object ??
            Enabled as object ??
            Disabled as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Disabled?.ToString() ??
            Enabled?.ToString() ??
            Adaptive?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDisabled && !IsEnabled && !IsAdaptive || !IsDisabled && IsEnabled && !IsAdaptive || !IsDisabled && !IsEnabled && IsAdaptive;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.PromptAnthropicThinkingConfigDisabled, TResult>? disabled = null,
            global::System.Func<global::Phoenix.PromptAnthropicThinkingConfigEnabled, TResult>? enabled = null,
            global::System.Func<global::Phoenix.PromptAnthropicThinkingConfigAdaptive, TResult>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsEnabled && enabled != null)
            {
                return enabled(Enabled!);
            }
            else if (IsAdaptive && adaptive != null)
            {
                return adaptive(Adaptive!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigDisabled>? disabled = null,

            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigEnabled>? enabled = null,

            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigAdaptive>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsAdaptive)
            {
                adaptive?.Invoke(Adaptive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigDisabled>? disabled = null,
            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigEnabled>? enabled = null,
            global::System.Action<global::Phoenix.PromptAnthropicThinkingConfigAdaptive>? adaptive = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsEnabled)
            {
                enabled?.Invoke(Enabled!);
            }
            else if (IsAdaptive)
            {
                adaptive?.Invoke(Adaptive!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Disabled,
                typeof(global::Phoenix.PromptAnthropicThinkingConfigDisabled),
                Enabled,
                typeof(global::Phoenix.PromptAnthropicThinkingConfigEnabled),
                Adaptive,
                typeof(global::Phoenix.PromptAnthropicThinkingConfigAdaptive),
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
        public bool Equals(Thinking other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAnthropicThinkingConfigDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAnthropicThinkingConfigEnabled?>.Default.Equals(Enabled, other.Enabled) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptAnthropicThinkingConfigAdaptive?>.Default.Equals(Adaptive, other.Adaptive) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Thinking obj1, Thinking obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Thinking>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Thinking obj1, Thinking obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Thinking o && Equals(o);
        }
    }
}
