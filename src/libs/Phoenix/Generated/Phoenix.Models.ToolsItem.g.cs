#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptToolsToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptToolFunction? Function { get; init; }
#else
        public global::Phoenix.PromptToolFunction? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptToolRaw? Raw { get; init; }
#else
        public global::Phoenix.PromptToolRaw? Raw { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Raw))]
#endif
        public bool IsRaw => Raw != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::Phoenix.PromptToolFunction value) => new ToolsItem((global::Phoenix.PromptToolFunction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptToolFunction?(ToolsItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::Phoenix.PromptToolFunction? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::Phoenix.PromptToolRaw value) => new ToolsItem((global::Phoenix.PromptToolRaw?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptToolRaw?(ToolsItem @this) => @this.Raw;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::Phoenix.PromptToolRaw? value)
        {
            Raw = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::Phoenix.PromptToolsToolDiscriminatorType? type,
            global::Phoenix.PromptToolFunction? function,
            global::Phoenix.PromptToolRaw? raw
            )
        {
            Type = type;

            Function = function;
            Raw = raw;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Raw as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Raw?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsRaw || !IsFunction && IsRaw;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.PromptToolFunction?, TResult>? function = null,
            global::System.Func<global::Phoenix.PromptToolRaw?, TResult>? raw = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsRaw && raw != null)
            {
                return raw(Raw!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.PromptToolFunction?>? function = null,
            global::System.Action<global::Phoenix.PromptToolRaw?>? raw = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsRaw)
            {
                raw?.Invoke(Raw!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::Phoenix.PromptToolFunction),
                Raw,
                typeof(global::Phoenix.PromptToolRaw),
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
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptToolFunction?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptToolRaw?>.Default.Equals(Raw, other.Raw) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
        }
    }
}
