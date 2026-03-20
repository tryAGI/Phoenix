#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Template : global::System.IEquatable<Template>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptVersionTemplateDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptChatTemplate? Chat { get; init; }
#else
        public global::Phoenix.PromptChatTemplate? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PromptStringTemplate? String { get; init; }
#else
        public global::Phoenix.PromptStringTemplate? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Template(global::Phoenix.PromptChatTemplate value) => new Template((global::Phoenix.PromptChatTemplate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptChatTemplate?(Template @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public Template(global::Phoenix.PromptChatTemplate? value)
        {
            Chat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Template(global::Phoenix.PromptStringTemplate value) => new Template((global::Phoenix.PromptStringTemplate?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PromptStringTemplate?(Template @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public Template(global::Phoenix.PromptStringTemplate? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Template(
            global::Phoenix.PromptVersionTemplateDiscriminatorType? type,
            global::Phoenix.PromptChatTemplate? chat,
            global::Phoenix.PromptStringTemplate? @string
            )
        {
            Type = type;

            Chat = chat;
            String = @string;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            String as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            String?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat && !IsString || !IsChat && IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.PromptChatTemplate?, TResult>? chat = null,
            global::System.Func<global::Phoenix.PromptStringTemplate?, TResult>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsString && @string != null)
            {
                return @string(String!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.PromptChatTemplate?>? chat = null,
            global::System.Action<global::Phoenix.PromptStringTemplate?>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::Phoenix.PromptChatTemplate),
                String,
                typeof(global::Phoenix.PromptStringTemplate),
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
        public bool Equals(Template other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptChatTemplate?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PromptStringTemplate?>.Default.Equals(String, other.String) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Template obj1, Template obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Template>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Template obj1, Template obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Template o && Equals(o);
        }
    }
}
