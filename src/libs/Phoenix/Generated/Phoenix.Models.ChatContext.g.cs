#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Phoenix
{
    /// <summary>
    /// Discriminated union of every UI-state context the agent understands.
    /// </summary>
    public readonly partial struct ChatContext : global::System.IEquatable<ChatContext>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ChatContextDiscriminatorType? Type { get; }

        /// <summary>
        /// Per-turn browser clock context for resolving relative time requests.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.AppContext? App { get; init; }
#else
        public global::Phoenix.AppContext? App { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(App))]
#endif
        public bool IsApp => App != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.AppContext? value)
        {
            value = App;
            return IsApp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.AppContext PickApp() => IsApp
            ? App!
            : throw new global::System.InvalidOperationException($"Expected union variant 'App' but the value was {ToString()}.");

        /// <summary>
        /// Project the user is currently viewing.<br/>
        /// ``span_filter`` carries the project-scoped span filter expression when the<br/>
        /// span filter field is mounted — empty string when the field is mounted with<br/>
        /// no condition applied, ``None`` when the field is not present at all.<br/>
        /// ``root_spans_only`` carries the current state of the spans-table root vs.<br/>
        /// all toggle when that toggle is mounted — ``True`` when the table is<br/>
        /// restricted to root spans, ``False`` when it shows every span, ``None``<br/>
        /// when the toggle is not present (e.g. on the traces tab).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.ProjectContext? Project { get; init; }
#else
        public global::Phoenix.ProjectContext? Project { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Project))]
#endif
        public bool IsProject => Project != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProject(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.ProjectContext? value)
        {
            value = Project;
            return IsProject;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.ProjectContext PickProject() => IsProject
            ? Project!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Project' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.TraceContext? Trace { get; init; }
#else
        public global::Phoenix.TraceContext? Trace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Trace))]
#endif
        public bool IsTrace => Trace != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTrace(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.TraceContext? value)
        {
            value = Trace;
            return IsTrace;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.TraceContext PickTrace() => IsTrace
            ? Trace!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Trace' but the value was {ToString()}.");

        /// <summary>
        /// Span the user has selected.<br/>
        /// Exactly one of ``span_node_id`` (relay) or ``otel_span_id`` (OpenTelemetry<br/>
        /// hex) must be set. ``project_node_id`` is optional because a span can be<br/>
        /// selected from views outside a project route.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.AgentSpanContext? Span { get; init; }
#else
        public global::Phoenix.AgentSpanContext? Span { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Span))]
#endif
        public bool IsSpan => Span != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSpan(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.AgentSpanContext? value)
        {
            value = Span;
            return IsSpan;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.AgentSpanContext PickSpan() => IsSpan
            ? Span!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Span' but the value was {ToString()}.");

        /// <summary>
        /// Playground prompt editor state mounted in the current browser route.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.PlaygroundContext? Playground { get; init; }
#else
        public global::Phoenix.PlaygroundContext? Playground { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Playground))]
#endif
        public bool IsPlayground => Playground != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlayground(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.PlaygroundContext? value)
        {
            value = Playground;
            return IsPlayground;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.PlaygroundContext PickPlayground() => IsPlayground
            ? Playground!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playground' but the value was {ToString()}.");

        /// <summary>
        /// GraphQL runtime state.<br/>
        /// Unlike the other contexts this one always emits a block — when no instance<br/>
        /// is present the policy defaults to ``disabled`` (the safe default). Callers<br/>
        /// in the absent case should use :meth:`render_disabled_default`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.GraphQLContext? Graphql { get; init; }
#else
        public global::Phoenix.GraphQLContext? Graphql { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Graphql))]
