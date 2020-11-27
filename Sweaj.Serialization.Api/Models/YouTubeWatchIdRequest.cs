using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;

namespace Sweaj.Serialization.Api.Models
{

    public partial class YouTubeWatchIdRequest
    {
        [JsonPropertyName("rootVe")]
        public long? RootVe { get; set; }

        [JsonPropertyName("page")]
        public string Page { get; set; }

        [JsonPropertyName("preconnect")]
        public List<Uri> Preconnect { get; set; }

        [JsonPropertyName("playerResponse")]
        public PlayerResponse PlayerResponse { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("xsrf_token")]
        public string XsrfToken { get; set; }

        [JsonPropertyName("response")]
        public Response Response { get; set; }

        [JsonPropertyName("endpoint")]
        public object Endpoint { get; set; }

        [JsonPropertyName("timing")]
        public Timing Timing { get; set; }
    }

    public partial class PlayerResponse
    {
        [JsonPropertyName("responseContext")]
        public PlayerResponseResponseContext ResponseContext { get; set; }

        [JsonPropertyName("playabilityStatus")]
        public PlayabilityStatus PlayabilityStatus { get; set; }

        [JsonPropertyName("streamingData")]
        public StreamingData StreamingData { get; set; }

        [JsonPropertyName("playerAds")]
        public List<PlayerAd> PlayerAds { get; set; }

        [JsonPropertyName("playbackTracking")]
        public PlaybackTracking PlaybackTracking { get; set; }

        [JsonPropertyName("videoDetails")]
        public VideoDetails VideoDetails { get; set; }

        [JsonPropertyName("playerConfig")]
        public PlayerConfig PlayerConfig { get; set; }

        [JsonPropertyName("storyboards")]
        public Storyboards Storyboards { get; set; }

        [JsonPropertyName("microformat")]
        public Microformat Microformat { get; set; }

        [JsonPropertyName("cards")]
        public Cards Cards { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("attestation")]
        public Attestation Attestation { get; set; }

        [JsonPropertyName("videoQualityPromoSupportedRenderers")]
        public VideoQualityPromoSupportedRenderers VideoQualityPromoSupportedRenderers { get; set; }

        [JsonPropertyName("endscreen")]
        public Endscreen Endscreen { get; set; }

        [JsonPropertyName("adPlacements")]
        public List<AdPlacement> AdPlacements { get; set; }
    }

    public partial class AdPlacement
    {
        [JsonPropertyName("adPlacementRenderer")]
        public AdPlacementRenderer AdPlacementRenderer { get; set; }
    }

    public partial class AdPlacementRenderer
    {
        [JsonPropertyName("config")]
        public AdPlacementRendererConfig Config { get; set; }

        [JsonPropertyName("renderer")]
        public Renderer Renderer { get; set; }

        [JsonPropertyName("elementId")]
        public Guid? ElementId { get; set; }

        [JsonPropertyName("adSlotLoggingData")]
        public AdSlotLoggingData AdSlotLoggingData { get; set; }
    }

    public partial class AdSlotLoggingData
    {
        [JsonPropertyName("serializedSlotAdServingDataEntry")]
        public string SerializedSlotAdServingDataEntry { get; set; }
    }

    public partial class AdPlacementRendererConfig
    {
        [JsonPropertyName("adPlacementConfig")]
        public AdPlacementConfig AdPlacementConfig { get; set; }
    }

