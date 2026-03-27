#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Phoenix;

/// <summary>
/// Extensions for using PhoenixClient operations as MEAI tools with any IChatClient.
/// </summary>
public static class PhoenixToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the latest version of a prompt
    /// from Phoenix's prompt registry by name or ID.
    /// Useful for agents that need to dynamically load prompt templates.
    /// </summary>
    /// <param name="client">The Phoenix client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetPromptTool(this PhoenixClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string promptName, CancellationToken cancellationToken) =>
            {
                var response = await client.Prompts.GetPromptVersionLatestAsync(
                    promptIdentifier: promptName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    id = response.Data.Id,
                    description = response.Data.Description,
                    model_provider = response.Data.ModelProvider.ToString(),
                    model_name = response.Data.ModelName,
                    template_type = response.Data.TemplateType.ToString(),
                    template_format = response.Data.TemplateFormat.ToString(),
                });
            },
            name: "GetPrompt",
            description: "Retrieves the latest version of a prompt template from Phoenix by name. Returns the prompt's model configuration, template type, and format.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all available prompts
    /// in the Phoenix prompt registry.
    /// </summary>
    /// <param name="client">The Phoenix client.</param>
    /// <param name="limit">Maximum number of prompts to return (default: 20).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListPromptsTool(
        this PhoenixClient client,
        int limit = 20)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Prompts.GetPromptsAsync(
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Data.Select(p => new
                {
                    name = p.Name,
                    description = p.Description,
                }));
            },
            name: "ListPrompts",
            description: "Lists all available prompt templates in Phoenix's prompt registry. Returns prompt names and descriptions.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that annotates a span with a score and label.
    /// Useful for agentic evaluation workflows where an AI agent scores trace spans.
    /// </summary>
    /// <param name="client">The Phoenix client.</param>
    /// <param name="annotationName">The name/type of annotation (e.g., "quality", "relevance").</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsAnnotateSpanTool(
        this PhoenixClient client,
        string annotationName = "ai-evaluation")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string spanId, double score, string label, string? explanation, CancellationToken cancellationToken) =>
            {
                var response = await client.Spans.AnnotateSpansAsync(
                    data:
                    [
                        new SpanAnnotationData
                        {
                            SpanId = spanId,
                            Name = annotationName,
                            AnnotatorKind = SpanAnnotationDataAnnotatorKind.Llm,
                            Result = new AnnotationResult
                            {
                                Label = label,
                                Score = score,
                                Explanation = explanation,
                            },
                        },
                    ],
                    sync: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Annotated span {spanId} with {annotationName}: score={score}, label={label}";
            },
            name: "AnnotateSpan",
            description: "Annotates a trace span in Phoenix with a score (0-1), label, and optional explanation. Used for evaluation and quality assessment of AI operations.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists recent traces for a project.
    /// Useful for agents that need to inspect their own or others' execution history.
    /// </summary>
    /// <param name="client">The Phoenix client.</param>
    /// <param name="limit">Maximum number of traces to return (default: 10).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListTracesTool(
        this PhoenixClient client,
        int limit = 10)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string projectName, CancellationToken cancellationToken) =>
            {
                var response = await client.Traces.ListProjectTracesAsync(
                    projectIdentifier: projectName,
                    limit: limit,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Data.Select(t => new
                {
                    trace_id = t.TraceId,
                    start_time = t.StartTime,
                    end_time = t.EndTime,
                }));
            },
            name: "ListTraces",
            description: "Lists recent traces for a Phoenix project. Returns trace IDs, timestamps, status, latency, and token usage. Useful for inspecting AI operation history.");
    }
}