#endif
        public bool IsGraphql => Graphql != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGraphql(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.GraphQLContext? value)
        {
            value = Graphql;
            return IsGraphql;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.GraphQLContext PickGraphql() => IsGraphql
            ? Graphql!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Graphql' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.AppContext value) => new ChatContext((global::Phoenix.AppContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AppContext?(ChatContext @this) => @this.App;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.AppContext? value)
        {
            App = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromApp(global::Phoenix.AppContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.ProjectContext value) => new ChatContext((global::Phoenix.ProjectContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.ProjectContext?(ChatContext @this) => @this.Project;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.ProjectContext? value)
        {
            Project = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromProject(global::Phoenix.ProjectContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.TraceContext value) => new ChatContext((global::Phoenix.TraceContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.TraceContext?(ChatContext @this) => @this.Trace;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.TraceContext? value)
        {
            Trace = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromTrace(global::Phoenix.TraceContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.AgentSpanContext value) => new ChatContext((global::Phoenix.AgentSpanContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.AgentSpanContext?(ChatContext @this) => @this.Span;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.AgentSpanContext? value)
        {
            Span = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromSpan(global::Phoenix.AgentSpanContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.PlaygroundContext value) => new ChatContext((global::Phoenix.PlaygroundContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.PlaygroundContext?(ChatContext @this) => @this.Playground;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.PlaygroundContext? value)
        {
            Playground = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromPlayground(global::Phoenix.PlaygroundContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.GraphQLContext value) => new ChatContext((global::Phoenix.GraphQLContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.GraphQLContext?(ChatContext @this) => @this.Graphql;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.GraphQLContext? value)
        {
            Graphql = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromGraphql(global::Phoenix.GraphQLContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(
            global::Phoenix.ChatContextDiscriminatorType? type,
            global::Phoenix.AppContext? app,
            global::Phoenix.ProjectContext? project,
            global::Phoenix.TraceContext? trace,
            global::Phoenix.AgentSpanContext? span,
            global::Phoenix.PlaygroundContext? playground,
            global::Phoenix.GraphQLContext? graphql
            )
        {
            Type = type;

            App = app;
            Project = project;
            Trace = trace;
            Span = span;
            Playground = playground;
            Graphql = graphql;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Graphql as object ??
            Playground as object ??
            Span as object ??
            Trace as object ??
            Project as object ??
            App as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            App?.ToString() ??
            Project?.ToString() ??
            Trace?.ToString() ??
            Span?.ToString() ??
            Playground?.ToString() ??
            Graphql?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsGraphql || !IsApp && IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsGraphql || !IsApp && !IsProject && IsTrace && !IsSpan && !IsPlayground && !IsGraphql || !IsApp && !IsProject && !IsTrace && IsSpan && !IsPlayground && !IsGraphql || !IsApp && !IsProject && !IsTrace && !IsSpan && IsPlayground && !IsGraphql || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && IsGraphql;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Phoenix.AppContext, TResult>? app = null,
            global::System.Func<global::Phoenix.ProjectContext, TResult>? project = null,
            global::System.Func<global::Phoenix.TraceContext, TResult>? trace = null,
            global::System.Func<global::Phoenix.AgentSpanContext, TResult>? span = null,
            global::System.Func<global::Phoenix.PlaygroundContext, TResult>? playground = null,
            global::System.Func<global::Phoenix.GraphQLContext, TResult>? graphql = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp && app != null)
            {
                return app(App!);
            }
            else if (IsProject && project != null)
            {
                return project(Project!);
            }
            else if (IsTrace && trace != null)
            {
                return trace(Trace!);
            }
            else if (IsSpan && span != null)
            {
                return span(Span!);
            }
            else if (IsPlayground && playground != null)
            {
                return playground(Playground!);
            }
            else if (IsGraphql && graphql != null)
            {
                return graphql(Graphql!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Phoenix.AppContext>? app = null,

            global::System.Action<global::Phoenix.ProjectContext>? project = null,

            global::System.Action<global::Phoenix.TraceContext>? trace = null,

            global::System.Action<global::Phoenix.AgentSpanContext>? span = null,

            global::System.Action<global::Phoenix.PlaygroundContext>? playground = null,

            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp)
            {
                app?.Invoke(App!);
            }
            else if (IsProject)
            {
                project?.Invoke(Project!);
            }
            else if (IsTrace)
            {
                trace?.Invoke(Trace!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
            else if (IsPlayground)
            {
                playground?.Invoke(Playground!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Phoenix.AppContext>? app = null,
            global::System.Action<global::Phoenix.ProjectContext>? project = null,
            global::System.Action<global::Phoenix.TraceContext>? trace = null,
            global::System.Action<global::Phoenix.AgentSpanContext>? span = null,
            global::System.Action<global::Phoenix.PlaygroundContext>? playground = null,
            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp)
            {
                app?.Invoke(App!);
            }
            else if (IsProject)
            {
                project?.Invoke(Project!);
            }
            else if (IsTrace)
            {
                trace?.Invoke(Trace!);
            }
            else if (IsSpan)
            {
                span?.Invoke(Span!);
            }
            else if (IsPlayground)
            {
                playground?.Invoke(Playground!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                App,
                typeof(global::Phoenix.AppContext),
                Project,
                typeof(global::Phoenix.ProjectContext),
                Trace,
                typeof(global::Phoenix.TraceContext),
                Span,
                typeof(global::Phoenix.AgentSpanContext),
                Playground,
                typeof(global::Phoenix.PlaygroundContext),
                Graphql,
                typeof(global::Phoenix.GraphQLContext),
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
        public bool Equals(ChatContext other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AppContext?>.Default.Equals(App, other.App) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.ProjectContext?>.Default.Equals(Project, other.Project) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.TraceContext?>.Default.Equals(Trace, other.Trace) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.AgentSpanContext?>.Default.Equals(Span, other.Span) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.PlaygroundContext?>.Default.Equals(Playground, other.Playground) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.GraphQLContext?>.Default.Equals(Graphql, other.Graphql) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatContext obj1, ChatContext obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatContext>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatContext obj1, ChatContext obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatContext o && Equals(o);
        }
    }
}
