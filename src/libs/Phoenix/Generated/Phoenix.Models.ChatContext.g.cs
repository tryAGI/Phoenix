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
        /// Code-evaluator create/edit form mounted in the current browser route.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.CodeEvaluatorContext? CodeEvaluator { get; init; }
#else
        public global::Phoenix.CodeEvaluatorContext? CodeEvaluator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeEvaluator))]
#endif
        public bool IsCodeEvaluator => CodeEvaluator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.CodeEvaluatorContext? value)
        {
            value = CodeEvaluator;
            return IsCodeEvaluator;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.CodeEvaluatorContext PickCodeEvaluator() => IsCodeEvaluator
            ? CodeEvaluator!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeEvaluator' but the value was {ToString()}.");

        /// <summary>
        /// LLM-evaluator create/edit form mounted in the current browser route.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.LlmEvaluatorContext? LlmEvaluator { get; init; }
#else
        public global::Phoenix.LlmEvaluatorContext? LlmEvaluator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LlmEvaluator))]
#endif
        public bool IsLlmEvaluator => LlmEvaluator != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLlmEvaluator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.LlmEvaluatorContext? value)
        {
            value = LlmEvaluator;
            return IsLlmEvaluator;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.LlmEvaluatorContext PickLlmEvaluator() => IsLlmEvaluator
            ? LlmEvaluator!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LlmEvaluator' but the value was {ToString()}.");

        /// <summary>
        /// Dataset the user is currently viewing or has bound to a workflow.<br/>
        /// Carries the dataset's relay node id and, when known, the active version<br/>
        /// node id. These IDs scope the create-form handoff link and the sampling of<br/>
        /// active dataset examples used as prompt context; the dataset schema itself<br/>
        /// is open.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.DatasetContext? Dataset { get; init; }
#else
        public global::Phoenix.DatasetContext? Dataset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dataset))]
#endif
        public bool IsDataset => Dataset != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDataset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.DatasetContext? value)
        {
            value = Dataset;
            return IsDataset;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.DatasetContext PickDataset() => IsDataset
            ? Dataset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dataset' but the value was {ToString()}.");

        /// <summary>
        /// GraphQL runtime state.
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
        /// User's per-turn request to expose web search / fetch tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Phoenix.WebAccessContext? WebAccess { get; init; }
#else
        public global::Phoenix.WebAccessContext? WebAccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebAccess))]
