using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppodealBinding
{
    static class CFunctions
    {
        // extern NSArray * AppodealAvailableUnitSizes ();
        [DllImport ("__Internal")]
        static extern NSObject[] AppodealAvailableUnitSizes ();

        // extern BOOL AppodealIsUnitSizeSupported (const CGSize size, NSArray *supportedSizes);
        [DllImport ("__Internal")]
        static extern bool AppodealIsUnitSizeSupported (CGSize size, NSObject[] supportedSizes);

        // extern BOOL AppodealIsUnitSizeAvailable (const CGSize size);
        [DllImport ("__Internal")]
        static extern bool AppodealIsUnitSizeAvailable (CGSize size);

        // extern CGSize AppodealNearestUnitSizeForSize (CGSize size);
        [DllImport ("__Internal")]
        static extern CGSize AppodealNearestUnitSizeForSize (CGSize size);

        // extern BOOL APDIsAdSizeValid (const CGSize size);
        [DllImport ("__Internal")]
        static extern bool APDIsAdSizeValid (CGSize size);

        // extern CGSize APDNearestValidAdSizeForCGSize (const CGSize size);
        [DllImport ("__Internal")]
        static extern CGSize APDNearestValidAdSizeForCGSize (CGSize size);

        // extern NSString * APDSdkVersionString ();
        [DllImport ("__Internal")]
        static extern NSString APDSdkVersionString ();
    }

    [Flags]
    [Native]
    public enum AppodealAdType : ulong
    {
        Interstitial = 1 << 0,
        SkippableVideo = 1 << 1,
        Banner = 1 << 2,
        NativeAd = 1 << 3,
        RewardedVideo = 1 << 4,
        Mrec = 1 << 5,
        NonSkippableVideo = 1 << 6
    }

    [Flags]
    [Native]
    public enum AppodealShowStyle : ulong
    {
        Interstitial = 1 << 0,
        SkippableVideo = Interstitial,
        VideoOrInterstitial = Interstitial,
        BannerTop = 1 << 2,
        BannerBottom = 1 << 3,
        RewardedVideo = 1 << 4,
        NonSkippableVideo = 1 << 5
    }

    [Native]
    public enum AppodealUserGender : ulong
    {
        Other = 0,
        Female,
        Male
    }

    [Native]
    public enum AppodealUserOccupation : ulong
    {
        Other = 0,
        Work,
        School,
        University
    }

    [Native]
    public enum AppodealUserRelationship : ulong
    {
        Other = 0,
        Single,
        Dating,
        Engaged,
        Married,
        Searching
    }

    [Native]
    public enum AppodealUserSmokingAttitude : ulong
    {
        Negative = 1,
        Neutral,
        Positive
    }

    [Native]
    public enum AppodealUserAlcoholAttitude : ulong
    {
        Negative = 1,
        Neutral,
        Positive
    }

    [Native]
    public enum APDError : ulong
    {
        UnknownError = 195944097,
        InternalInconsistencyError,
        NetworkingError,
        DeviceNotReachableError,
        JSONDecodeError,
        NoFillError,
        MediationError,
        PresentationError,
        InconsistencyPresentationError,
        InvalidAdSizeError,
        HandledExceptionError,
        InvalidAdTypeError,
        IncorrectAdUnitError,
        UnarchiveError,
        LowMemoryError
    }

    [Flags]
    [Native]
    public enum APDLogFlag : ulong
    {
        LogFlagError = 1 << 0,
        LogFlagWarning = 1 << 1,
        LogFlagInfo = 1 << 2,
        LogFlagDebug = 1 << 3,
        logFlagVerbose = 1 << 4
    }

    [Native]
    public enum APDLogLevel : ulong
    {
        Off = 0,
        Error = APDLogFlag.LogFlagError,
        Warning = Error | APDLogFlag.LogFlagWarning,
        Info = Warning | APDLogFlag.LogFlagInfo,
        Debug = Info | APDLogFlag.LogFlagDebug,
        Verbose = Debug | APDLogFlag.logFlagVerbose
    }

    [Flags]
    [Native]
    public enum APDType : ulong
    {
        InterstitialAd = 1 << 0,
        SkippableVideo = 1 << 1,
        Banner = 1 << 2,
        NativeAd = 1 << 3,
        RewardedVideo = 1 << 4,
        Mrec = 1 << 5
    }

    [Native]
    public enum APDNativeAdType : ulong
    {
        Auto = 0,
        Video,
        NoVideo
    }

    [Native]
    public enum APDUserGender : ulong
    {
        Other = 0,
        Female,
        Male
    }

    [Native]
    public enum APDUserOccupation : ulong
    {
        Other = 0,
        Work,
        School,
        University
    }

    [Native]
    public enum APDUserRelationship : ulong
    {
        Other = 0,
        Single,
        Dating,
        Engaged,
        Married,
        Searching
    }

    [Native]
    public enum APDUserSmokingAttitude : ulong
    {
        Negative = 1,
        Neutral,
        Positive
    }

    [Native]
    public enum APDUserAlcoholAttitude : ulong
    {
        Negative = 1,
        Neutral,
        Positive
    }

    [Native]
    public enum APDFramework : ulong
    {
        Native = 1,
        Unity,
        Cocos2d,
        Marmalade,
        PhoneGap,
        GiderosMobile,
        AdobeAir,
        Cordova,
        Xamarin,
        GameMaker,
        MonkeyX,
        Sc2,
        LibGDX,
        Qt,
        Ue4,
        ReactNative,
        Corona,
        Stencyl,
        SDKBox,
        Defold,
        BuildBox
    }

    [Native]
    public enum APDMediaViewType : ulong
    {
        MainImage = 0,
        Icon
    }

    [Native]
    public enum APDNativeComplainPosition : ulong
    {
        None = 0,
        Top,
        Center,
        Bottom
    }
}