    public partial class AdPlacementConfig
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("hideCueRangeMarker")]
        public bool HideCueRangeMarker { get; set; }

        [JsonPropertyName("adTimeOffset")]
        public AdTimeOffset AdTimeOffset { get; set; }
    }

    public partial class AdTimeOffset
    {
        [JsonPropertyName("offsetStartMilliseconds")]
        public long OffsetStartMilliseconds { get; set; }

        [JsonPropertyName("offsetEndMilliseconds")]
        public long OffsetEndMilliseconds { get; set; }
    }

    public partial class Renderer
    {
        [JsonPropertyName("actionCompanionAdRenderer")]
        public ActionCompanionAdRenderer ActionCompanionAdRenderer { get; set; }

        [JsonPropertyName("linearAdSequenceRenderer")]
        public LinearAdSequenceRenderer LinearAdSequenceRenderer { get; set; }

        [JsonPropertyName("adBreakServiceRenderer")]
        public AdBreakServiceRenderer AdBreakServiceRenderer { get; set; }
    }

    public partial class ActionCompanionAdRenderer
    {
        [JsonPropertyName("headline")]
        public Description Headline { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("actionButton")]
        public ActionCompanionAdRendererActionButton ActionButton { get; set; }

        [JsonPropertyName("iconImage")]
        public BannerImage IconImage { get; set; }

        [JsonPropertyName("bannerImage")]
        public BannerImage BannerImage { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("adInfoRenderer")]
        public AdInfoRenderer AdInfoRenderer { get; set; }

        [JsonPropertyName("adVideoId")]
        public string AdVideoId { get; set; }

        [JsonPropertyName("impressionPings")]
        public List<PtrackingUrl> ImpressionPings { get; set; }

        [JsonPropertyName("adLayoutLoggingData")]
        public AdLayoutLoggingData AdLayoutLoggingData { get; set; }

        [JsonPropertyName("controlFlowExperimentEnabled")]
        public bool ControlFlowExperimentEnabled { get; set; }
    }

    public partial class ActionCompanionAdRendererActionButton
    {
        [JsonPropertyName("buttonRenderer")]
        public PurpleButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class PurpleButtonRenderer
    {
        [JsonPropertyName("text")]
        public HeaderText Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class ClickthroughEndpointClass
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("loggingUrls")]
        public List<PtrackingUrl> LoggingUrls { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("urlEndpoint")]
        public EndpointUrlEndpoint UrlEndpoint { get; set; }
    }

    public partial class EndpointCommandMetadata
    {
        [JsonPropertyName("webCommandMetadata")]
        public PurpleWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class PurpleWebCommandMetadata
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("webPageType")]
        public WebPageType WebPageType { get; set; }

        [JsonPropertyName("rootVe")]
        public long RootVe { get; set; }
    }

    public partial class PtrackingUrl
    {
        [JsonPropertyName("baseUrl")]
        public Uri BaseUrl { get; set; }
    }

    public partial class EndpointUrlEndpoint
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("target")]
        public Target Target { get; set; }
    }

    public partial class HeaderText
    {
        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public partial class AdInfoRenderer
    {
        [JsonPropertyName("adHoverTextButtonRenderer")]
        public AdHoverTextButtonRenderer AdHoverTextButtonRenderer { get; set; }
    }

    public partial class AdHoverTextButtonRenderer
    {
        [JsonPropertyName("button")]
        public CloseOverlayRendererClass Button { get; set; }

        [JsonPropertyName("hoverText")]
        public HeaderText HoverText { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class PurpleServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("muteAdEndpoint")]
        public MuteAdEndpoint MuteAdEndpoint { get; set; }

        [JsonPropertyName("commandMetadata")]
        public PurpleCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("adInfoDialogEndpoint")]
        public AdInfoDialogEndpoint AdInfoDialogEndpoint { get; set; }

        [JsonPropertyName("loggingUrls")]
        public List<PtrackingUrl> LoggingUrls { get; set; }

        [JsonPropertyName("pingingEndpoint")]
        public PingingEndpoint PingingEndpoint { get; set; }
    }

    public partial class AdFeedbackRenderer
    {
        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("confirmLabel")]
        public ResponseText ConfirmLabel { get; set; }

        [JsonPropertyName("cancelLabel")]
        public ResponseText CancelLabel { get; set; }

        [JsonPropertyName("reasons")]
        public List<Reason> Reasons { get; set; }

        [JsonPropertyName("completionMessage")]
        public ResponseText CompletionMessage { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("cancelEndpoint")]
        public ServiceEndpointClass CancelEndpoint { get; set; }

        [JsonPropertyName("impressionEndpoint")]
        public ServiceEndpointClass ImpressionEndpoint { get; set; }

        [JsonPropertyName("cancelRenderer")]
        public CloseOverlayRendererClass CancelRenderer { get; set; }

        [JsonPropertyName("undoRenderer")]
        public DismissButton UndoRenderer { get; set; }

        [JsonPropertyName("reasonsTitle")]
        public ResponseText ReasonsTitle { get; set; }
    }

    public partial class AdFeedbackEndpointContent
    {
        [JsonPropertyName("adFeedbackRenderer")]
        public AdFeedbackRenderer AdFeedbackRenderer { get; set; }
    }

    public partial class AdFeedbackEndpoint
    {
        [JsonPropertyName("content")]
        public AdFeedbackEndpointContent Content { get; set; }
    }

    public partial class FluffyNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("loggingUrls")]
        public List<PtrackingUrl> LoggingUrls { get; set; }

        [JsonPropertyName("adFeedbackEndpoint")]
        public AdFeedbackEndpoint AdFeedbackEndpoint { get; set; }
    }

    public partial class MuteAdRendererButtonRenderer
    {
        [JsonPropertyName("style")]
        public PurpleStyle Style { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public FluffyNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class MuteAdRenderer
    {
        [JsonPropertyName("buttonRenderer")]
        public MuteAdRendererButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class AdInfoDialogRenderer
    {
        [JsonPropertyName("dialogMessage")]
        public DialogMessage DialogMessage { get; set; }

        [JsonPropertyName("muteAdRenderer")]
        public MuteAdRenderer MuteAdRenderer { get; set; }

        [JsonPropertyName("confirmLabel")]
        public HeaderText ConfirmLabel { get; set; }

        [JsonPropertyName("confirmServiceEndpoint")]
        public ConfirmServiceEndpointElement ConfirmServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("title")]
        public HeaderText Title { get; set; }

        [JsonPropertyName("adReasons")]
        public List<AdReason> AdReasons { get; set; }

        [JsonPropertyName("impressionEndpoints")]
        public List<ConfirmServiceEndpointElement> ImpressionEndpoints { get; set; }

        [JsonPropertyName("closeOverlayRenderer")]
        public CloseOverlayRendererClass CloseOverlayRenderer { get; set; }
    }

    public partial class Dialog
    {
        [JsonPropertyName("adInfoDialogRenderer")]
        public AdInfoDialogRenderer AdInfoDialogRenderer { get; set; }
    }

    public partial class AdInfoDialogEndpoint
    {
        [JsonPropertyName("dialog")]
        public Dialog Dialog { get; set; }
    }

    public partial class PurpleNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public PurpleCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("adInfoDialogEndpoint")]
        public AdInfoDialogEndpoint AdInfoDialogEndpoint { get; set; }
    }

    public partial class CloseOverlayRendererButtonRenderer
    {
        [JsonPropertyName("style")]
        public PurpleStyle Style { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public PurpleNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public PurpleServiceEndpoint ServiceEndpoint { get; set; }
    }

    public partial class CloseOverlayRendererClass
    {
        [JsonPropertyName("buttonRenderer")]
        public CloseOverlayRendererButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class PurpleCommandMetadata
    {
        [JsonPropertyName("webCommandMetadata")]
        public FluffyWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class FluffyWebCommandMetadata
    {
        [JsonPropertyName("ignoreNavigation")]
        public bool IgnoreNavigation { get; set; }
    }

    public partial class MuteAdEndpoint
    {
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }
    }

    public partial class PingingEndpoint
    {
        [JsonPropertyName("hack")]
        public bool Hack { get; set; }
    }

    public partial class ServiceEndpointClass
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("muteAdEndpoint")]
        public MuteAdEndpoint MuteAdEndpoint { get; set; }
    }

    public partial class ResponseText
    {
        [JsonPropertyName("runs")]
        public List<ResponseTextRun> Runs { get; set; }
    }

    public partial class ResponseTextRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public partial class Reason
    {
        [JsonPropertyName("reason")]
        public ResponseText ReasonReason { get; set; }

        [JsonPropertyName("endpoint")]
        public ReasonEndpoint Endpoint { get; set; }
    }

    public partial class ReasonEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("loggingUrls")]
        public List<PtrackingUrl> LoggingUrls { get; set; }

        [JsonPropertyName("muteAdEndpoint")]
        public MuteAdEndpoint MuteAdEndpoint { get; set; }
    }

    public partial class DismissButton
    {
        [JsonPropertyName("buttonRenderer")]
        public DismissButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class DismissButtonButtonRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public ServiceEndpointClass ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool? IsDisabled { get; set; }
    }

    public partial class IconImage
    {
        [JsonPropertyName("iconType")]
        public string IconType { get; set; }
    }

    public partial class AdReason
    {
        [JsonPropertyName("runs")]
        public List<AdReasonRun> Runs { get; set; }

        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public partial class AdReasonRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }
    }

    public partial class ConfirmServiceEndpointElement
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("loggingUrls")]
        public List<PtrackingUrl> LoggingUrls { get; set; }

        [JsonPropertyName("pingingEndpoint")]
        public PingingEndpoint PingingEndpoint { get; set; }

        [JsonPropertyName("adLifecycleCommand")]
        public CommandAdLifecycleCommand AdLifecycleCommand { get; set; }
    }

    public partial class CommandAdLifecycleCommand
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }
    }

    public partial class DialogMessage
    {
        [JsonPropertyName("runs")]
        public List<DialogMessageRun> Runs { get; set; }
    }

    public partial class DialogMessageRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("bold")]
        public bool? Bold { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }
    }

    public partial class AdLayoutLoggingData
    {
        [JsonPropertyName("serializedAdServingDataEntry")]
        public string SerializedAdServingDataEntry { get; set; }
    }

    public partial class BannerImage
    {
        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class BackgroundClass
    {
        [JsonPropertyName("thumbnails")]
        public List<ChannelAvatarThumbnail> Thumbnails { get; set; }
    }

    public partial class ChannelAvatarThumbnail
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }
    }

    public partial class Description
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("isTemplated")]
        public bool IsTemplated { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class AdBreakServiceRenderer
    {
        [JsonPropertyName("prefetchMilliseconds")]
        public long PrefetchMilliseconds { get; set; }

        [JsonPropertyName("getAdBreakUrl")]
        public Uri GetAdBreakUrl { get; set; }
    }

    public partial class LinearAdSequenceRenderer
    {
        [JsonPropertyName("linearAds")]
        public List<LinearAd> LinearAds { get; set; }
    }

    public partial class LinearAd
    {
        [JsonPropertyName("instreamVideoAdRenderer")]
        public InstreamVideoAdRenderer InstreamVideoAdRenderer { get; set; }

        [JsonPropertyName("adActionInterstitialRenderer")]
        public AdActionInterstitialRenderer AdActionInterstitialRenderer { get; set; }
    }

    public partial class AdActionInterstitialRenderer
    {
        [JsonPropertyName("image")]
        public BannerImage Image { get; set; }

        [JsonPropertyName("headline")]
        public Description Headline { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("actionButton")]
        public ActionCompanionAdRendererActionButton ActionButton { get; set; }

        [JsonPropertyName("durationMilliseconds")]
        public long DurationMilliseconds { get; set; }

        [JsonPropertyName("countdownRenderer")]
        public CountdownRenderer CountdownRenderer { get; set; }

        [JsonPropertyName("background")]
        public Background Background { get; set; }

        [JsonPropertyName("completionCommands")]
        public List<IonCommand> CompletionCommands { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("backgroundImage")]
        public BackgroundImage BackgroundImage { get; set; }

        [JsonPropertyName("abandonCommands")]
        public AbandonCommands AbandonCommands { get; set; }

        [JsonPropertyName("adRendererCommands")]
        public AdActionInterstitialRendererAdRendererCommands AdRendererCommands { get; set; }

        [JsonPropertyName("skipButton")]
        public Skip SkipButton { get; set; }
    }

    public partial class AbandonCommands
    {
        [JsonPropertyName("commands")]
        public List<ConfirmServiceEndpointElement> Commands { get; set; }
    }

    public partial class AdActionInterstitialRendererAdRendererCommands
    {
        [JsonPropertyName("impressionCommand")]
        public Command ImpressionCommand { get; set; }
    }

    public partial class Command
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandExecutorCommand")]
        public AbandonCommands CommandExecutorCommand { get; set; }
    }

    public partial class Background
    {
        [JsonPropertyName("thumbnails")]
        public List<UrlEndpointElement> Thumbnails { get; set; }
    }

    public partial class UrlEndpointElement
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public partial class BackgroundImage
    {
        [JsonPropertyName("thumbnail")]
        public Background Thumbnail { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class IonCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("adLifecycleCommand")]
        public CompletionCommandAdLifecycleCommand AdLifecycleCommand { get; set; }
    }

    public partial class CompletionCommandAdLifecycleCommand
    {
        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("elementId")]
        public Guid? ElementId { get; set; }
    }

    public partial class CountdownRenderer
    {
        [JsonPropertyName("timedPieCountdownRenderer")]
        public NRenderer TimedPieCountdownRenderer { get; set; }
    }

    public partial class NRenderer
    {
        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Skip
    {
        [JsonPropertyName("skipButtonRenderer")]
        public SkipButtonRenderer SkipButtonRenderer { get; set; }
    }

    public partial class SkipButtonRenderer
    {
        [JsonPropertyName("message")]
        public Description Message { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("adRendererCommands")]
        public SkipButtonRendererAdRendererCommands AdRendererCommands { get; set; }
    }

    public partial class SkipButtonRendererAdRendererCommands
    {
        [JsonPropertyName("clickCommand")]
        public Command ClickCommand { get; set; }
    }

    public partial class InstreamVideoAdRenderer
    {
        [JsonPropertyName("skipOffsetMilliseconds")]
        public long SkipOffsetMilliseconds { get; set; }

        [JsonPropertyName("pings")]
        public Pings Pings { get; set; }

        [JsonPropertyName("clickthroughEndpoint")]
        public ClickthroughEndpointClass ClickthroughEndpoint { get; set; }

        [JsonPropertyName("csiParameters")]
        public List<Param> CsiParameters { get; set; }

        [JsonPropertyName("playerVars")]
        public string PlayerVars { get; set; }

        [JsonPropertyName("playerOverlay")]
        public PlayerOverlay PlayerOverlay { get; set; }

        [JsonPropertyName("impressionCommands")]
        public List<IonCommand> ImpressionCommands { get; set; }

        [JsonPropertyName("elementId")]
        public Guid ElementId { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("legacyInfoCardVastExtension")]
        public string LegacyInfoCardVastExtension { get; set; }

        [JsonPropertyName("sodarExtensionData")]
        public SodarExtensionData SodarExtensionData { get; set; }

        [JsonPropertyName("externalVideoId")]
        public string ExternalVideoId { get; set; }

        [JsonPropertyName("completeCommands")]
        public List<CompleteCommand> CompleteCommands { get; set; }

        [JsonPropertyName("adLayoutLoggingData")]
        public AdLayoutLoggingData AdLayoutLoggingData { get; set; }
    }

    public partial class CompleteCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("adLifecycleCommand")]
        public CommandAdLifecycleCommand AdLifecycleCommand { get; set; }
    }

    public partial class Param
    {
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public partial class Pings
    {
        [JsonPropertyName("impressionPings")]
        public List<PtrackingUrl> ImpressionPings { get; set; }

        [JsonPropertyName("errorPings")]
        public List<PtrackingUrl> ErrorPings { get; set; }

        [JsonPropertyName("mutePings")]
        public List<PtrackingUrl> MutePings { get; set; }

        [JsonPropertyName("unmutePings")]
        public List<PtrackingUrl> UnmutePings { get; set; }

        [JsonPropertyName("pausePings")]
        public List<PtrackingUrl> PausePings { get; set; }

        [JsonPropertyName("rewindPings")]
        public List<PtrackingUrl> RewindPings { get; set; }

        [JsonPropertyName("resumePings")]
        public List<PtrackingUrl> ResumePings { get; set; }

        [JsonPropertyName("skipPings")]
        public List<PtrackingUrl> SkipPings { get; set; }

        [JsonPropertyName("closePings")]
        public List<PtrackingUrl> ClosePings { get; set; }

        [JsonPropertyName("progressPings")]
        public List<ProgressPing> ProgressPings { get; set; }

        [JsonPropertyName("clickthroughPings")]
        public List<PtrackingUrl> ClickthroughPings { get; set; }

        [JsonPropertyName("fullscreenPings")]
        public List<PtrackingUrl> FullscreenPings { get; set; }

        [JsonPropertyName("activeViewViewablePings")]
        public List<PtrackingUrl> ActiveViewViewablePings { get; set; }

        [JsonPropertyName("endFullscreenPings")]
        public List<PtrackingUrl> EndFullscreenPings { get; set; }

        [JsonPropertyName("activeViewMeasurablePings")]
        public List<PtrackingUrl> ActiveViewMeasurablePings { get; set; }

        [JsonPropertyName("abandonPings")]
        public List<PtrackingUrl> AbandonPings { get; set; }

        [JsonPropertyName("activeViewFullyViewableAudibleHalfDurationPings")]
        public List<PtrackingUrl> ActiveViewFullyViewableAudibleHalfDurationPings { get; set; }

        [JsonPropertyName("completePings")]
        public List<PtrackingUrl> CompletePings { get; set; }

        [JsonPropertyName("startPings")]
        public List<PtrackingUrl> StartPings { get; set; }

        [JsonPropertyName("firstQuartilePings")]
        public List<PtrackingUrl> FirstQuartilePings { get; set; }

        [JsonPropertyName("secondQuartilePings")]
        public List<PtrackingUrl> SecondQuartilePings { get; set; }

        [JsonPropertyName("thirdQuartilePings")]
        public List<PtrackingUrl> ThirdQuartilePings { get; set; }
    }

    public partial class ProgressPing
    {
        [JsonPropertyName("baseUrl")]
        public Uri BaseUrl { get; set; }

        [JsonPropertyName("offsetMilliseconds")]
        public long OffsetMilliseconds { get; set; }
    }

    public partial class PlayerOverlay
    {
        [JsonPropertyName("instreamAdPlayerOverlayRenderer")]
        public InstreamAdPlayerOverlayRenderer InstreamAdPlayerOverlayRenderer { get; set; }
    }

    public partial class InstreamAdPlayerOverlayRenderer
    {
        [JsonPropertyName("skipOrPreviewRenderer")]
        public SkipOrPreviewRenderer SkipOrPreviewRenderer { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("visitAdvertiserRenderer")]
        public VisitAdvertiserRenderer VisitAdvertiserRenderer { get; set; }

        [JsonPropertyName("adBadgeRenderer")]
        public AdBadgeRenderer AdBadgeRenderer { get; set; }

        [JsonPropertyName("adDurationRemaining")]
        public AdDurationRemaining AdDurationRemaining { get; set; }

        [JsonPropertyName("adInfoRenderer")]
        public AdInfoRenderer AdInfoRenderer { get; set; }

        [JsonPropertyName("flyoutCtaRenderer")]
        public InstreamAdPlayerOverlayRendererFlyoutCtaRenderer FlyoutCtaRenderer { get; set; }
    }

    public partial class AdBadgeRenderer
    {
        [JsonPropertyName("simpleAdBadgeRenderer")]
        public SimpleAdBadgeRenderer SimpleAdBadgeRenderer { get; set; }
    }

    public partial class SimpleAdBadgeRenderer
    {
        [JsonPropertyName("text")]
        public Description Text { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class AdDurationRemaining
    {
        [JsonPropertyName("adDurationRemainingRenderer")]
        public AdDurationRemainingRenderer AdDurationRemainingRenderer { get; set; }
    }

    public partial class AdDurationRemainingRenderer
    {
        [JsonPropertyName("templatedCountdown")]
        public TemplatedCountdown TemplatedCountdown { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class TemplatedCountdown
    {
        [JsonPropertyName("templatedAdText")]
        public Description TemplatedAdText { get; set; }
    }

    public partial class InstreamAdPlayerOverlayRendererFlyoutCtaRenderer
    {
        [JsonPropertyName("flyoutCtaRenderer")]
        public FlyoutCtaRendererFlyoutCtaRenderer FlyoutCtaRenderer { get; set; }
    }

    public partial class FlyoutCtaRendererFlyoutCtaRenderer
    {
        [JsonPropertyName("image")]
        public BannerImage Image { get; set; }

        [JsonPropertyName("headline")]
        public Description Headline { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("actionButton")]
        public ActionCompanionAdRendererActionButton ActionButton { get; set; }

        [JsonPropertyName("startMs")]
        public long StartMs { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class SkipOrPreviewRenderer
    {
        [JsonPropertyName("skipAdRenderer")]
        public SkipAdRenderer SkipAdRenderer { get; set; }
    }

    public partial class SkipAdRenderer
    {
        [JsonPropertyName("preskipRenderer")]
        public PreskipRenderer PreskipRenderer { get; set; }

        [JsonPropertyName("skippableRenderer")]
        public Skip SkippableRenderer { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("skipOffsetMilliseconds")]
        public long SkipOffsetMilliseconds { get; set; }
    }

    public partial class PreskipRenderer
    {
        [JsonPropertyName("adPreviewRenderer")]
        public AdPreviewRenderer AdPreviewRenderer { get; set; }
    }

    public partial class AdPreviewRenderer
    {
        [JsonPropertyName("thumbnail")]
        public BannerImage Thumbnail { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("templatedCountdown")]
        public TemplatedCountdown TemplatedCountdown { get; set; }

        [JsonPropertyName("durationMilliseconds")]
        public long DurationMilliseconds { get; set; }
    }

    public partial class VisitAdvertiserRenderer
    {
        [JsonPropertyName("buttonRenderer")]
        public VisitAdvertiserRendererButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class VisitAdvertiserRendererButtonRenderer
    {
        [JsonPropertyName("style")]
        public PurpleStyle Style { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class SodarExtensionData
    {
        [JsonPropertyName("siub")]
        public string Siub { get; set; }

        [JsonPropertyName("bgub")]
        public string Bgub { get; set; }

        [JsonPropertyName("scs")]
        public string Scs { get; set; }

        [JsonPropertyName("bgp")]
        public string Bgp { get; set; }
    }

    public partial class Attestation
    {
        [JsonPropertyName("playerAttestationRenderer")]
        public PlayerAttestationRenderer PlayerAttestationRenderer { get; set; }
    }

    public partial class PlayerAttestationRenderer
    {
        [JsonPropertyName("challenge")]
        public string Challenge { get; set; }

        [JsonPropertyName("botguardData")]
        public BotguardData BotguardData { get; set; }
    }

    public partial class BotguardData
    {
        [JsonPropertyName("program")]
        public string Program { get; set; }

        [JsonPropertyName("interpreterUrl")]
        public string InterpreterUrl { get; set; }
    }

    public partial class Cards
    {
        [JsonPropertyName("cardCollectionRenderer")]
        public CardCollectionRenderer CardCollectionRenderer { get; set; }
    }

    public partial class CardCollectionRenderer
    {
        [JsonPropertyName("cards")]
        public List<Card> Cards { get; set; }

        [JsonPropertyName("headerText")]
        public HeaderText HeaderText { get; set; }

        [JsonPropertyName("icon")]
        public CloseButton Icon { get; set; }

        [JsonPropertyName("closeButton")]
        public CloseButton CloseButton { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("allowTeaserDismiss")]
        public bool AllowTeaserDismiss { get; set; }

        [JsonPropertyName("logIconVisibilityUpdates")]
        public bool LogIconVisibilityUpdates { get; set; }
    }

    public partial class Card
    {
        [JsonPropertyName("cardRenderer")]
        public CardRenderer CardRenderer { get; set; }
    }

    public partial class CardRenderer
    {
        [JsonPropertyName("teaser")]
        public Teaser Teaser { get; set; }

        [JsonPropertyName("content")]
        public CardRendererContent Content { get; set; }

        [JsonPropertyName("cueRanges")]
        public List<CueRange> CueRanges { get; set; }

        [JsonPropertyName("icon")]
        public CloseButton Icon { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("cardId")]
        public string CardId { get; set; }

        [JsonPropertyName("feature")]
        public string Feature { get; set; }
    }

    public partial class CardRendererContent
    {
        [JsonPropertyName("collaboratorInfoCardContentRenderer")]
        public CollaboratorInfoCardContentRenderer CollaboratorInfoCardContentRenderer { get; set; }
    }

    public partial class CollaboratorInfoCardContentRenderer
    {
        [JsonPropertyName("channelAvatar")]
        public BackgroundClass ChannelAvatar { get; set; }

        [JsonPropertyName("customText")]
        public HeaderText CustomText { get; set; }

        [JsonPropertyName("channelName")]
        public HeaderText ChannelName { get; set; }

        [JsonPropertyName("subscriberCountText")]
        public HeaderText SubscriberCountText { get; set; }

        [JsonPropertyName("endpoint")]
        public CollaboratorInfoCardContentRendererEndpoint Endpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class CollaboratorInfoCardContentRendererEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("browseEndpoint")]
        public EndpointBrowseEndpoint BrowseEndpoint { get; set; }
    }

    public partial class EndpointBrowseEndpoint
    {
        [JsonPropertyName("browseId")]
        public string BrowseId { get; set; }
    }

    public partial class CueRange
    {
        [JsonPropertyName("startCardActiveMs")]
        public long StartCardActiveMs { get; set; }

        [JsonPropertyName("endCardActiveMs")]
        public long EndCardActiveMs { get; set; }

        [JsonPropertyName("teaserDurationMs")]
        public long TeaserDurationMs { get; set; }

        [JsonPropertyName("iconAfterTeaserMs")]
        public long IconAfterTeaserMs { get; set; }
    }

    public partial class CloseButton
    {
        [JsonPropertyName("infoCardIconRenderer")]
        public NRenderer InfoCardIconRenderer { get; set; }
    }

    public partial class Teaser
    {
        [JsonPropertyName("simpleCardTeaserRenderer")]
        public SimpleCardTeaserRenderer SimpleCardTeaserRenderer { get; set; }
    }

    public partial class SimpleCardTeaserRenderer
    {
        [JsonPropertyName("message")]
        public HeaderText Message { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("prominent")]
        public bool Prominent { get; set; }

        [JsonPropertyName("logVisibilityUpdates")]
        public bool LogVisibilityUpdates { get; set; }
    }

    public partial class Endscreen
    {
        [JsonPropertyName("endscreenRenderer")]
        public EndscreenRenderer EndscreenRenderer { get; set; }
    }

    public partial class EndscreenRenderer
    {
        [JsonPropertyName("elements")]
        public List<Element> Elements { get; set; }

        [JsonPropertyName("startMs")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StartMs { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Element
    {
        [JsonPropertyName("endscreenElementRenderer")]
        public EndscreenElementRenderer EndscreenElementRenderer { get; set; }
    }

    public partial class EndscreenElementRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("image")]
        public BackgroundClass Image { get; set; }

        [JsonPropertyName("videoDuration")]
        public HeaderText VideoDuration { get; set; }

        [JsonPropertyName("left")]
        public double Left { get; set; }

        [JsonPropertyName("width")]
        public double Width { get; set; }

        [JsonPropertyName("top")]
        public double Top { get; set; }

        [JsonPropertyName("aspectRatio")]
        public double AspectRatio { get; set; }

        [JsonPropertyName("startMs")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long StartMs { get; set; }

        [JsonPropertyName("endMs")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long EndMs { get; set; }

        [JsonPropertyName("title")]
        public ResponseTextClass Title { get; set; }

        [JsonPropertyName("metadata")]
        public HeaderText Metadata { get; set; }

        [JsonPropertyName("endpoint")]
        public CurrentVideoEndpointClass Endpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public partial class CurrentVideoEndpointClass
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("watchEndpoint")]
        public WatchEndpoint WatchEndpoint { get; set; }
    }

    public partial class WatchEndpoint
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }
    }

    public partial class ResponseTextClass
    {
        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("simpleText")]
        public string SimpleText { get; set; }
    }

    public partial class ToggledAccessibilityClass
    {
        [JsonPropertyName("accessibilityData")]
        public AccessibilityAccessibility AccessibilityData { get; set; }
    }

    public partial class AccessibilityAccessibility
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }
    }

    public partial class Microformat
    {
        [JsonPropertyName("playerMicroformatRenderer")]
        public PlayerMicroformatRenderer PlayerMicroformatRenderer { get; set; }
    }

    public partial class PlayerMicroformatRenderer
    {
        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("embed")]
        public Embed Embed { get; set; }

        [JsonPropertyName("title")]
        public HeaderText Title { get; set; }

        [JsonPropertyName("description")]
        public HeaderText Description { get; set; }

        [JsonPropertyName("lengthSeconds")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long LengthSeconds { get; set; }

        [JsonPropertyName("ownerProfileUrl")]
        public Uri OwnerProfileUrl { get; set; }

        [JsonPropertyName("externalChannelId")]
        public string ExternalChannelId { get; set; }

        [JsonPropertyName("isFamilySafe")]
        public bool IsFamilySafe { get; set; }

        [JsonPropertyName("availableCountries")]
        public List<string> AvailableCountries { get; set; }

        [JsonPropertyName("isUnlisted")]
        public bool IsUnlisted { get; set; }

        [JsonPropertyName("hasYpcMetadata")]
        public bool HasYpcMetadata { get; set; }

        [JsonPropertyName("viewCount")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ViewCount { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("publishDate")]
        public DateTimeOffset PublishDate { get; set; }

        [JsonPropertyName("ownerChannelName")]
        public string OwnerChannelName { get; set; }

        [JsonPropertyName("uploadDate")]
        public DateTimeOffset UploadDate { get; set; }
    }

    public partial class Embed
    {
        [JsonPropertyName("iframeUrl")]
        public Uri IframeUrl { get; set; }

        [JsonPropertyName("flashUrl")]
        public Uri FlashUrl { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("flashSecureUrl")]
        public Uri FlashSecureUrl { get; set; }
    }

    public partial class PlayabilityStatus
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("playableInEmbed")]
        public bool PlayableInEmbed { get; set; }

        [JsonPropertyName("miniplayer")]
        public Miniplayer Miniplayer { get; set; }

        [JsonPropertyName("contextParams")]
        public string ContextParams { get; set; }
    }

    public partial class Miniplayer
    {
        [JsonPropertyName("miniplayerRenderer")]
        public MiniplayerRenderer MiniplayerRenderer { get; set; }
    }

    public partial class MiniplayerRenderer
    {
        [JsonPropertyName("playbackMode")]
        public string PlaybackMode { get; set; }
    }

    public partial class PlaybackTracking
    {
        [JsonPropertyName("videostatsPlaybackUrl")]
        public PtrackingUrl VideostatsPlaybackUrl { get; set; }

        [JsonPropertyName("videostatsDelayplayUrl")]
        public PtrackingUrl VideostatsDelayplayUrl { get; set; }

        [JsonPropertyName("videostatsWatchtimeUrl")]
        public PtrackingUrl VideostatsWatchtimeUrl { get; set; }

        [JsonPropertyName("ptrackingUrl")]
        public PtrackingUrl PtrackingUrl { get; set; }

        [JsonPropertyName("qoeUrl")]
        public PtrackingUrl QoeUrl { get; set; }

        [JsonPropertyName("setAwesomeUrl")]
        public Url SetAwesomeUrl { get; set; }

        [JsonPropertyName("atrUrl")]
        public Url AtrUrl { get; set; }
    }

    public partial class Url
    {
        [JsonPropertyName("baseUrl")]
        public Uri BaseUrl { get; set; }

        [JsonPropertyName("elapsedMediaTimeSeconds")]
        public long ElapsedMediaTimeSeconds { get; set; }
    }

    public partial class PlayerAd
    {
        [JsonPropertyName("playerLegacyDesktopWatchAdsRenderer")]
        public PlayerLegacyDesktopWatchAdsRenderer PlayerLegacyDesktopWatchAdsRenderer { get; set; }
    }

    public partial class PlayerLegacyDesktopWatchAdsRenderer
    {
        [JsonPropertyName("playerAdParams")]
        public PlayerAdParams PlayerAdParams { get; set; }

        [JsonPropertyName("gutParams")]
        public GutParams GutParams { get; set; }

        [JsonPropertyName("showCompanion")]
        public bool ShowCompanion { get; set; }

        [JsonPropertyName("showInstream")]
        public bool ShowInstream { get; set; }

        [JsonPropertyName("useGut")]
        public bool UseGut { get; set; }
    }

    public partial class GutParams
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }

    public partial class PlayerAdParams
    {
        [JsonPropertyName("showContentThumbnail")]
        public bool ShowContentThumbnail { get; set; }

        [JsonPropertyName("enabledEngageTypes")]
        public string EnabledEngageTypes { get; set; }
    }

    public partial class PlayerConfig
    {
        [JsonPropertyName("audioConfig")]
        public AudioConfig AudioConfig { get; set; }

        [JsonPropertyName("playbackStartConfig")]
        public PlaybackStartConfig PlaybackStartConfig { get; set; }

        [JsonPropertyName("streamSelectionConfig")]
        public StreamSelectionConfig StreamSelectionConfig { get; set; }

        [JsonPropertyName("daiConfig")]
        public DaiConfig DaiConfig { get; set; }

        [JsonPropertyName("mediaCommonConfig")]
        public MediaCommonConfig MediaCommonConfig { get; set; }

        [JsonPropertyName("webPlayerConfig")]
        public WebPlayerConfig WebPlayerConfig { get; set; }
    }

    public partial class AudioConfig
    {
        [JsonPropertyName("loudnessDb")]
        public double LoudnessDb { get; set; }

        [JsonPropertyName("perceptualLoudnessDb")]
        public double PerceptualLoudnessDb { get; set; }

        [JsonPropertyName("enablePerFormatLoudness")]
        public bool EnablePerFormatLoudness { get; set; }
    }

    public partial class DaiConfig
    {
        [JsonPropertyName("enableServerStitchedDai")]
        public bool EnableServerStitchedDai { get; set; }
    }

    public partial class MediaCommonConfig
    {
        [JsonPropertyName("dynamicReadaheadConfig")]
        public DynamicReadaheadConfig DynamicReadaheadConfig { get; set; }
    }

    public partial class DynamicReadaheadConfig
    {
        [JsonPropertyName("maxReadAheadMediaTimeMs")]
        public long MaxReadAheadMediaTimeMs { get; set; }

        [JsonPropertyName("minReadAheadMediaTimeMs")]
        public long MinReadAheadMediaTimeMs { get; set; }

        [JsonPropertyName("readAheadGrowthRateMs")]
        public long ReadAheadGrowthRateMs { get; set; }
    }

    public partial class PlaybackStartConfig
    {
        [JsonPropertyName("startSeconds")]
        public long StartSeconds { get; set; }
    }

    public partial class StreamSelectionConfig
    {
        [JsonPropertyName("maxBitrate")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long MaxBitrate { get; set; }
    }

    public partial class WebPlayerConfig
    {
        [JsonPropertyName("webPlayerActionsPorting")]
        public WebPlayerActionsPorting WebPlayerActionsPorting { get; set; }
    }

    public partial class WebPlayerActionsPorting
    {
        [JsonPropertyName("getSharePanelCommand")]
        public GetSharePanelCommand GetSharePanelCommand { get; set; }

        [JsonPropertyName("subscribeCommand")]
        public SubscribeCommand SubscribeCommand { get; set; }

        [JsonPropertyName("unsubscribeCommand")]
        public UnsubscribeCommand UnsubscribeCommand { get; set; }

        [JsonPropertyName("addToWatchLaterCommand")]
        public AddToWatchLaterCommand AddToWatchLaterCommand { get; set; }

        [JsonPropertyName("removeFromWatchLaterCommand")]
        public RemoveFromWatchLaterCommand RemoveFromWatchLaterCommand { get; set; }
    }

    public partial class AddToWatchLaterCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public AddToWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }
    }

    public partial class AddToWatchLaterCommandCommandMetadata
    {
        [JsonPropertyName("webCommandMetadata")]
        public TentacledWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class TentacledWebCommandMetadata
    {
        [JsonPropertyName("url")]
        public UrlEnum Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }

        [JsonPropertyName("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public partial class AddToWatchLaterCommandPlaylistEditEndpoint
    {
        [JsonPropertyName("playlistId")]
        public PlaylistId PlaylistId { get; set; }

        [JsonPropertyName("actions")]
        public List<PurpleAction> Actions { get; set; }
    }

    public partial class PurpleAction
    {
        [JsonPropertyName("addedVideoId")]
        public string AddedVideoId { get; set; }

        [JsonPropertyName("action")]
        public HilariousAction Action { get; set; }
    }

    public partial class GetSharePanelCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("webPlayerShareEntityServiceEndpoint")]
        public WebPlayerShareEntityServiceEndpoint WebPlayerShareEntityServiceEndpoint { get; set; }
    }

    public partial class WebPlayerShareEntityServiceEndpoint
    {
        [JsonPropertyName("serializedShareEntity")]
        public string SerializedShareEntity { get; set; }
    }

    public partial class RemoveFromWatchLaterCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public RemoveFromWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }
    }

    public partial class RemoveFromWatchLaterCommandPlaylistEditEndpoint
    {
        [JsonPropertyName("playlistId")]
        public PlaylistId PlaylistId { get; set; }

        [JsonPropertyName("actions")]
        public List<FluffyAction> Actions { get; set; }
    }

    public partial class FluffyAction
    {
        [JsonPropertyName("action")]
        public AmbitiousAction Action { get; set; }

        [JsonPropertyName("removedVideoId")]
        public string RemovedVideoId { get; set; }
    }

    public partial class SubscribeCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("subscribeEndpoint")]
        public SubscribeEndpoint SubscribeEndpoint { get; set; }
    }

    public partial class SubscribeEndpoint
    {
        [JsonPropertyName("channelIds")]
        public List<string> ChannelIds { get; set; }

        [JsonPropertyName("params")]
        public string Params { get; set; }
    }

    public partial class UnsubscribeCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("unsubscribeEndpoint")]
        public SubscribeEndpoint UnsubscribeEndpoint { get; set; }
    }

    public partial class PlayerResponseResponseContext
    {
        [JsonPropertyName("serviceTrackingParams")]
        public List<ServiceTrackingParam> ServiceTrackingParams { get; set; }

        [JsonPropertyName("webResponseContextExtensionData")]
        public PurpleWebResponseContextExtensionData WebResponseContextExtensionData { get; set; }
    }

    public partial class ServiceTrackingParam
    {
        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("params")]
        public List<Param> Params { get; set; }
    }

    public partial class PurpleWebResponseContextExtensionData
    {
        [JsonPropertyName("ytConfigData")]
        public YtConfigData YtConfigData { get; set; }

        [JsonPropertyName("hasDecorated")]
        public bool HasDecorated { get; set; }
    }

    public partial class YtConfigData
    {
        [JsonPropertyName("visitorData")]
        public string VisitorData { get; set; }

        [JsonPropertyName("sessionIndex")]
        public long SessionIndex { get; set; }

        [JsonPropertyName("rootVisualElementType")]
        public long RootVisualElementType { get; set; }
    }

    public partial class Storyboards
    {
        [JsonPropertyName("playerStoryboardSpecRenderer")]
        public PlayerStoryboardSpecRenderer PlayerStoryboardSpecRenderer { get; set; }
    }

    public partial class PlayerStoryboardSpecRenderer
    {
        [JsonPropertyName("spec")]
        public Uri Spec { get; set; }
    }

    public partial class StreamingData
    {
        [JsonPropertyName("expiresInSeconds")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ExpiresInSeconds { get; set; }

        [JsonPropertyName("formats")]
        public List<Format> Formats { get; set; }

        [JsonPropertyName("adaptiveFormats")]
        public List<Format> AdaptiveFormats { get; set; }
    }

    public partial class Format
    {
        [JsonPropertyName("itag")]
        public long Itag { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        [JsonPropertyName("bitrate")]
        public long Bitrate { get; set; }

        [JsonPropertyName("width")]
        public long? Width { get; set; }

        [JsonPropertyName("height")]
        public long? Height { get; set; }

        [JsonPropertyName("initRange")]
        public Range InitRange { get; set; }

        [JsonPropertyName("indexRange")]
        public Range IndexRange { get; set; }

        [JsonPropertyName("lastModified")]
        public string LastModified { get; set; }

        [JsonPropertyName("contentLength")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? ContentLength { get; set; }

        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        [JsonPropertyName("fps")]
        public long? Fps { get; set; }

        [JsonPropertyName("qualityLabel")]
        public string QualityLabel { get; set; }

        [JsonPropertyName("projectionType")]
        public ProjectionType ProjectionType { get; set; }

        [JsonPropertyName("averageBitrate")]
        public long? AverageBitrate { get; set; }

        [JsonPropertyName("colorInfo")]
        public ColorInfo ColorInfo { get; set; }

        [JsonPropertyName("approxDurationMs")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ApproxDurationMs { get; set; }

        [JsonPropertyName("highReplication")]
        public bool? HighReplication { get; set; }

        [JsonPropertyName("audioQuality")]
        public string AudioQuality { get; set; }

        [JsonPropertyName("audioSampleRate")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? AudioSampleRate { get; set; }

        [JsonPropertyName("audioChannels")]
        public long? AudioChannels { get; set; }

        [JsonPropertyName("loudnessDb")]
        public double? LoudnessDb { get; set; }
    }

    public partial class ColorInfo
    {
        [JsonPropertyName("primaries")]
        public string Primaries { get; set; }

        [JsonPropertyName("transferCharacteristics")]
        public string TransferCharacteristics { get; set; }

        [JsonPropertyName("matrixCoefficients")]
        public string MatrixCoefficients { get; set; }
    }

    public partial class Range
    {
        [JsonPropertyName("start")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Start { get; set; }

        [JsonPropertyName("end")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long End { get; set; }
    }

    public partial class VideoDetails
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("lengthSeconds")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long LengthSeconds { get; set; }

        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("isOwnerViewing")]
        public bool IsOwnerViewing { get; set; }

        [JsonPropertyName("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonPropertyName("isCrawlable")]
        public bool IsCrawlable { get; set; }

        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("useCipher")]
        public bool UseCipher { get; set; }

        [JsonPropertyName("averageRating")]
        public long AverageRating { get; set; }

        [JsonPropertyName("allowRatings")]
        public bool AllowRatings { get; set; }

        [JsonPropertyName("viewCount")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ViewCount { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonPropertyName("isUnpluggedCorpus")]
        public bool IsUnpluggedCorpus { get; set; }

        [JsonPropertyName("isLiveContent")]
        public bool IsLiveContent { get; set; }
    }

    public partial class VideoQualityPromoSupportedRenderers
    {
        [JsonPropertyName("videoQualityPromoRenderer")]
        public VideoQualityPromoRenderer VideoQualityPromoRenderer { get; set; }
    }

    public partial class VideoQualityPromoRenderer
    {
        [JsonPropertyName("triggerCriteria")]
        public TriggerCriteria TriggerCriteria { get; set; }

        [JsonPropertyName("text")]
        public Text Text { get; set; }

        [JsonPropertyName("endpoint")]
        public ClickthroughEndpointClass Endpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("snackbar")]
        public Snackbar Snackbar { get; set; }
    }

    public partial class Snackbar
    {
        [JsonPropertyName("notificationActionRenderer")]
        public SnackbarNotificationActionRenderer NotificationActionRenderer { get; set; }
    }

    public partial class SnackbarNotificationActionRenderer
    {
        [JsonPropertyName("responseText")]
        public ResponseText ResponseText { get; set; }

        [JsonPropertyName("actionButton")]
        public NotificationActionRendererActionButton ActionButton { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class NotificationActionRendererActionButton
    {
        [JsonPropertyName("buttonRenderer")]
        public FluffyButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class FluffyButtonRenderer
    {
        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public ClickthroughEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Text
    {
        [JsonPropertyName("runs")]
        public List<PurpleRun> Runs { get; set; }
    }

    public partial class PurpleRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("bold")]
        public bool? Bold { get; set; }
    }

    public partial class TriggerCriteria
    {
        [JsonPropertyName("connectionWhitelist")]
        public List<string> ConnectionWhitelist { get; set; }

        [JsonPropertyName("joinLatencySeconds")]
        public long JoinLatencySeconds { get; set; }

        [JsonPropertyName("rebufferTimeSeconds")]
        public long RebufferTimeSeconds { get; set; }

        [JsonPropertyName("watchTimeWindowSeconds")]
        public long WatchTimeWindowSeconds { get; set; }

        [JsonPropertyName("refractorySeconds")]
        public long RefractorySeconds { get; set; }
    }

    public partial class Response
    {
        [JsonPropertyName("responseContext")]
        public ResponseResponseContext ResponseContext { get; set; }

        [JsonPropertyName("contents")]
        public Contents Contents { get; set; }

        [JsonPropertyName("currentVideoEndpoint")]
        public CurrentVideoEndpointClass CurrentVideoEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("playerOverlays")]
        public PlayerOverlays PlayerOverlays { get; set; }

        [JsonPropertyName("onResponseReceivedEndpoints")]
        public List<OnResponseReceivedEndpoint> OnResponseReceivedEndpoints { get; set; }

        [JsonPropertyName("topbar")]
        public Topbar Topbar { get; set; }

        [JsonPropertyName("frameworkUpdates")]
        public FrameworkUpdates FrameworkUpdates { get; set; }

        [JsonPropertyName("webWatchNextResponseExtensionData")]
        public WebWatchNextResponseExtensionData WebWatchNextResponseExtensionData { get; set; }
    }

    public partial class Contents
    {
        [JsonPropertyName("twoColumnWatchNextResults")]
        public TwoColumnWatchNextResults TwoColumnWatchNextResults { get; set; }
    }

    public partial class TwoColumnWatchNextResults
    {
        [JsonPropertyName("results")]
        public TwoColumnWatchNextResultsResults Results { get; set; }

        [JsonPropertyName("secondaryResults")]
        public TwoColumnWatchNextResultsSecondaryResults SecondaryResults { get; set; }

        [JsonPropertyName("autoplay")]
        public TwoColumnWatchNextResultsAutoplay Autoplay { get; set; }
    }

    public partial class TwoColumnWatchNextResultsAutoplay
    {
        [JsonPropertyName("autoplay")]
        public AutoplayAutoplay Autoplay { get; set; }
    }

    public partial class AutoplayAutoplay
    {
        [JsonPropertyName("sets")]
        public List<Set> Sets { get; set; }

        [JsonPropertyName("countDownSecs")]
        public long CountDownSecs { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Set
    {
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("autoplayVideo")]
        public NavigationEndpoint AutoplayVideo { get; set; }
    }

    public partial class NavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("watchEndpoint")]
        public AutoplayVideoWatchEndpoint WatchEndpoint { get; set; }
    }

    public partial class AutoplayVideoWatchEndpoint
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("params")]
        public string Params { get; set; }

        [JsonPropertyName("playerParams")]
        public string PlayerParams { get; set; }

        [JsonPropertyName("watchEndpointSupportedPrefetchConfig")]
        public WatchEndpointSupportedPrefetchConfig WatchEndpointSupportedPrefetchConfig { get; set; }
    }

    public partial class WatchEndpointSupportedPrefetchConfig
    {
        [JsonPropertyName("prefetchHintConfig")]
        public PrefetchHintConfig PrefetchHintConfig { get; set; }
    }

    public partial class PrefetchHintConfig
    {
        [JsonPropertyName("prefetchPriority")]
        public long PrefetchPriority { get; set; }

        [JsonPropertyName("countdownUiRelativeSecondsPrefetchCondition")]
        public long CountdownUiRelativeSecondsPrefetchCondition { get; set; }
    }

    public partial class TwoColumnWatchNextResultsResults
    {
        [JsonPropertyName("results")]
        public ResultsResults Results { get; set; }
    }

    public partial class ResultsResults
    {
        [JsonPropertyName("contents")]
        public List<ResultsContent> Contents { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class ResultsContent
    {
        [JsonPropertyName("videoPrimaryInfoRenderer")]
        public VideoPrimaryInfoRenderer VideoPrimaryInfoRenderer { get; set; }

        [JsonPropertyName("videoSecondaryInfoRenderer")]
        public VideoSecondaryInfoRenderer VideoSecondaryInfoRenderer { get; set; }

        [JsonPropertyName("itemSectionRenderer")]
        public ItemSectionRenderer ItemSectionRenderer { get; set; }
    }

    public partial class ItemSectionRenderer
    {
        [JsonPropertyName("continuations")]
        public List<Continuation> Continuations { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("sectionIdentifier")]
        public string SectionIdentifier { get; set; }
    }

    public partial class Continuation
    {
        [JsonPropertyName("nextContinuationData")]
        public NextContinuationData NextContinuationData { get; set; }
    }

    public partial class NextContinuationData
    {
        [JsonPropertyName("continuation")]
        public string Continuation { get; set; }

        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("label")]
        public ResponseText Label { get; set; }
    }

    public partial class VideoPrimaryInfoRenderer
    {
        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("viewCount")]
        public ViewCount ViewCount { get; set; }

        [JsonPropertyName("videoActions")]
        public VideoActions VideoActions { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("sentimentBar")]
        public SentimentBar SentimentBar { get; set; }

        [JsonPropertyName("superTitleLink")]
        public SuperTitleLink SuperTitleLink { get; set; }

        [JsonPropertyName("dateText")]
        public HeaderText DateText { get; set; }
    }

    public partial class SentimentBar
    {
        [JsonPropertyName("sentimentBarRenderer")]
        public SentimentBarRenderer SentimentBarRenderer { get; set; }
    }

    public partial class SentimentBarRenderer
    {
        [JsonPropertyName("percentIfIndifferent")]
        public long PercentIfIndifferent { get; set; }

        [JsonPropertyName("percentIfLiked")]
        public long PercentIfLiked { get; set; }

        [JsonPropertyName("percentIfDisliked")]
        public long PercentIfDisliked { get; set; }

        [JsonPropertyName("likeStatus")]
        public string LikeStatus { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }
    }

    public partial class SuperTitleLink
    {
        [JsonPropertyName("runs")]
        public List<SuperTitleLinkRun> Runs { get; set; }
    }

    public partial class SuperTitleLinkRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public SearchEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("loggingDirectives")]
        public LoggingDirectives LoggingDirectives { get; set; }
    }

    public partial class LoggingDirectives
    {
        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("visibility")]
        public Visibility Visibility { get; set; }
    }

    public partial class Visibility
    {
        [JsonPropertyName("types")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Types { get; set; }
    }

    public partial class SearchEndpointClass
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("searchEndpoint")]
        public SearchEndpoint SearchEndpoint { get; set; }

        [JsonPropertyName("urlEndpoint")]
        public SearchEndpointUrlEndpoint UrlEndpoint { get; set; }
    }

    public partial class SearchEndpoint
    {
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }

    public partial class SearchEndpointUrlEndpoint
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("target")]
        public Target Target { get; set; }

        [JsonPropertyName("nofollow")]
        public bool Nofollow { get; set; }
    }

    public partial class VideoActions
    {
        [JsonPropertyName("menuRenderer")]
        public VideoActionsMenuRenderer MenuRenderer { get; set; }
    }

    public partial class VideoActionsMenuRenderer
    {
        [JsonPropertyName("items")]
        public List<PurpleItem> Items { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("topLevelButtons")]
        public List<TopLevelButton> TopLevelButtons { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }
    }

    public partial class PurpleItem
    {
        [JsonPropertyName("menuServiceItemRenderer")]
        public PurpleMenuServiceItemRenderer MenuServiceItemRenderer { get; set; }
    }

    public partial class PurpleMenuServiceItemRenderer
    {
        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public FluffyServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class FluffyServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("getReportFormEndpoint")]
        public GetReportFormEndpoint GetReportFormEndpoint { get; set; }
    }

    public partial class GetReportFormEndpoint
    {
        [JsonPropertyName("params")]
        public string Params { get; set; }
    }

    public partial class TopLevelButton
    {
        [JsonPropertyName("toggleButtonRenderer")]
        public ToggleButtonRenderer ToggleButtonRenderer { get; set; }

        [JsonPropertyName("buttonRenderer")]
        public TopLevelButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class TopLevelButtonButtonRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public TentacledServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("accessibility")]
        public AccessibilityAccessibility Accessibility { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibilityData")]
        public ToggledAccessibilityClass AccessibilityData { get; set; }
    }

    public partial class TentacledServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("shareEntityServiceEndpoint")]
        public ShareEntityServiceEndpoint ShareEntityServiceEndpoint { get; set; }

        [JsonPropertyName("addToPlaylistServiceEndpoint")]
        public WatchEndpoint AddToPlaylistServiceEndpoint { get; set; }
    }

    public partial class ShareEntityServiceEndpoint
    {
        [JsonPropertyName("serializedShareEntity")]
        public string SerializedShareEntity { get; set; }

        [JsonPropertyName("commands")]
        public List<ShareEntityServiceEndpointCommand> Commands { get; set; }
    }

    public partial class ShareEntityServiceEndpointCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("openPopupAction")]
        public CommandOpenPopupAction OpenPopupAction { get; set; }
    }

    public partial class CommandOpenPopupAction
    {
        [JsonPropertyName("popup")]
        public PurplePopup Popup { get; set; }

        [JsonPropertyName("popupType")]
        public string PopupType { get; set; }

        [JsonPropertyName("beReused")]
        public bool BeReused { get; set; }
    }

    public partial class PurplePopup
    {
        [JsonPropertyName("unifiedSharePanelRenderer")]
        public UnifiedSharePanelRenderer UnifiedSharePanelRenderer { get; set; }
    }

    public partial class UnifiedSharePanelRenderer
    {
        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("showLoadingSpinner")]
        public bool ShowLoadingSpinner { get; set; }
    }

    public partial class ToggleButtonRenderer
    {
        [JsonPropertyName("style")]
        public StyleClass Style { get; set; }

        [JsonPropertyName("isToggled")]
        public bool IsToggled { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonPropertyName("defaultIcon")]
        public IconImage DefaultIcon { get; set; }

        [JsonPropertyName("defaultText")]
        public ResponseTextClass DefaultText { get; set; }

        [JsonPropertyName("defaultServiceEndpoint")]
        public DefaultServiceEndpoint DefaultServiceEndpoint { get; set; }

        [JsonPropertyName("toggledText")]
        public ResponseTextClass ToggledText { get; set; }

        [JsonPropertyName("toggledServiceEndpoint")]
        public ToggledServiceEndpoint ToggledServiceEndpoint { get; set; }

        [JsonPropertyName("accessibility")]
        public AccessibilityAccessibility Accessibility { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("defaultTooltip")]
        public string DefaultTooltip { get; set; }

        [JsonPropertyName("toggledTooltip")]
        public string ToggledTooltip { get; set; }

        [JsonPropertyName("toggledStyle")]
        public StyleClass ToggledStyle { get; set; }

        [JsonPropertyName("accessibilityData")]
        public ToggledAccessibilityClass AccessibilityData { get; set; }

        [JsonPropertyName("toggleButtonSupportedData")]
        public ToggleButtonSupportedData ToggleButtonSupportedData { get; set; }

        [JsonPropertyName("targetId")]
        public string TargetId { get; set; }
    }

    public partial class DefaultServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("likeEndpoint")]
        public DefaultServiceEndpointLikeEndpoint LikeEndpoint { get; set; }
    }

    public partial class DefaultServiceEndpointLikeEndpoint
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("target")]
        public WatchEndpoint Target { get; set; }

        [JsonPropertyName("likeParams")]
        public string LikeParams { get; set; }

        [JsonPropertyName("dislikeParams")]
        public string DislikeParams { get; set; }
    }

    public partial class StyleClass
    {
        [JsonPropertyName("styleType")]
        public string StyleType { get; set; }
    }

    public partial class ToggleButtonSupportedData
    {
        [JsonPropertyName("toggleButtonIdData")]
        public ToggleButtonIdData ToggleButtonIdData { get; set; }
    }

    public partial class ToggleButtonIdData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public partial class ToggledServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("likeEndpoint")]
        public ToggledServiceEndpointLikeEndpoint LikeEndpoint { get; set; }
    }

    public partial class ToggledServiceEndpointLikeEndpoint
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("target")]
        public WatchEndpoint Target { get; set; }

        [JsonPropertyName("removeLikeParams")]
        public string RemoveLikeParams { get; set; }
    }

    public partial class ViewCount
    {
        [JsonPropertyName("videoViewCountRenderer")]
        public VideoViewCountRenderer VideoViewCountRenderer { get; set; }
    }

    public partial class VideoViewCountRenderer
    {
        [JsonPropertyName("viewCount")]
        public HeaderText ViewCount { get; set; }

        [JsonPropertyName("shortViewCount")]
        public HeaderText ShortViewCount { get; set; }
    }

    public partial class VideoSecondaryInfoRenderer
    {
        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("description")]
        public SuperTitleLink Description { get; set; }

        [JsonPropertyName("subscribeButton")]
        public SubscribeButtonClass SubscribeButton { get; set; }

        [JsonPropertyName("metadataRowContainer")]
        public MetadataRowContainer MetadataRowContainer { get; set; }

        [JsonPropertyName("showMoreText")]
        public ResponseText ShowMoreText { get; set; }

        [JsonPropertyName("showLessText")]
        public ResponseText ShowLessText { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("defaultExpanded")]
        public bool DefaultExpanded { get; set; }

        [JsonPropertyName("descriptionCollapsedLines")]
        public long DescriptionCollapsedLines { get; set; }
    }

    public partial class MetadataRowContainer
    {
        [JsonPropertyName("metadataRowContainerRenderer")]
        public MetadataRowContainerRenderer MetadataRowContainerRenderer { get; set; }
    }

    public partial class MetadataRowContainerRenderer
    {
        [JsonPropertyName("collapsedItemCount")]
        public long CollapsedItemCount { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Owner
    {
        [JsonPropertyName("videoOwnerRenderer")]
        public VideoOwnerRenderer VideoOwnerRenderer { get; set; }
    }

    public partial class VideoOwnerRenderer
    {
        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("title")]
        public VideoOwnerRendererTitle Title { get; set; }

        [JsonPropertyName("subscriptionButton")]
        public MuteAdEndpoint SubscriptionButton { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public VideoOwnerRendererNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("subscriberCountText")]
        public ResponseText SubscriberCountText { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("analyticsButton")]
        public SubscribeButtonClass AnalyticsButton { get; set; }
    }

    public partial class SubscribeButtonClass
    {
        [JsonPropertyName("buttonRenderer")]
        public SubscribeButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class SubscribeButtonButtonRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonPropertyName("text")]
        public HeaderText Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public TentacledNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class TentacledNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("urlEndpoint")]
        public UrlEndpointElement UrlEndpoint { get; set; }
    }

    public partial class VideoOwnerRendererNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("browseEndpoint")]
        public PurpleBrowseEndpoint BrowseEndpoint { get; set; }
    }

    public partial class PurpleBrowseEndpoint
    {
        [JsonPropertyName("browseId")]
        public string BrowseId { get; set; }

        [JsonPropertyName("canonicalBaseUrl")]
        public string CanonicalBaseUrl { get; set; }
    }

    public partial class VideoOwnerRendererTitle
    {
        [JsonPropertyName("runs")]
        public List<FluffyRun> Runs { get; set; }
    }

    public partial class FluffyRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public CollaboratorInfoCardContentRendererEndpoint NavigationEndpoint { get; set; }
    }

    public partial class TwoColumnWatchNextResultsSecondaryResults
    {
        [JsonPropertyName("secondaryResults")]
        public SecondaryResultsSecondaryResults SecondaryResults { get; set; }
    }

    public partial class SecondaryResultsSecondaryResults
    {
        [JsonPropertyName("results")]
        public List<SecondaryResultsResult> Results { get; set; }

        [JsonPropertyName("continuations")]
        public List<Continuation> Continuations { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class SecondaryResultsResult
    {
        [JsonPropertyName("compactAutoplayRenderer")]
        public CompactAutoplayRenderer CompactAutoplayRenderer { get; set; }

        [JsonPropertyName("compactVideoRenderer")]
        public ResultCompactVideoRenderer CompactVideoRenderer { get; set; }
    }

    public partial class CompactAutoplayRenderer
    {
        [JsonPropertyName("title")]
        public HeaderText Title { get; set; }

        [JsonPropertyName("toggleDescription")]
        public ResponseText ToggleDescription { get; set; }

        [JsonPropertyName("infoIcon")]
        public IconImage InfoIcon { get; set; }

        [JsonPropertyName("infoText")]
        public ResponseText InfoText { get; set; }

        [JsonPropertyName("contents")]
        public List<CompactAutoplayRendererContent> Contents { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class CompactAutoplayRendererContent
    {
        [JsonPropertyName("compactVideoRenderer")]
        public ContentCompactVideoRenderer CompactVideoRenderer { get; set; }
    }

    public partial class ContentCompactVideoRenderer
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("title")]
        public ResponseTextClass Title { get; set; }

        [JsonPropertyName("longBylineText")]
        public Byline LongBylineText { get; set; }

        [JsonPropertyName("publishedTimeText")]
        public HeaderText PublishedTimeText { get; set; }

        [JsonPropertyName("viewCountText")]
        public HeaderText ViewCountText { get; set; }

        [JsonPropertyName("lengthText")]
        public ResponseTextClass LengthText { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public StickyNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("shortBylineText")]
        public Byline ShortBylineText { get; set; }

        [JsonPropertyName("channelThumbnail")]
        public BackgroundClass ChannelThumbnail { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("shortViewCountText")]
        public HeaderText ShortViewCountText { get; set; }

        [JsonPropertyName("menu")]
        public PurpleMenu Menu { get; set; }

        [JsonPropertyName("thumbnailOverlays")]
        public List<CompactVideoRendererThumbnailOverlay> ThumbnailOverlays { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("richThumbnail")]
        public RichThumbnail RichThumbnail { get; set; }
    }

    public partial class Byline
    {
        [JsonPropertyName("runs")]
        public List<BylineRun> Runs { get; set; }
    }

    public partial class BylineRun
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public VideoOwnerRendererNavigationEndpoint NavigationEndpoint { get; set; }
    }

    public partial class PurpleMenu
    {
        [JsonPropertyName("menuRenderer")]
        public PurpleMenuRenderer MenuRenderer { get; set; }
    }

    public partial class PurpleMenuRenderer
    {
        [JsonPropertyName("items")]
        public List<FluffyItem> Items { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }
    }

    public partial class FluffyItem
    {
        [JsonPropertyName("menuServiceItemRenderer")]
        public FluffyMenuServiceItemRenderer MenuServiceItemRenderer { get; set; }
    }

    public partial class FluffyMenuServiceItemRenderer
    {
        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public StickyServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("hasSeparator")]
        public bool? HasSeparator { get; set; }
    }

    public partial class StickyServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public PurpleSignalServiceEndpoint SignalServiceEndpoint { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public AddToWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }

        [JsonPropertyName("addToPlaylistServiceEndpoint")]
        public WatchEndpoint AddToPlaylistServiceEndpoint { get; set; }

        [JsonPropertyName("feedbackEndpoint")]
        public PurpleFeedbackEndpoint FeedbackEndpoint { get; set; }

        [JsonPropertyName("getReportFormEndpoint")]
        public GetReportFormEndpoint GetReportFormEndpoint { get; set; }
    }

    public partial class PurpleFeedbackEndpoint
    {
        [JsonPropertyName("feedbackToken")]
        public string FeedbackToken { get; set; }

        [JsonPropertyName("uiActions")]
        public UiActions UiActions { get; set; }

        [JsonPropertyName("actions")]
        public List<OnResponseReceivedEndpoint> Actions { get; set; }
    }

    public partial class OnResponseReceivedEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("replaceEnclosingAction")]
        public ReplaceEnclosingAction ReplaceEnclosingAction { get; set; }

        [JsonPropertyName("commandMetadata")]
        public OnResponseReceivedEndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public OnResponseReceivedEndpointSignalServiceEndpoint SignalServiceEndpoint { get; set; }
    }

    public partial class OnResponseReceivedEndpointCommandMetadata
    {
        [JsonPropertyName("webCommandMetadata")]
        public StickyWebCommandMetadata WebCommandMetadata { get; set; }
    }

    public partial class StickyWebCommandMetadata
    {
        [JsonPropertyName("url")]
        public UrlEnum Url { get; set; }

        [JsonPropertyName("sendPost")]
        public bool SendPost { get; set; }
    }

    public partial class ReplaceEnclosingAction
    {
        [JsonPropertyName("item")]
        public ReplaceEnclosingActionItem Item { get; set; }
    }

    public partial class ReplaceEnclosingActionItem
    {
        [JsonPropertyName("notificationMultiActionRenderer")]
        public NotificationMultiActionRenderer NotificationMultiActionRenderer { get; set; }
    }

    public partial class NotificationMultiActionRenderer
    {
        [JsonPropertyName("responseText")]
        public ResponseTextClass ResponseText { get; set; }

        [JsonPropertyName("buttons")]
        public List<ButtonElement> Buttons { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class ButtonElement
    {
        [JsonPropertyName("buttonRenderer")]
        public TentacledButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class TentacledButtonRenderer
    {
        [JsonPropertyName("style")]
        public FluffyStyle Style { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public IndigoServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class IndigoServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("undoFeedbackEndpoint")]
        public UndoFeedbackEndpoint UndoFeedbackEndpoint { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public OnResponseReceivedEndpointSignalServiceEndpoint SignalServiceEndpoint { get; set; }
    }

    public partial class OnResponseReceivedEndpointSignalServiceEndpoint
    {
        [JsonPropertyName("signal")]
        public SignalEnum Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<TentacledAction> Actions { get; set; }
    }

    public partial class TentacledAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("signalAction")]
        public Signal SignalAction { get; set; }
    }

    public partial class Signal
    {
        [JsonPropertyName("signal")]
        public string SignalSignal { get; set; }
    }

    public partial class UndoFeedbackEndpoint
    {
        [JsonPropertyName("undoToken")]
        public string UndoToken { get; set; }

        [JsonPropertyName("actions")]
        public List<UndoFeedbackEndpointAction> Actions { get; set; }
    }

    public partial class UndoFeedbackEndpointAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("undoFeedbackAction")]
        public PingingEndpoint UndoFeedbackAction { get; set; }
    }

    public partial class UiActions
    {
        [JsonPropertyName("hideEnclosingContainer")]
        public bool HideEnclosingContainer { get; set; }
    }

    public partial class PurpleSignalServiceEndpoint
    {
        [JsonPropertyName("signal")]
        public SignalEnum Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<StickyAction> Actions { get; set; }
    }

    public partial class StickyAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("addToPlaylistCommand")]
        public AddToPlaylistCommand AddToPlaylistCommand { get; set; }

        [JsonPropertyName("openPopupAction")]
        public PurpleOpenPopupAction OpenPopupAction { get; set; }
    }

    public partial class AddToPlaylistCommand
    {
        [JsonPropertyName("openMiniplayer")]
        public bool OpenMiniplayer { get; set; }

        [JsonPropertyName("openListPanel")]
        public bool OpenListPanel { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("listType")]
        public ListType ListType { get; set; }

        [JsonPropertyName("onCreateListCommand")]
        public OnCreateListCommand OnCreateListCommand { get; set; }

        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }
    }

    public partial class OnCreateListCommand
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("createPlaylistServiceEndpoint")]
        public CreatePlaylistServiceEndpoint CreatePlaylistServiceEndpoint { get; set; }
    }

    public partial class CreatePlaylistServiceEndpoint
    {
        [JsonPropertyName("videoIds")]
        public List<string> VideoIds { get; set; }

        [JsonPropertyName("params")]
        public Params Params { get; set; }
    }

    public partial class PurpleOpenPopupAction
    {
        [JsonPropertyName("popup")]
        public FluffyPopup Popup { get; set; }

        [JsonPropertyName("popupType")]
        public PopupType PopupType { get; set; }
    }

    public partial class FluffyPopup
    {
        [JsonPropertyName("notificationActionRenderer")]
        public PopupNotificationActionRenderer NotificationActionRenderer { get; set; }
    }

    public partial class PopupNotificationActionRenderer
    {
        [JsonPropertyName("responseText")]
        public HeaderText ResponseText { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class StickyNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("watchEndpoint")]
        public PurpleWatchEndpoint WatchEndpoint { get; set; }
    }

    public partial class PurpleWatchEndpoint
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("nofollow")]
        public bool Nofollow { get; set; }
    }

    public partial class RichThumbnail
    {
        [JsonPropertyName("movingThumbnailRenderer")]
        public MovingThumbnailRenderer MovingThumbnailRenderer { get; set; }
    }

    public partial class MovingThumbnailRenderer
    {
        [JsonPropertyName("movingThumbnailDetails")]
        public MovingThumbnailDetails MovingThumbnailDetails { get; set; }

        [JsonPropertyName("enableHoveredLogging")]
        public bool EnableHoveredLogging { get; set; }

        [JsonPropertyName("enableOverlay")]
        public bool EnableOverlay { get; set; }
    }

    public partial class MovingThumbnailDetails
    {
        [JsonPropertyName("thumbnails")]
        public List<ChannelAvatarThumbnail> Thumbnails { get; set; }

        [JsonPropertyName("logAsMovingThumbnail")]
        public bool LogAsMovingThumbnail { get; set; }
    }

    public partial class CompactVideoRendererThumbnailOverlay
    {
        [JsonPropertyName("thumbnailOverlayResumePlaybackRenderer")]
        public ThumbnailOverlayResumePlaybackRenderer ThumbnailOverlayResumePlaybackRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayTimeStatusRenderer")]
        public ThumbnailOverlayTimeStatusRenderer ThumbnailOverlayTimeStatusRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayToggleButtonRenderer")]
        public ThumbnailOverlayToggleButtonRenderer ThumbnailOverlayToggleButtonRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayNowPlayingRenderer")]
        public ThumbnailOverlayNowPlayingRenderer ThumbnailOverlayNowPlayingRenderer { get; set; }
    }

    public partial class ThumbnailOverlayNowPlayingRenderer
    {
        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }
    }

    public partial class ThumbnailOverlayResumePlaybackRenderer
    {
        [JsonPropertyName("percentDurationWatched")]
        public long PercentDurationWatched { get; set; }
    }

    public partial class ThumbnailOverlayTimeStatusRenderer
    {
        [JsonPropertyName("text")]
        public ResponseTextClass Text { get; set; }

        [JsonPropertyName("style")]
        public ThumbnailOverlayTimeStatusRendererStyle Style { get; set; }
    }

    public partial class ThumbnailOverlayToggleButtonRenderer
    {
        [JsonPropertyName("isToggled")]
        public bool? IsToggled { get; set; }

        [JsonPropertyName("untoggledIcon")]
        public IconImage UntoggledIcon { get; set; }

        [JsonPropertyName("toggledIcon")]
        public IconImage ToggledIcon { get; set; }

        [JsonPropertyName("untoggledTooltip")]
        public UntoggledTooltip UntoggledTooltip { get; set; }

        [JsonPropertyName("toggledTooltip")]
        public ToggledTooltip ToggledTooltip { get; set; }

        [JsonPropertyName("untoggledServiceEndpoint")]
        public UntoggledServiceEndpoint UntoggledServiceEndpoint { get; set; }

        [JsonPropertyName("toggledServiceEndpoint")]
        public RemoveFromWatchLaterCommand ToggledServiceEndpoint { get; set; }

        [JsonPropertyName("untoggledAccessibility")]
        public ToggledAccessibilityClass UntoggledAccessibility { get; set; }

        [JsonPropertyName("toggledAccessibility")]
        public ToggledAccessibilityClass ToggledAccessibility { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class UntoggledServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public AddToWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public UntoggledServiceEndpointSignalServiceEndpoint SignalServiceEndpoint { get; set; }
    }

    public partial class UntoggledServiceEndpointSignalServiceEndpoint
    {
        [JsonPropertyName("signal")]
        public SignalEnum Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<IndigoAction> Actions { get; set; }
    }

    public partial class IndigoAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("addToPlaylistCommand")]
        public AddToPlaylistCommand AddToPlaylistCommand { get; set; }
    }

    public partial class ResultCompactVideoRenderer
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("title")]
        public ResponseTextClass Title { get; set; }

        [JsonPropertyName("longBylineText")]
        public Byline LongBylineText { get; set; }

        [JsonPropertyName("publishedTimeText")]
        public HeaderText PublishedTimeText { get; set; }

        [JsonPropertyName("viewCountText")]
        public HeaderText ViewCountText { get; set; }

        [JsonPropertyName("lengthText")]
        public ResponseTextClass LengthText { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public IndigoNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("shortBylineText")]
        public Byline ShortBylineText { get; set; }

        [JsonPropertyName("channelThumbnail")]
        public BackgroundClass ChannelThumbnail { get; set; }

        [JsonPropertyName("ownerBadges")]
        public List<OwnerBadge> OwnerBadges { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }

        [JsonPropertyName("shortViewCountText")]
        public HeaderText ShortViewCountText { get; set; }

        [JsonPropertyName("menu")]
        public FluffyMenu Menu { get; set; }

        [JsonPropertyName("thumbnailOverlays")]
        public List<CompactVideoRendererThumbnailOverlay> ThumbnailOverlays { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("richThumbnail")]
        public RichThumbnail RichThumbnail { get; set; }

        [JsonPropertyName("badges")]
        public List<Badge> Badges { get; set; }
    }

    public partial class Badge
    {
        [JsonPropertyName("metadataBadgeRenderer")]
        public BadgeMetadataBadgeRenderer MetadataBadgeRenderer { get; set; }
    }

    public partial class BadgeMetadataBadgeRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class FluffyMenu
    {
        [JsonPropertyName("menuRenderer")]
        public FluffyMenuRenderer MenuRenderer { get; set; }
    }

    public partial class FluffyMenuRenderer
    {
        [JsonPropertyName("items")]
        public List<TentacledItem> Items { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("targetId")]
        public string TargetId { get; set; }
    }

    public partial class TentacledItem
    {
        [JsonPropertyName("menuServiceItemRenderer")]
        public TentacledMenuServiceItemRenderer MenuServiceItemRenderer { get; set; }
    }

    public partial class TentacledMenuServiceItemRenderer
    {
        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("serviceEndpoint")]
        public IndecentServiceEndpoint ServiceEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("hasSeparator")]
        public bool? HasSeparator { get; set; }
    }

    public partial class IndecentServiceEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public PurpleSignalServiceEndpoint SignalServiceEndpoint { get; set; }

        [JsonPropertyName("playlistEditEndpoint")]
        public AddToWatchLaterCommandPlaylistEditEndpoint PlaylistEditEndpoint { get; set; }

        [JsonPropertyName("addToPlaylistServiceEndpoint")]
        public WatchEndpoint AddToPlaylistServiceEndpoint { get; set; }

        [JsonPropertyName("feedbackEndpoint")]
        public FluffyFeedbackEndpoint FeedbackEndpoint { get; set; }

        [JsonPropertyName("getReportFormEndpoint")]
        public GetReportFormEndpoint GetReportFormEndpoint { get; set; }
    }

    public partial class FluffyFeedbackEndpoint
    {
        [JsonPropertyName("feedbackToken")]
        public string FeedbackToken { get; set; }

        [JsonPropertyName("uiActions")]
        public UiActions UiActions { get; set; }

        [JsonPropertyName("actions")]
        public List<FeedbackEndpointAction> Actions { get; set; }
    }

    public partial class FeedbackEndpointAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("replaceEnclosingAction")]
        public ReplaceEnclosingAction ReplaceEnclosingAction { get; set; }
    }

    public partial class IndigoNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("watchEndpoint")]
        public FluffyWatchEndpoint WatchEndpoint { get; set; }
    }

    public partial class FluffyWatchEndpoint
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("startTimeSeconds")]
        public long? StartTimeSeconds { get; set; }

        [JsonPropertyName("nofollow")]
        public bool Nofollow { get; set; }
    }

    public partial class OwnerBadge
    {
        [JsonPropertyName("metadataBadgeRenderer")]
        public OwnerBadgeMetadataBadgeRenderer MetadataBadgeRenderer { get; set; }
    }

    public partial class OwnerBadgeMetadataBadgeRenderer
    {
        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("style")]
        public MetadataBadgeRendererStyle Style { get; set; }

        [JsonPropertyName("tooltip")]
        public Tooltip Tooltip { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class FrameworkUpdates
    {
    }

    public partial class PlayerOverlays
    {
        [JsonPropertyName("playerOverlayRenderer")]
        public PlayerOverlayRenderer PlayerOverlayRenderer { get; set; }
    }

    public partial class PlayerOverlayRenderer
    {
        [JsonPropertyName("endScreen")]
        public EndScreen EndScreen { get; set; }

        [JsonPropertyName("autoplay")]
        public PlayerOverlayRendererAutoplay Autoplay { get; set; }
    }

    public partial class PlayerOverlayRendererAutoplay
    {
        [JsonPropertyName("playerOverlayAutoplayRenderer")]
        public PlayerOverlayAutoplayRenderer PlayerOverlayAutoplayRenderer { get; set; }
    }

    public partial class PlayerOverlayAutoplayRenderer
    {
        [JsonPropertyName("title")]
        public HeaderText Title { get; set; }

        [JsonPropertyName("videoTitle")]
        public HeaderText VideoTitle { get; set; }

        [JsonPropertyName("byline")]
        public Byline Byline { get; set; }

        [JsonPropertyName("cancelText")]
        public HeaderText CancelText { get; set; }

        [JsonPropertyName("pauseText")]
        public HeaderText PauseText { get; set; }

        [JsonPropertyName("background")]
        public BackgroundClass Background { get; set; }

        [JsonPropertyName("countDownSecs")]
        public long CountDownSecs { get; set; }

        [JsonPropertyName("nextButton")]
        public NextButton NextButton { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("preferImmediateRedirect")]
        public bool PreferImmediateRedirect { get; set; }

        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("publishedTimeText")]
        public HeaderText PublishedTimeText { get; set; }

        [JsonPropertyName("webShowNewAutonavCountdown")]
        public bool WebShowNewAutonavCountdown { get; set; }

        [JsonPropertyName("webShowBigThumbnailEndscreen")]
        public bool WebShowBigThumbnailEndscreen { get; set; }

        [JsonPropertyName("shortViewCountText")]
        public HeaderText ShortViewCountText { get; set; }
    }

    public partial class NextButton
    {
        [JsonPropertyName("buttonRenderer")]
        public NextButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class NextButtonButtonRenderer
    {
        [JsonPropertyName("navigationEndpoint")]
        public CurrentVideoEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("accessibility")]
        public AccessibilityAccessibility Accessibility { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class EndScreen
    {
        [JsonPropertyName("watchNextEndScreenRenderer")]
        public WatchNextEndScreenRenderer WatchNextEndScreenRenderer { get; set; }
    }

    public partial class WatchNextEndScreenRenderer
    {
        [JsonPropertyName("results")]
        public List<WatchNextEndScreenRendererResult> Results { get; set; }

        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class WatchNextEndScreenRendererResult
    {
        [JsonPropertyName("endScreenVideoRenderer")]
        public EndScreenVideoRenderer EndScreenVideoRenderer { get; set; }
    }

    public partial class EndScreenVideoRenderer
    {
        [JsonPropertyName("videoId")]
        public string VideoId { get; set; }

        [JsonPropertyName("thumbnail")]
        public BackgroundClass Thumbnail { get; set; }

        [JsonPropertyName("title")]
        public ResponseTextClass Title { get; set; }

        [JsonPropertyName("shortBylineText")]
        public Byline ShortBylineText { get; set; }

        [JsonPropertyName("lengthText")]
        public HeaderText LengthText { get; set; }

        [JsonPropertyName("lengthInSeconds")]
        public long LengthInSeconds { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public CurrentVideoEndpointClass NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("shortViewCountText")]
        public HeaderText ShortViewCountText { get; set; }

        [JsonPropertyName("publishedTimeText")]
        public HeaderText PublishedTimeText { get; set; }

        [JsonPropertyName("thumbnailOverlays")]
        public List<EndScreenVideoRendererThumbnailOverlay> ThumbnailOverlays { get; set; }
    }

    public partial class EndScreenVideoRendererThumbnailOverlay
    {
        [JsonPropertyName("thumbnailOverlayTimeStatusRenderer")]
        public ThumbnailOverlayTimeStatusRenderer ThumbnailOverlayTimeStatusRenderer { get; set; }

        [JsonPropertyName("thumbnailOverlayNowPlayingRenderer")]
        public ThumbnailOverlayNowPlayingRenderer ThumbnailOverlayNowPlayingRenderer { get; set; }
    }

    public partial class ResponseResponseContext
    {
        [JsonPropertyName("serviceTrackingParams")]
        public List<ServiceTrackingParam> ServiceTrackingParams { get; set; }

        [JsonPropertyName("webResponseContextExtensionData")]
        public FluffyWebResponseContextExtensionData WebResponseContextExtensionData { get; set; }
    }

    public partial class FluffyWebResponseContextExtensionData
    {
        [JsonPropertyName("ytConfigData")]
        public YtConfigData YtConfigData { get; set; }

        [JsonPropertyName("webPrefetchData")]
        public WebPrefetchData WebPrefetchData { get; set; }

        [JsonPropertyName("hasDecorated")]
        public bool HasDecorated { get; set; }
    }

    public partial class WebPrefetchData
    {
        [JsonPropertyName("navigationEndpoints")]
        public List<NavigationEndpoint> NavigationEndpoints { get; set; }
    }

    public partial class Topbar
    {
        [JsonPropertyName("desktopTopbarRenderer")]
        public DesktopTopbarRenderer DesktopTopbarRenderer { get; set; }
    }

    public partial class DesktopTopbarRenderer
    {
        [JsonPropertyName("logo")]
        public Logo Logo { get; set; }

        [JsonPropertyName("searchbox")]
        public Searchbox Searchbox { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("topbarButtons")]
        public List<TopbarButton> TopbarButtons { get; set; }

        [JsonPropertyName("hotkeyDialog")]
        public HotkeyDialog HotkeyDialog { get; set; }

        [JsonPropertyName("backButton")]
        public BackButtonClass BackButton { get; set; }

        [JsonPropertyName("forwardButton")]
        public BackButtonClass ForwardButton { get; set; }

        [JsonPropertyName("a11ySkipNavigationButton")]
        public A11YSkipNavigationButton A11YSkipNavigationButton { get; set; }
    }

    public partial class A11YSkipNavigationButton
    {
        [JsonPropertyName("buttonRenderer")]
        public A11YSkipNavigationButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class A11YSkipNavigationButtonButtonRenderer
    {
        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("size")]
        public Size Size { get; set; }

        [JsonPropertyName("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonPropertyName("text")]
        public ResponseText Text { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("command")]
        public OnResponseReceivedEndpoint Command { get; set; }
    }

    public partial class BackButtonClass
    {
        [JsonPropertyName("buttonRenderer")]
        public BackButtonButtonRenderer ButtonRenderer { get; set; }
    }

    public partial class BackButtonButtonRenderer
    {
        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("command")]
        public OnResponseReceivedEndpoint Command { get; set; }
    }

    public partial class HotkeyDialog
    {
        [JsonPropertyName("hotkeyDialogRenderer")]
        public HotkeyDialogRenderer HotkeyDialogRenderer { get; set; }
    }

    public partial class HotkeyDialogRenderer
    {
        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("sections")]
        public List<HotkeyDialogRendererSection> Sections { get; set; }

        [JsonPropertyName("dismissButton")]
        public DismissButton DismissButton { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class HotkeyDialogRendererSection
    {
        [JsonPropertyName("hotkeyDialogSectionRenderer")]
        public HotkeyDialogSectionRenderer HotkeyDialogSectionRenderer { get; set; }
    }

    public partial class HotkeyDialogSectionRenderer
    {
        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("options")]
        public List<Option> Options { get; set; }
    }

    public partial class Option
    {
        [JsonPropertyName("hotkeyDialogSectionOptionRenderer")]
        public HotkeyDialogSectionOptionRenderer HotkeyDialogSectionOptionRenderer { get; set; }
    }

    public partial class HotkeyDialogSectionOptionRenderer
    {
        [JsonPropertyName("label")]
        public ResponseText Label { get; set; }

        [JsonPropertyName("hotkey")]
        public string Hotkey { get; set; }

        [JsonPropertyName("hotkeyAccessibilityLabel")]
        public ToggledAccessibilityClass HotkeyAccessibilityLabel { get; set; }
    }

    public partial class Logo
    {
        [JsonPropertyName("topbarLogoRenderer")]
        public TopbarLogoRenderer TopbarLogoRenderer { get; set; }
    }

    public partial class TopbarLogoRenderer
    {
        [JsonPropertyName("iconImage")]
        public IconImage IconImage { get; set; }

        [JsonPropertyName("tooltipText")]
        public ResponseText TooltipText { get; set; }

        [JsonPropertyName("endpoint")]
        public CollaboratorInfoCardContentRendererEndpoint Endpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class Searchbox
    {
        [JsonPropertyName("fusionSearchboxRenderer")]
        public FusionSearchboxRenderer FusionSearchboxRenderer { get; set; }
    }

    public partial class FusionSearchboxRenderer
    {
        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("placeholderText")]
        public ResponseText PlaceholderText { get; set; }

        [JsonPropertyName("config")]
        public FusionSearchboxRendererConfig Config { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("searchEndpoint")]
        public SearchEndpointClass SearchEndpoint { get; set; }
    }

    public partial class FusionSearchboxRendererConfig
    {
        [JsonPropertyName("webSearchboxConfig")]
        public WebSearchboxConfig WebSearchboxConfig { get; set; }
    }

    public partial class WebSearchboxConfig
    {
        [JsonPropertyName("requestLanguage")]
        public string RequestLanguage { get; set; }

        [JsonPropertyName("requestDomain")]
        public string RequestDomain { get; set; }

        [JsonPropertyName("hasOnscreenKeyboard")]
        public bool HasOnscreenKeyboard { get; set; }

        [JsonPropertyName("focusSearchbox")]
        public bool FocusSearchbox { get; set; }
    }

    public partial class TopbarButton
    {
        [JsonPropertyName("topbarMenuButtonRenderer")]
        public TopbarMenuButtonRenderer TopbarMenuButtonRenderer { get; set; }

        [JsonPropertyName("notificationTopbarButtonRenderer")]
        public NotificationTopbarButtonRenderer NotificationTopbarButtonRenderer { get; set; }
    }

    public partial class NotificationTopbarButtonRenderer
    {
        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("menuRequest")]
        public MenuRequest MenuRequest { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("updateUnseenCountEndpoint")]
        public UpdateUnseenCountEndpoint UpdateUnseenCountEndpoint { get; set; }

        [JsonPropertyName("notificationCount")]
        public long NotificationCount { get; set; }

        [JsonPropertyName("handlerDatas")]
        public List<string> HandlerDatas { get; set; }
    }

    public partial class MenuRequest
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public MenuRequestSignalServiceEndpoint SignalServiceEndpoint { get; set; }
    }

    public partial class MenuRequestSignalServiceEndpoint
    {
        [JsonPropertyName("signal")]
        public string Signal { get; set; }

        [JsonPropertyName("actions")]
        public List<IndecentAction> Actions { get; set; }
    }

    public partial class IndecentAction
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("openPopupAction")]
        public FluffyOpenPopupAction OpenPopupAction { get; set; }
    }

    public partial class FluffyOpenPopupAction
    {
        [JsonPropertyName("popup")]
        public TentacledPopup Popup { get; set; }

        [JsonPropertyName("popupType")]
        public string PopupType { get; set; }

        [JsonPropertyName("beReused")]
        public bool BeReused { get; set; }
    }

    public partial class TentacledPopup
    {
        [JsonPropertyName("multiPageMenuRenderer")]
        public PopupMultiPageMenuRenderer MultiPageMenuRenderer { get; set; }
    }

    public partial class PopupMultiPageMenuRenderer
    {
        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("showLoadingSpinner")]
        public bool ShowLoadingSpinner { get; set; }
    }

    public partial class UpdateUnseenCountEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public AddToWatchLaterCommandCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("signalServiceEndpoint")]
        public Signal SignalServiceEndpoint { get; set; }
    }

    public partial class TopbarMenuButtonRenderer
    {
        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("menuRenderer")]
        public TopbarMenuButtonRendererMenuRenderer MenuRenderer { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }

        [JsonPropertyName("tooltip")]
        public string Tooltip { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }

        [JsonPropertyName("targetId")]
        public string TargetId { get; set; }

        [JsonPropertyName("avatar")]
        public Avatar Avatar { get; set; }

        [JsonPropertyName("menuRequest")]
        public MenuRequest MenuRequest { get; set; }
    }

    public partial class Avatar
    {
        [JsonPropertyName("thumbnails")]
        public List<ChannelAvatarThumbnail> Thumbnails { get; set; }

        [JsonPropertyName("accessibility")]
        public ToggledAccessibilityClass Accessibility { get; set; }
    }

    public partial class TopbarMenuButtonRendererMenuRenderer
    {
        [JsonPropertyName("multiPageMenuRenderer")]
        public MenuRendererMultiPageMenuRenderer MultiPageMenuRenderer { get; set; }
    }

    public partial class MenuRendererMultiPageMenuRenderer
    {
        [JsonPropertyName("sections")]
        public List<MultiPageMenuRendererSection> Sections { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }
    }

    public partial class MultiPageMenuRendererSection
    {
        [JsonPropertyName("multiPageMenuSectionRenderer")]
        public MultiPageMenuSectionRenderer MultiPageMenuSectionRenderer { get; set; }
    }

    public partial class MultiPageMenuSectionRenderer
    {
        [JsonPropertyName("items")]
        public List<MultiPageMenuSectionRendererItem> Items { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }
    }

    public partial class MultiPageMenuSectionRendererItem
    {
        [JsonPropertyName("compactLinkRenderer")]
        public CompactLinkRenderer CompactLinkRenderer { get; set; }
    }

    public partial class CompactLinkRenderer
    {
        [JsonPropertyName("icon")]
        public IconImage Icon { get; set; }

        [JsonPropertyName("title")]
        public ResponseText Title { get; set; }

        [JsonPropertyName("navigationEndpoint")]
        public CompactLinkRendererNavigationEndpoint NavigationEndpoint { get; set; }

        [JsonPropertyName("trackingParams")]
        public string TrackingParams { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }
    }

    public partial class CompactLinkRendererNavigationEndpoint
    {
        [JsonPropertyName("clickTrackingParams")]
        public string ClickTrackingParams { get; set; }

        [JsonPropertyName("commandMetadata")]
        public EndpointCommandMetadata CommandMetadata { get; set; }

        [JsonPropertyName("uploadEndpoint")]
        public PingingEndpoint UploadEndpoint { get; set; }

        [JsonPropertyName("signalNavigationEndpoint")]
        public Signal SignalNavigationEndpoint { get; set; }

        [JsonPropertyName("browseEndpoint")]
        public FluffyBrowseEndpoint BrowseEndpoint { get; set; }

        [JsonPropertyName("urlEndpoint")]
        public EndpointUrlEndpoint UrlEndpoint { get; set; }
    }

    public partial class FluffyBrowseEndpoint
    {
        [JsonPropertyName("browseId")]
        public string BrowseId { get; set; }

        [JsonPropertyName("params")]
        public string Params { get; set; }
    }

    public partial class WebWatchNextResponseExtensionData
    {
        [JsonPropertyName("relatedVideoArgs")]
        public string RelatedVideoArgs { get; set; }
    }

    public partial class Timing
    {
        [JsonPropertyName("info")]
        public Info Info { get; set; }
    }

    public partial class Info
    {
        [JsonPropertyName("st")]
        public long St { get; set; }
    }

    public enum WebPageType { WebPageTypeBrowse, WebPageTypeChannel, WebPageTypeSearch, WebPageTypeUnknown, WebPageTypeWatch };

    public enum Target { TargetNewWindow };

    public enum TypeEnum { Free, Hide, Skip, Undo };

    public enum Size { SizeDefault };

    public enum PurpleStyle { StyleUnknown };

    public enum UrlEnum { ServiceAjax };

    public enum HilariousAction { ActionAddVideo };

    public enum PlaylistId { Wl };

    public enum AmbitiousAction { ActionRemoveVideoByVideoId };

    public enum ProjectionType { Rectangular };

    public enum SignalEnum { ClientSignal };

    public enum FluffyStyle { StyleBlueText };

    public enum ListType { PlaylistEditListTypeQueue };

    public enum Params { Caq3D };

    public enum PopupType { Toast };

    public enum ThumbnailOverlayTimeStatusRendererStyle { Default };

    public enum ToggledTooltip { Added };

    public enum UntoggledTooltip { AddToQueue, WatchLater };

    public enum MetadataBadgeRendererStyle { BadgeStyleTypeVerified };

    public enum Tooltip { Verified };
}