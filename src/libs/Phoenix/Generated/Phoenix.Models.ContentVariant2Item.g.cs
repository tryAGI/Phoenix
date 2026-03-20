#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ContentVariant2Item : global::System.IEquatable<ContentVariant2Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.TextContentPart? Text { get; init; }
#else
        public global::Phoenix.TextContentPart? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ToolCallContentPart? ToolCall { get; init; }
#else
        public global::Phoenix.ToolCallContentPart? ToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolCall))]
#endif
        public bool IsToolCall => ToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ToolResultContentPart? ToolResult { get; init; }
#else
        public global::Phoenix.ToolResultContentPart? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Phoenix.TextContentPart value) => new ContentVariant2Item((global::Phoenix.TextContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.TextContentPart?(ContentVariant2Item @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::Phoenix.TextContentPart? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Phoenix.ToolCallContentPart value) => new ContentVariant2Item((global::Phoenix.ToolCallContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ToolCallContentPart?(ContentVariant2Item @this) => @this.ToolCall;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::Phoenix.ToolCallContentPart? value)
        {
            ToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContentVariant2Item(global::Phoenix.ToolResultContentPart value) => new ContentVariant2Item((global::Phoenix.ToolResultContentPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ToolResultContentPart?(ContentVariant2Item @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(global::Phoenix.ToolResultContentPart? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContentVariant2Item(
            global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType? type,
            global::Phoenix.TextContentPart? text,
            global::Phoenix.ToolCallContentPart? toolCall,
            global::Phoenix.ToolResultContentPart? toolResult
            )
        {
            Type = type;

            Text = text;
            ToolCall = toolCall;
            ToolResult = toolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolResult as object ??
            ToolCall as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolCall?.ToString() ??
            ToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolCall && !IsToolResult || !IsText && IsToolCall && !IsToolResult || !IsText && !IsToolCall && IsToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.TextContentPart?, TResult>? text = null,
            global::System.Func<global::Phoenix.ToolCallContentPart?, TResult>? toolCall = null,
            global::System.Func<global::Phoenix.ToolResultContentPart?, TResult>? toolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsToolCall && toolCall != null)
            {
                return toolCall(ToolCall!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.TextContentPart?>? text = null,
            global::System.Action<global::Phoenix.ToolCallContentPart?>? toolCall = null,
            global::System.Action<global::Phoenix.ToolResultContentPart?>? toolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsToolCall)
            {
                toolCall?.Invoke(ToolCall!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Phoenix.TextContentPart),
                ToolCall,
                typeof(global::Phoenix.ToolCallContentPart),
                ToolResult,
                typeof(global::Phoenix.ToolResultContentPart),
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
        public bool Equals(ContentVariant2Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.TextContentPart?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ToolCallContentPart?>.Default.Equals(ToolCall, other.ToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ToolResultContentPart?>.Default.Equals(ToolResult, other.ToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentVariant2Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContentVariant2Item obj1, ContentVariant2Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentVariant2Item o && Equals(o);
        }
    }
}