#endif
        public bool IsWebAccess => WebAccess != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebAccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Phoenix.WebAccessContext? value)
        {
            value = WebAccess;
            return IsWebAccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Phoenix.WebAccessContext PickWebAccess() => IsWebAccess
            ? WebAccess!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebAccess' but the value was {ToString()}.");
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
        public static implicit operator ChatContext(global::Phoenix.CodeEvaluatorContext value) => new ChatContext((global::Phoenix.CodeEvaluatorContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.CodeEvaluatorContext?(ChatContext @this) => @this.CodeEvaluator;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.CodeEvaluatorContext? value)
        {
            CodeEvaluator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromCodeEvaluator(global::Phoenix.CodeEvaluatorContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.LlmEvaluatorContext value) => new ChatContext((global::Phoenix.LlmEvaluatorContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.LlmEvaluatorContext?(ChatContext @this) => @this.LlmEvaluator;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.LlmEvaluatorContext? value)
        {
            LlmEvaluator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromLlmEvaluator(global::Phoenix.LlmEvaluatorContext? value) => new ChatContext(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatContext(global::Phoenix.DatasetContext value) => new ChatContext((global::Phoenix.DatasetContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.DatasetContext?(ChatContext @this) => @this.Dataset;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.DatasetContext? value)
        {
            Dataset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromDataset(global::Phoenix.DatasetContext? value) => new ChatContext(value);

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
        public static implicit operator ChatContext(global::Phoenix.WebAccessContext value) => new ChatContext((global::Phoenix.WebAccessContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Phoenix.WebAccessContext?(ChatContext @this) => @this.WebAccess;

        /// <summary>
        /// 
        /// </summary>
        public ChatContext(global::Phoenix.WebAccessContext? value)
        {
            WebAccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ChatContext FromWebAccess(global::Phoenix.WebAccessContext? value) => new ChatContext(value);

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
            global::Phoenix.CodeEvaluatorContext? codeEvaluator,
            global::Phoenix.LlmEvaluatorContext? llmEvaluator,
            global::Phoenix.DatasetContext? dataset,
            global::Phoenix.GraphQLContext? graphql,
            global::Phoenix.WebAccessContext? webAccess
            )
        {
            Type = type;

            App = app;
            Project = project;
            Trace = trace;
            Span = span;
            Playground = playground;
            CodeEvaluator = codeEvaluator;
            LlmEvaluator = llmEvaluator;
            Dataset = dataset;
            Graphql = graphql;
            WebAccess = webAccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebAccess as object ??
            Graphql as object ??
            Dataset as object ??
            LlmEvaluator as object ??
            CodeEvaluator as object ??
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
            CodeEvaluator?.ToString() ??
            LlmEvaluator?.ToString() ??
            Dataset?.ToString() ??
            Graphql?.ToString() ??
            WebAccess?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && IsLlmEvaluator && !IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && IsDataset && !IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && IsGraphql && !IsWebAccess || !IsApp && !IsProject && !IsTrace && !IsSpan && !IsPlayground && !IsCodeEvaluator && !IsLlmEvaluator && !IsDataset && !IsGraphql && IsWebAccess;
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
            global::System.Func<global::Phoenix.CodeEvaluatorContext, TResult>? codeEvaluator = null,
            global::System.Func<global::Phoenix.LlmEvaluatorContext, TResult>? llmEvaluator = null,
            global::System.Func<global::Phoenix.DatasetContext, TResult>? dataset = null,
            global::System.Func<global::Phoenix.GraphQLContext, TResult>? graphql = null,
            global::System.Func<global::Phoenix.WebAccessContext, TResult>? webAccess = null,
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
            else if (IsCodeEvaluator && codeEvaluator != null)
            {
                return codeEvaluator(CodeEvaluator!);
            }
            else if (IsLlmEvaluator && llmEvaluator != null)
            {
                return llmEvaluator(LlmEvaluator!);
            }
            else if (IsDataset && dataset != null)
            {
                return dataset(Dataset!);
            }
            else if (IsGraphql && graphql != null)
            {
                return graphql(Graphql!);
            }
            else if (IsWebAccess && webAccess != null)
            {
                return webAccess(WebAccess!);
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

            global::System.Action<global::Phoenix.CodeEvaluatorContext>? codeEvaluator = null,

            global::System.Action<global::Phoenix.LlmEvaluatorContext>? llmEvaluator = null,

            global::System.Action<global::Phoenix.DatasetContext>? dataset = null,

            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,

            global::System.Action<global::Phoenix.WebAccessContext>? webAccess = null,
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
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
            else if (IsLlmEvaluator)
            {
                llmEvaluator?.Invoke(LlmEvaluator!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
            else if (IsWebAccess)
            {
                webAccess?.Invoke(WebAccess!);
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
            global::System.Action<global::Phoenix.CodeEvaluatorContext>? codeEvaluator = null,
            global::System.Action<global::Phoenix.LlmEvaluatorContext>? llmEvaluator = null,
            global::System.Action<global::Phoenix.DatasetContext>? dataset = null,
            global::System.Action<global::Phoenix.GraphQLContext>? graphql = null,
            global::System.Action<global::Phoenix.WebAccessContext>? webAccess = null,
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
            else if (IsCodeEvaluator)
            {
                codeEvaluator?.Invoke(CodeEvaluator!);
            }
            else if (IsLlmEvaluator)
            {
                llmEvaluator?.Invoke(LlmEvaluator!);
            }
            else if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsGraphql)
            {
                graphql?.Invoke(Graphql!);
            }
            else if (IsWebAccess)
            {
                webAccess?.Invoke(WebAccess!);
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
                CodeEvaluator,
                typeof(global::Phoenix.CodeEvaluatorContext),
                LlmEvaluator,
                typeof(global::Phoenix.LlmEvaluatorContext),
                Dataset,
                typeof(global::Phoenix.DatasetContext),
                Graphql,
                typeof(global::Phoenix.GraphQLContext),
                WebAccess,
                typeof(global::Phoenix.WebAccessContext),
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
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.CodeEvaluatorContext?>.Default.Equals(CodeEvaluator, other.CodeEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.LlmEvaluatorContext?>.Default.Equals(LlmEvaluator, other.LlmEvaluator) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.DatasetContext?>.Default.Equals(Dataset, other.Dataset) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.GraphQLContext?>.Default.Equals(Graphql, other.Graphql) &&
                global::System.Collections.Generic.EqualityComparer<global::Phoenix.WebAccessContext?>.Default.Equals(WebAccess, other.WebAccess) 
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
