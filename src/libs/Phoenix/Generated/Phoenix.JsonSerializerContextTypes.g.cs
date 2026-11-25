
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Phoenix
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AddDatasetLabelToDatasetResponseBody? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetLabel? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentModelSelection? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CustomProviderModelSelection? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.BuiltInProviderModelSelection? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentModelSelectionDiscriminator? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentModelSelectionDiscriminatorProviderType? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentSessionConflictError? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentSessionConflictErrorCode? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentSessionData? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentSessionSummary? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSessionsRequestBody? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SessionAnnotationData>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotationData? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSessionsResponseBody? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.InsertedSessionAnnotation>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InsertedSessionAnnotation? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSpanDocumentsRequestBody? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SpanDocumentAnnotationData>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanDocumentAnnotationData? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSpanDocumentsResponseBody? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanDocumentAnnotation>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InsertedSpanDocumentAnnotation? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSpansRequestBody? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotationData>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotationData? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateSpansResponseBody? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.InsertedSpanAnnotation>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InsertedSpanAnnotation? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateTracesRequestBody? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.TraceAnnotationData>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotationData? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotateTracesResponseBody? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.InsertedTraceAnnotation>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InsertedTraceAnnotation? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnnotationResult? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnonymousUser? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ApiKey? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ApiKeyData? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ApiKeyUser? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AppContext? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssignAnnotationConfigToProjectResponseBody? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data7? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CategoricalAnnotationConfig? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ContinuousAnnotationConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.FreeformAnnotationConfig? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminator? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssignAnnotationConfigToProjectResponseBodyDataDiscriminatorType? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssistantMessageMetadataUsage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssistantMessageMetadataUsageTokens? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AssistantMessageMetadataUsageCacheTokenDetails? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.BuiltInModelProvider? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ModelProvider? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OptimizationDirection? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.CategoricalAnnotationValue>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CategoricalAnnotationValue? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CategoricalAnnotationConfigData? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletion? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionChoice>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionChoice? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionUsage? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionMessage? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionErrorDetail? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionErrorResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionRequestMessage? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionRequestMessageRole? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionTextPart>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionTextPart? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionStreamOptions? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatCompletionUsagePromptTokensDetails? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatContext? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ProjectUIContext? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceUIContext? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionUIContext? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptUIContext? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionUIContext? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanUIContext? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundUIContext? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CodeEvaluatorUIContext? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LlmEvaluatorUIContext? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetUIContext? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GraphQLContext? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.WebAccessContext? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubagentsContext? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatContextDiscriminator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatContextDiscriminatorType? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatRequestBody? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ChatContext>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatRequestBodyEditPermission? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixUIMessage? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputAvailablePart? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolOutputErrorPart? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputAvailablePart? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolOutputErrorPart? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ToolApproval>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolApproval? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ChatRequestCredential>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ChatRequestCredential? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CompactAgentSessionRequestBody? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CompactAgentSessionResponseBody? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ContinuousAnnotationConfigData? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAgentSessionRequestBody? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAgentSessionResponseBody? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatedAgentSession? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigData? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.FreeformAnnotationConfigData? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigDataDiscriminator? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigDataDiscriminatorType? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigResponseBody? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data4? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminator? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateAnnotationConfigResponseBodyDataDiscriminatorType? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateApiKeyRequestBody? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateApiKeyResponseBody? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatedApiKey? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateChatCompletionRequestBody? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ChatCompletionRequestMessage>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateDatasetLabelRequestBody? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateDatasetLabelResponseBody? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateDatasetSplitRequestBody? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateDatasetSplitResponseBody? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetSplit? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateExperimentRequestBody? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateExperimentResponseBody? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Experiment? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateExperimentRunRequestBody? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateExperimentRunResponseBody? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateExperimentRunResponseBodyData? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateProjectRequestBody? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateProjectResponseBody? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Project? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatePromptRequestBody? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptData? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionData? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatePromptResponseBody? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersion? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatePromptVersionRequestBody? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTagData>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionTagData? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreatePromptVersionResponseBody? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSessionNoteRequestBody? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionNoteData? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSessionNoteResponseBody? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSpanNoteRequestBody? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanNoteData? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSpanNoteResponseBody? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSpansRequestBody? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.Span>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Span? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateSpansResponseBody? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateTraceNoteRequestBody? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceNoteData? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateTraceNoteResponseBody? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserRequestBody? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.User? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LocalUserData? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OAuth2UserData? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LDAPUserData? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserRequestBodyUserDiscriminator? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserRequestBodyUserDiscriminatorAuthMethod? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserResponseBody? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data2? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LocalUser? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OAuth2User? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LDAPUser? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserResponseBodyDataDiscriminator? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CreateUserResponseBodyDataDiscriminatorAuthMethod? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CustomModelProvider? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.CustomModelProviderSdk? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DataUIPart? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Dataset? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetExample? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetExampleSource? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetVersion? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DatasetWithExampleCount? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteAnnotationConfigResponseBody? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data5? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminator? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteAnnotationConfigResponseBodyDataDiscriminatorType? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteSessionsRequestBody? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DynamicToolApprovalRequestedPart? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<global::Phoenix.ToolApprovalRequested, global::Phoenix.ToolApprovalResponded>? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolApprovalRequested? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolApprovalResponded? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DynamicToolApprovalRespondedPart? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DynamicToolInputAvailablePart? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DynamicToolOutputDeniedPart? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ExperimentEvaluationResult? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ExperimentRun? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ExperimentTag? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.FileUIPart? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAgentSessionResponseBody? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAllUserApiKeysResponseBody? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.UserApiKey>? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UserApiKey? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigResponseBody? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data3? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminator? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigResponseBodyDataDiscriminatorType? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigsResponseBody? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DataItem2>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DataItem2? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminator? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetAnnotationConfigsResponseBodyDataItemDiscriminatorType? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetApiKeysResponseBody? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ApiKey>? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetCustomModelProvidersResponseBody? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.CustomModelProvider>? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetDatasetLabelResponseBody? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetDatasetLabelsResponseBody? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DatasetLabel>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetDatasetResponseBody? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetExperimentResponseBody? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetIncompleteEvaluationsResponseBody? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentEvaluation>? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.IncompleteExperimentEvaluation? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetIncompleteExperimentRunsResponseBody? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.IncompleteExperimentRun>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.IncompleteExperimentRun? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetModelProvidersResponseBody? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.BuiltInModelProvider>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetProjectAnnotationConfigsResponseBody? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DataItem3>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DataItem3? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminator? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetProjectResponseBody? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetProjectsResponseBody? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.Project>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetPromptResponseBody? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetPromptVersionTagsResponseBody? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PromptVersionTag>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionTag? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetPromptVersionsResponseBody? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PromptVersion>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetPromptsResponseBody? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.Prompt>? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Prompt? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetSessionResponseBody? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionData? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetSessionsResponseBody? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SessionData>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetSpanResponseBody? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetTracesResponseBody? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.TraceData>? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceData? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetUsersResponseBody? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DataItem>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DataItem? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetUsersResponseBodyDataItemDiscriminator? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetUsersResponseBodyDataItemDiscriminatorAuthMethod? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetViewerResponseBody? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetViewerResponseBodyDataDiscriminator? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetViewerResponseBodyDataDiscriminatorAuthMethod? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.HTTPValidationError? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ValidationError>? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ValidationError? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LDAPUserRole? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LDAPUserDataRole? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyAssistantMessageMetadata? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TurnTraceContext? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyAssistantMetadataUIMessage? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyAssistantMetadataUIMessageRole? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TextUIPart? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ReasoningUIPart? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesToolInputStreamingPart? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolInputAvailablePart? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputAvailablePart? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesToolOutputErrorPart? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolApprovalRequestedPart? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolApprovalRespondedPart? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolOutputDeniedPart? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolInputStreamingPart? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputAvailablePart? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAiUiVercelAiRequestTypesDynamicToolOutputErrorPart? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SourceUrlUIPart? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SourceDocumentUIPart? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.StepStartUIPart? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatRegenerateMessage? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.LegacyAssistantMetadataUIMessage>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatRegenerateMessageEditPermission? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatSubmitMessage? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatRequestDiscriminator? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatRequestDiscriminatorTrigger? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LegacyChatSubmitMessageEditPermission? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListAgentSessionMessagesResponseBody? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PhoenixUIMessage>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListAgentSessionsResponseBody? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.AgentSessionSummary>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetExamplesData? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DatasetExample>? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetExamplesResponseBody? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetLabelsForDatasetResponseBody? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetSplitsResponseBody? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DatasetSplit>? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetVersionsResponseBody? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DatasetVersion>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListDatasetsResponseBody? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.Dataset>? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListExperimentRunsResponseBody? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ExperimentRun>? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListExperimentTagsResponseBody? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ExperimentTag>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListExperimentsResponseBody? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.Experiment>? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LocalUserRole? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.LocalUserDataRole? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.MessageMetadata? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixVariant1? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixAssistantMessageMetadata? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixUserMessageMetadata? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.MessageMetadataPhoenixVariant1Discriminator? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.MessageMetadataPhoenixVariant1DiscriminatorType? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PydanticAIMessageMetadata? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OAuth2UserRole? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OAuth2UserDataRole? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpAnyValue? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpArrayValue? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<double?, global::Phoenix.OtlpDoubleValue?, string>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpDoubleValue? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<int?, string>? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.OtlpAnyValue>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpEvent? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.OtlpKeyValue>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpKeyValue? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<long?, string>? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpKind? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpSpan? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.OtlpEvent>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<global::Phoenix.OtlpKind?, int?>? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpStatus? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OtlpSpansResponseBody? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.OtlpSpan>? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PatchAgentSessionRequestBody? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PatchAgentSessionResponseBody? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PatchPromptRequestBody? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PatchPromptResponseBody? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixUIMessageRole? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesToolInputStreamingPart? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixDbTypesDataStreamProtocolRequestTypesDynamicToolInputStreamingPart? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UIContexts? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixUserMessageMetadataEditPermission? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundBuiltinModelUIContext? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundCustomProviderModelUIContext? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundEvaluatorUIContext? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundEvaluatorUIContextKind? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundExperimentScaffoldUIContext? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundInstanceUIContext? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ModelVariant1? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundInstanceUIContextModelVariant1Discriminator? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PlaygroundInstanceUIContextModelVariant1DiscriminatorType? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PlaygroundInstanceUIContext>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PlaygroundEvaluatorUIContext>? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ProjectRetentionPolicyData? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicInvocationParameters? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicInvocationParametersContent? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicOutputConfig? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Thinking? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigDisabled? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigEnabled? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptive? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminator? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicInvocationParametersContentThinkingDiscriminatorType? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicOutputConfigEffort? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigAdaptiveDisplay? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAnthropicThinkingConfigEnabledDisplay? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAwsInvocationParameters? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAwsInvocationParametersContent? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAzureOpenAIInvocationParameters? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAzureOpenAIInvocationParametersContent? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptAzureOpenAIInvocationParametersContentReasoningEffort? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptCerebrasInvocationParameters? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptCerebrasInvocationParametersContent? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptCerebrasInvocationParametersContentReasoningEffort? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptChatTemplate? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.PromptMessage>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMessage? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptDeepSeekInvocationParameters? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptDeepSeekInvocationParametersContent? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptDeepSeekInvocationParametersContentReasoningEffort? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptFireworksInvocationParameters? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptFireworksInvocationParametersContent? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptFireworksInvocationParametersContentReasoningEffort? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGoogleInvocationParameters? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGoogleInvocationParametersContent? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGoogleThinkingConfig? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGoogleThinkingConfigThinkingLevel? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGroqInvocationParameters? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGroqInvocationParametersContent? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptGroqInvocationParametersContentReasoningEffort? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMessageRole? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>>? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ContentVariant2Item>? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ContentVariant2Item? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TextContentPart? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolCallContentPart? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolResultContentPart? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMessageContentVariant2ItemDiscriminator? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMessageContentVariant2ItemDiscriminatorType? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMetaInvocationParameters? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMetaInvocationParametersContent? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMetaInvocationParametersContentReasoningEffort? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMoonshotInvocationParameters? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMoonshotInvocationParametersContent? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptMoonshotInvocationParametersContentReasoningEffort? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOllamaInvocationParameters? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOllamaInvocationParametersContent? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOllamaInvocationParametersContentReasoningEffort? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOpenAIInvocationParameters? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOpenAIInvocationParametersContent? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptOpenAIInvocationParametersContentReasoningEffort? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptPerplexityInvocationParameters? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptPerplexityInvocationParametersContent? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptPerplexityInvocationParametersContentReasoningEffort? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptResponseFormatJSONSchema? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptResponseFormatJSONSchemaDefinition? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptStringTemplate? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTemplateFormat? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTemplateType? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTogetherInvocationParameters? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTogetherInvocationParametersContent? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTogetherInvocationParametersContentReasoningEffort? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolChoiceNone? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolChoiceOneOrMore? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolChoiceSpecificFunctionTool? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolChoiceZeroOrMore? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolFunction? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolFunctionDefinition? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolRaw? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptTools? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.ToolsItem>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolsItem? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolsToolDiscriminator? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolsToolDiscriminatorType? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolChoice? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolsToolChoiceDiscriminator? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptToolsToolChoiceDiscriminatorType? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Template? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionTemplateDiscriminator? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionTemplateDiscriminatorType? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InvocationParameters? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptXAIInvocationParameters? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptZAIInvocationParameters? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionInvocationParametersDiscriminator? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionInvocationParametersDiscriminatorType? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ResponseFormatVariant1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionResponseFormatVariant1Discriminator? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionResponseFormatVariant1DiscriminatorType? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Template2? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataTemplateDiscriminator? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataTemplateDiscriminatorType? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.InvocationParameters2? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataInvocationParametersDiscriminator? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataInvocationParametersDiscriminatorType? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ResponseFormatVariant12? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataResponseFormatVariant1Discriminator? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptVersionDataResponseFormatVariant1DiscriminatorType? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptXAIInvocationParametersContent? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptXAIInvocationParametersContentReasoningEffort? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptZAIInvocationParametersContent? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PromptZAIInvocationParametersContentReasoningEffort? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ReasoningUIPartState? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ResponseBodyUpsertOrDeleteSecretsResult? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertOrDeleteSecretsResult? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SecretKeyValue? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotation? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotationSource? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotationAnnotatorKind? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotationDataAnnotatorKind? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionAnnotationsResponseBody? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SessionAnnotation>? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SessionTraceData>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionTraceData? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetDatasetLabelsForDatasetResponseBody? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetDatasetLabelsRequestBody? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetExperimentTagRequestBody? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetExperimentTagResponseBody? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectAnnotationConfigsRequestBody? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectAnnotationConfigsResponseBody? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.DataItem4>? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DataItem4? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminator? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectAnnotationConfigsResponseBodyDataItemDiscriminatorType? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectRetentionPolicyRequestBody? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SetProjectRetentionPolicyResponseBody? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanContext? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SpanEvent>? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanEvent? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotation? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotationSource? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotationAnnotatorKind? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotationDataAnnotatorKind? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanAnnotationsResponseBody? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SpanAnnotation>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpanDocumentAnnotationDataAnnotatorKind? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SpansResponseBody? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubmitAgentSessionToolApprovalsRequestBody? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubmitAgentSessionToolApprovalsResponseBody? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubmitAgentSessionToolOutputsRequestBody? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SubmitAgentSessionToolOutputsResponseBody? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TextUIPartState? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolCallFunction? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolCallContentPartToolCallDiscriminator? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ToolCallContentPartToolCallDiscriminatorType? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.IList<object>>? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotation? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotationSource? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotationAnnotatorKind? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotationDataAnnotatorKind? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceAnnotationsResponseBody? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.TraceAnnotation>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.TraceSpanData>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TraceSpanData? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TransferTracesData? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TransferTracesRequestBody? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TransferTracesResponseBody? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateAnnotationConfigResponseBody? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.Data6? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminator? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateAnnotationConfigResponseBodyDataDiscriminatorType? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateDatasetLabelRequestBody? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateDatasetLabelResponseBody? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateDatasetSplitRequestBody? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateDatasetSplitResponseBody? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateExperimentRequestBody? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateExperimentResponseBody? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateProjectRequestBody? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpdateProjectResponseBody? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UploadDatasetData? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UploadDatasetResponseBody? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertExperimentEvaluationRequestBody? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertExperimentEvaluationRequestBodyAnnotatorKind? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertExperimentEvaluationResponseBody? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertExperimentEvaluationResponseBodyData? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UpsertOrDeleteSecretsRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.SecretKeyValue>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.AnyOf<string, int?>>? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, int?>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentErrorChunk? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AgentErrorData? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixToolCallCallbackProviderMetadata? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixToolCallCallbackProviderMetadataToolExecutionEnvironment? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixToolCallProviderMetadata? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.PhoenixToolCallProviderMetadataToolExecutionEnvironment? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.SessionSummaryChunk? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TranscriptPersistedChunk? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.TranscriptPersistedData? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UploadDatasetRequest? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UploadDatasetRequestAction? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>>?>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OneOf<string, global::System.Collections.Generic.IList<string>>? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.UploadDatasetRequest2? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteSpanAnnotationsAnnotatorKind? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteTraceAnnotationsAnnotatorKind? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.DeleteSessionAnnotationsAnnotatorKind? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListProjectTracesSort? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListProjectTracesOrder? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetSpansSort? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.GetSpansOrder? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.ListProjectSessionsOrder? Type574 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SessionAnnotationData>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.InsertedSessionAnnotation>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SpanDocumentAnnotationData>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.InsertedSpanDocumentAnnotation>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SpanAnnotationData>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.InsertedSpanAnnotation>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.TraceAnnotationData>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.InsertedTraceAnnotation>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.CategoricalAnnotationValue>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ChatCompletionChoice>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ChatCompletionTextPart>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ChatCompletionTextPart>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ChatContext>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ToolApproval>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ChatRequestCredential>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ChatCompletionRequestMessage>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PromptVersionTagData>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.Span>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.UserApiKey>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DataItem2>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ApiKey>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.CustomModelProvider>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DatasetLabel>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentEvaluation>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.IncompleteExperimentRun>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.BuiltInModelProvider>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DataItem3>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.Project>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PromptVersionTag>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PromptVersion>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.Prompt>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SessionData>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.TraceData>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DataItem>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ValidationError>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.LegacyAssistantMetadataUIMessage>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PhoenixUIMessage>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.AgentSessionSummary>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DatasetExample>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DatasetSplit>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DatasetVersion>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.Dataset>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ExperimentRun>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ExperimentTag>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.Experiment>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.OtlpAnyValue>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.OtlpKeyValue>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.OtlpEvent>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.OtlpSpan>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PlaygroundInstanceUIContext>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PlaygroundEvaluatorUIContext>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.PromptMessage>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<string, global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ContentVariant2Item>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.ToolsItem>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SessionAnnotation>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SessionTraceData>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.DataItem4>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SpanEvent>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SpanAnnotation>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.AnyOf<bool?, int?, double?, string, object, global::System.Collections.Generic.List<object>>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.TraceAnnotation>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.TraceSpanData>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.SecretKeyValue>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.AnyOf<string, int?>>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>>?>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Phoenix.OneOf<string, global::System.Collections.Generic.List<string>>? ListType69 { get; set; }
    }
}