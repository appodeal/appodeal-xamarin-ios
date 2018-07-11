using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AppodealBinding
{
    // @protocol APDBannerViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDBannerViewDelegate
    {
        // @optional -(void)bannerViewDidLoadAd:(APDBannerView *)bannerView;
        [Export("bannerViewDidLoadAd:")]
        void BannerViewDidLoadAd(APDBannerView bannerView);

        // @optional -(void)precacheBannerViewDidLoadAd:(APDBannerView *)precacheBannerView __attribute__((deprecated("Use -bannerViewDidLoadAd: instead")));
        [Export("precacheBannerViewDidLoadAd:")]
        void PrecacheBannerViewDidLoadAd(APDBannerView precacheBannerView);

        // @optional -(void)bannerViewDidShow:(APDBannerView *)bannerView;
        [Export("bannerViewDidShow:")]
        void BannerViewDidShow(APDBannerView bannerView);

        // @optional -(void)bannerViewDidRefresh:(APDBannerView *)bannerView __attribute__((deprecated("Use -bannerViewDidShow: instead")));
        [Export("bannerViewDidRefresh:")]
        void BannerViewDidRefresh(APDBannerView bannerView);

        // @optional -(void)bannerView:(APDBannerView *)bannerView didFailToLoadAdWithError:(NSError *)error;
        [Export("bannerView:didFailToLoadAdWithError:")]
        void BannerView(APDBannerView bannerView, NSError error);

        // @optional -(void)bannerViewDidReceiveTapAction:(APDBannerView *)bannerView;
        [Export("bannerViewDidReceiveTapAction:")]
        void BannerViewDidReceiveTapAction(APDBannerView bannerView);
    }

    // @interface APDBannerView : UIView
    [BaseType(typeof(UIView))]
    interface APDBannerView
    {
        [Wrap("WeakDelegate")]
        APDBannerViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDBannerViewDelegate> delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) UIViewController * rootViewController __attribute__((iboutlet));
        [Export("rootViewController", ArgumentSemantic.Weak)]
        UIViewController RootViewController { get; set; }

        // @property (copy, nonatomic) NSString * placement;
        [Export("placement")]
        string Placement { get; set; }

        // @property (assign, nonatomic) BOOL usesSmartSizing;
        [Export("usesSmartSizing")]
        bool UsesSmartSizing { get; set; }

        // @property (assign, nonatomic) BOOL autoRefreshing;
        [Export("autoRefreshing")]
        bool AutoRefreshing { get; set; }

        // @property (assign, nonatomic) CGSize adSize;
        [Export("adSize", ArgumentSemantic.Assign)]
        CGSize AdSize { get; set; }

        // @property (assign, nonatomic) UIViewAnimationOptions refreshAnimation;
        [Export("refreshAnimation", ArgumentSemantic.Assign)]
        UIViewAnimationOptions RefreshAnimation { get; set; }

        // @property (assign, nonatomic) BOOL backgroundVisible;
        [Export("backgroundVisible")]
        bool BackgroundVisible { get; set; }

        // @property (nonatomic, weak) APDSdk * customSdk;
        [Export("customSdk", ArgumentSemantic.Weak)]
        APDSdk CustomSdk { get; set; }

        // @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
        [Export("ready")]
        bool Ready { [Bind("isReady")] get; }

        // -(instancetype)initWithSize:(CGSize)adSize;
        [Export("initWithSize:")]
        IntPtr Constructor(CGSize adSize);

        // -(void)loadAd;
        [Export("loadAd")]
        void LoadAd();

        // -(void)rotateToOrientation:(UIInterfaceOrientation)orientation;
        [Export("rotateToOrientation:")]
        void RotateToOrientation(UIInterfaceOrientation orientation);
    }

    [Static]
    partial interface AppodealUnitSize
    {
        // extern const CGSize kAppodealUnitSize_320x50;
        [Field("kAppodealUnitSize_320x50", "__Internal")]
        CGSize kAppodealUnitSize_320x50 { get; }

        // extern const CGSize kAppodealUnitSize_300x250;
        [Field("kAppodealUnitSize_300x250", "__Internal")]
        CGSize kAppodealUnitSize_300x250 { get; }

        // extern const CGSize kAppodealUnitSize_728x90;
        [Field("kAppodealUnitSize_728x90", "__Internal")]
        CGSize kAppodealUnitSize_728x90 { get; }
    }

    // @protocol AppodealBannerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealBannerDelegate
    {
        // @optional -(void)bannerDidLoadAdIsPrecache:(BOOL)precache;
        [Export("bannerDidLoadAdIsPrecache:")]
        void BannerDidLoadAdIsPrecache(bool precache);

        // @optional -(void)bannerDidLoadAd __attribute__((deprecated("Use -bannerDidLoadAdisPrecache:precache: instead")));
        [Export("bannerDidLoadAd")]
        void BannerDidLoadAd();

        // @optional -(void)bannerDidRefresh __attribute__((deprecated("Use -bannerDidShow instead")));
        [Export("bannerDidRefresh")]
        void BannerDidRefresh();

        // @optional -(void)bannerDidFailToLoadAd;
        [Export("bannerDidFailToLoadAd")]
        void BannerDidFailToLoadAd();

        // @optional -(void)bannerDidClick;
        [Export("bannerDidClick")]
        void BannerDidClick();

        // @optional -(void)bannerDidShow;
        [Export("bannerDidShow")]
        void BannerDidShow();
    }

    // @protocol AppodealInterstitialDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealInterstitialDelegate
    {
        // @optional -(void)interstitialDidLoadAd __attribute__((deprecated("Use -interstitialDidLoadAdisPrecache: instead")));
        [Export("interstitialDidLoadAd")]
        void InterstitialDidLoadAd();

        // @optional -(void)interstitialDidLoadAdisPrecache:(BOOL)precache;
        [Export("interstitialDidLoadAdisPrecache:")]
        void InterstitialDidLoadAdisPrecache(bool precache);

        // @optional -(void)interstitialDidFailToLoadAd;
        [Export("interstitialDidFailToLoadAd")]
        void InterstitialDidFailToLoadAd();

        // @optional -(void)interstitialDidFailToPresent;
        [Export("interstitialDidFailToPresent")]
        void InterstitialDidFailToPresent();

        // @optional -(void)interstitialWillPresent;
        [Export("interstitialWillPresent")]
        void InterstitialWillPresent();

        // @optional -(void)interstitialDidDismiss;
        [Export("interstitialDidDismiss")]
        void InterstitialDidDismiss();

        // @optional -(void)interstitialDidClick;
        [Export("interstitialDidClick")]
        void InterstitialDidClick();
    }

    // @protocol AppodealRewardedVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealRewardedVideoDelegate
    {
        // @optional -(void)rewardedVideoDidLoadAd;
        [Export("rewardedVideoDidLoadAd")]
        void RewardedVideoDidLoadAd();

        // @optional -(void)rewardedVideoDidFailToLoadAd;
        [Export("rewardedVideoDidFailToLoadAd")]
        void RewardedVideoDidFailToLoadAd();

        // @optional -(void)rewardedVideoDidFailToPresent;
        [Export("rewardedVideoDidFailToPresent")]
        void RewardedVideoDidFailToPresent();

        // @optional -(void)rewardedVideoDidPresent;
        [Export("rewardedVideoDidPresent")]
        void RewardedVideoDidPresent();

        // @optional -(void)rewardedVideoWillDismiss;
        [Export("rewardedVideoWillDismiss")]
        void RewardedVideoWillDismiss();

        // @optional -(void)rewardedVideoDidFinish:(NSUInteger)rewardAmount name:(NSString *)rewardName;
        [Export("rewardedVideoDidFinish:name:")]
        void RewardedVideoDidFinish(nuint rewardAmount, string rewardName);

        // @optional -(void)rewardedVideoDidClick __attribute__((deprecated("Not all ad networks return this action")));
        [Export("rewardedVideoDidClick")]
        void RewardedVideoDidClick();
    }

    // @protocol AppodealNonSkippableVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealNonSkippableVideoDelegate
    {
        // @optional -(void)nonSkippableVideoDidLoadAd;
        [Export("nonSkippableVideoDidLoadAd")]
        void NonSkippableVideoDidLoadAd();

        // @optional -(void)nonSkippableVideoDidFailToLoadAd;
        [Export("nonSkippableVideoDidFailToLoadAd")]
        void NonSkippableVideoDidFailToLoadAd();

        // @optional -(void)nonSkippableVideoDidPresent;
        [Export("nonSkippableVideoDidPresent")]
        void NonSkippableVideoDidPresent();

        // @optional -(void)nonSkippableVideoDidFailToPresent;
        [Export("nonSkippableVideoDidFailToPresent")]
        void NonSkippableVideoDidFailToPresent();

        // @optional -(void)nonSkippableVideoWillDismiss;
        [Export("nonSkippableVideoWillDismiss")]
        void NonSkippableVideoWillDismiss();

        // @optional -(void)nonSkippableVideoDidFinish;
        [Export("nonSkippableVideoDidFinish")]
        void NonSkippableVideoDidFinish();

        // @optional -(void)nonSkippableVideoDidClick __attribute__((deprecated("Not all ad networks return this action")));
        [Export("nonSkippableVideoDidClick")]
        void NonSkippableVideoDidClick();
    }

    // @protocol AppodealSkippableVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealSkippableVideoDelegate
    {
        // @optional -(void)skippableVideoDidLoadAd;
        [Export("skippableVideoDidLoadAd")]
        void SkippableVideoDidLoadAd();

        // @optional -(void)skippableVideoDidFailToLoadAd;
        [Export("skippableVideoDidFailToLoadAd")]
        void SkippableVideoDidFailToLoadAd();

        // @optional -(void)skippableVideoDidPresent;
        [Export("skippableVideoDidPresent")]
        void SkippableVideoDidPresent();

        // @optional -(void)skippableVideoWillDismiss;
        [Export("skippableVideoWillDismiss")]
        void SkippableVideoWillDismiss();

        // @optional -(void)skippableVideoDidFinish;
        [Export("skippableVideoDidFinish")]
        void SkippableVideoDidFinish();

        // @optional -(void)skippableVideoDidClick;
        [Export("skippableVideoDidClick")]
        void SkippableVideoDidClick();
    }

    // @protocol AppodealNativeAdDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealNativeAdDelegate
    {
        // @required -(void)didLoadNativeAds:(NSInteger)count;
        [Abstract]
        [Export("didLoadNativeAds:")]
        void DidLoadNativeAds(nint count);

        // @required -(void)didFailToLoadNativeAdsWithError:(NSError *)error;
        [Abstract]
        [Export("didFailToLoadNativeAdsWithError:")]
        void DidFailToLoadNativeAdsWithError(NSError error);
    }

    [Static]
    partial interface APDAdSize
    {
        // extern const CGSize kAPDAdSize320x50;
        [Field("kAPDAdSize320x50", "__Internal")]
        CGSize kAPDAdSize320x50 { get; }

        // extern const CGSize kAPDAdSize728x90;
        [Field("kAPDAdSize728x90", "__Internal")]
        CGSize kAPDAdSize728x90 { get; }

        // extern const CGSize kAPDAdSize300x250;
        [Field("kAPDAdSize300x250", "__Internal")]
        CGSize kAPDAdSize300x250 { get; }

        // extern const CGSize kAPDImageSizeUndefined;
        [Field("kAPDImageSizeUndefined", "__Internal")]
        CGSize kAPDImageSizeUndefined { get; }

        // extern NSString *const kAPDErrorDomain;
        [Field("kAPDErrorDomain", "__Internal")]
        NSString kAPDErrorDomain { get; }
    }

    // @interface APDImage : NSObject
    [BaseType(typeof(NSObject))]
    interface APDImage
    {
        // @property (assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // @property (readonly, nonatomic, strong) NSURL * url;
        [Export("url", ArgumentSemantic.Strong)]
        NSUrl Url { get; }
    }

    // @protocol APDInterstitalAdDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDInterstitalAdDelegate
    {
        // @optional -(void)interstitialAdDidLoad:(APDInterstitialAd *)interstitialAd;
        [Export("interstitialAdDidLoad:")]
        void InterstitialAdDidLoad(APDInterstitialAd interstitialAd);

        // @optional -(void)precacheInterstitialAdDidLoad:(APDInterstitialAd *)precacheInterstitial;
        [Export("precacheInterstitialAdDidLoad:")]
        void PrecacheInterstitialAdDidLoad(APDInterstitialAd precacheInterstitial);

        // @optional -(void)interstitialAd:(APDInterstitialAd *)interstitialAd didFailToLoadWithError:(NSError *)error;
        [Export("interstitialAd:didFailToLoadWithError:")]
        void InterstitialAd(APDInterstitialAd interstitialAd, NSError error);

        // @optional -(void)interstitialAdDidAppear:(APDInterstitialAd *)interstitialAd;
        [Export("interstitialAdDidAppear:")]
        void InterstitialAdDidAppear(APDInterstitialAd interstitialAd);

        // @optional -(void)interstitialAdDidDisappear:(APDInterstitialAd *)interstitialAd;
        [Export("interstitialAdDidDisappear:")]
        void InterstitialAdDidDisappear(APDInterstitialAd interstitialAd);

        // @optional -(void)interstitialAd:(APDInterstitialAd *)interstitialAd didFailToPresentWithError:(NSError *)error;
        [Export("interstitialAd:didFailToPresentWithError:")]
        void InterstitialAdDidFailToPresentWithError(APDInterstitialAd interstitialAd, NSError error);

        // @optional -(void)interstitialAdDidRecieveTapAction:(APDInterstitialAd *)interstitialAd;
        [Export("interstitialAdDidRecieveTapAction:")]
        void InterstitialAdDidRecieveTapAction(APDInterstitialAd interstitialAd);
    }

    // @interface APDInterstitialAd : NSObject
    [BaseType(typeof(NSObject))]
    interface APDInterstitialAd
    {
        [Wrap("WeakDelegate")]
        APDInterstitalAdDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDInterstitalAdDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSString * placement;
        [Export("placement")]
        string Placement { get; set; }

        // @property (nonatomic, weak) APDSdk * customSdk;
        [Export("customSdk", ArgumentSemantic.Weak)]
        APDSdk CustomSdk { get; set; }

        // @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
        [Export("ready")]
        bool Ready { [Bind("isReady")] get; }

        // @property (readonly, assign, nonatomic) BOOL hasBeenPresented;
        [Export("hasBeenPresented")]
        bool HasBeenPresented { get; }

        // -(void)loadAd;
        [Export("loadAd")]
        void LoadAd();

        // -(void)presentFromViewController:(UIViewController *)viewController;
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);
    }

    // @protocol APDMediaViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDMediaViewDelegate
    {
        // @optional -(void)mediaViewStartPlaying:(APDMediaView *)mediaView;
        [Export("mediaViewStartPlaying:")]
        void MediaViewStartPlaying(APDMediaView mediaView);

        // @optional -(void)mediaViewFinishPlaying:(APDMediaView *)mediaView videoWasSkipped:(BOOL)wasSkipped;
        [Export("mediaViewFinishPlaying:videoWasSkipped:")]
        void MediaViewFinishPlaying(APDMediaView mediaView, bool wasSkipped);

        // @optional -(void)mediaView:(APDMediaView *)mediaView didPresentFullScreenView:(UIView *)presentedView;
        [Export("mediaView:didPresentFullScreenView:")]
        void MediaView(APDMediaView mediaView, UIView presentedView);

        // @optional -(void)mediaViewDidDismissFullScreen:(APDMediaView *)mediaView;
        [Export("mediaViewDidDismissFullScreen:")]
        void MediaViewDidDismissFullScreen(APDMediaView mediaView);
    }

    // @interface APDMediaView : UIView
    [BaseType(typeof(UIView))]
    interface APDMediaView
    {
        [Wrap("WeakDelegate")]
        APDMediaViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDMediaViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) APDMediaViewType type __attribute__((deprecated("Media View has APDMediaViewTypeMainImage type only!")));
        [Export("type", ArgumentSemantic.Assign)]
        APDMediaViewType Type { get; set; }

        // @property (assign, nonatomic) BOOL skippable __attribute__((deprecated("All native videos can be skipped by user")));
        [Export("skippable")]
        bool Skippable { get; set; }

        // @property (assign, nonatomic) BOOL muted __attribute__((deprecated("Contolled by user")));
        [Export("muted")]
        bool Muted { get; set; }

        // @property (assign, nonatomic) BOOL useDefaultMuteButton __attribute__((deprecated("Always YES")));
        [Export("useDefaultMuteButton")]
        bool UseDefaultMuteButton { get; set; }

        // -(void)setNativeAd:(APDNativeAd *)nativeAd rootViewController:(UIViewController *)controller;
        [Export("setNativeAd:rootViewController:")]
        void SetNativeAd(APDNativeAd nativeAd, UIViewController controller);

        // -(void)clearView;
        [Export("clearView")]
        void ClearView();
    }

    // @interface APDMRECView : APDBannerView
    [BaseType(typeof(APDBannerView))]
    interface APDMRECView
    {
    }

    // @protocol APDNativeAdPresentationDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDNativeAdPresentationDelegate
    {
        // @optional -(void)nativeAdWillLogImpression:(APDNativeAd *)nativeAd;
        [Export("nativeAdWillLogImpression:")]
        void NativeAdWillLogImpression(APDNativeAd nativeAd);

        // @optional -(void)nativeAdWillLogUserInteraction:(APDNativeAd *)nativeAd;
        [Export("nativeAdWillLogUserInteraction:")]
        void NativeAdWillLogUserInteraction(APDNativeAd nativeAd);
    }

    // @interface APDNativeAd : NSObject
    [BaseType(typeof(NSObject))]
    interface APDNativeAd
    {
        [Wrap("WeakDelegate")]
        APDNativeAdPresentationDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDNativeAdPresentationDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * subtitle;
        [Export("subtitle")]
        string Subtitle { get; }

        // @property (readonly, copy, nonatomic) NSString * descriptionText;
        [Export("descriptionText")]
        string DescriptionText { get; }

        // @property (readonly, copy, nonatomic) NSString * callToActionText;
        [Export("callToActionText")]
        string CallToActionText { get; }

        // @property (readonly, copy, nonatomic) NSString * contentRating;
        [Export("contentRating")]
        string ContentRating { get; }

        // @property (readonly, copy, nonatomic) NSNumber * starRating;
        [Export("starRating", ArgumentSemantic.Copy)]
        NSNumber StarRating { get; }

        // @property (readonly, copy, nonatomic) APDImage * mainImage;
        [Export("mainImage", ArgumentSemantic.Copy)]
        APDImage MainImage { get; }

        // @property (readonly, copy, nonatomic) APDImage * iconImage;
        [Export("iconImage", ArgumentSemantic.Copy)]
        APDImage IconImage { get; }

        // @property (readonly, nonatomic, strong) UIView * adChoicesView;
        [Export("adChoicesView", ArgumentSemantic.Strong)]
        UIView AdChoicesView { get; }

        // @property (readonly, getter = isContainsVideo, nonatomic) BOOL containsVideo;
        [Export("containsVideo")]
        bool ContainsVideo { [Bind("isContainsVideo")] get; }

        // -(void)attachToView:(UIView *)view viewController:(UIViewController *)viewController;
        [Export("attachToView:viewController:")]
        void AttachToView(UIView view, UIViewController viewController);

        // -(void)detachFromView;
        [Export("detachFromView")]
        void DetachFromView();

        // -(void)complainButtonPositon:(APDNativeComplainPosition)position;
        [Export("complainButtonPositon:")]
        void ComplainButtonPositon(APDNativeComplainPosition position);
    }

    // @protocol APDNativeAdRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDNativeAdRequestDelegate
    {
        // @optional -(void)nativeAdLoaderDidStartMediation:(APDNativeAdLoader *)nativeAdLoader;
        [Export("nativeAdLoaderDidStartMediation:")]
        void NativeAdLoaderDidStartMediation(APDNativeAdLoader nativeAdLoader);

        // @optional -(void)nativeAdLoader:(APDNativeAdLoader *)nativeAdLoader willSendRequestToAdNetwork:(NSString *)adNetwork;
        [Export("nativeAdLoader:willSendRequestToAdNetwork:")]
        void NativeAdLoader(APDNativeAdLoader nativeAdLoader, string adNetwork);

        // @optional -(void)nativeAdLoader:(APDNativeAdLoader *)nativeAdLoader didRecieveResponseFromAdNetwork:(NSString *)adNetwork wasFilled:(BOOL)filled;
        [Export("nativeAdLoader:didRecieveResponseFromAdNetwork:wasFilled:")]
        void NativeAdLoader(APDNativeAdLoader nativeAdLoader, string adNetwork, bool filled);

        // @optional -(void)nativeAdLoader:(APDNativeAdLoader *)nativeAdLoader didFinishMediationAdWasFilled:(BOOL)filled;
        [Export("nativeAdLoader:didFinishMediationAdWasFilled:")]
        void NativeAdLoader(APDNativeAdLoader nativeAdLoader, bool filled);
    }

    // @protocol APDNativeAdLoaderDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDNativeAdLoaderDelegate
    {
        // @required -(void)nativeAdLoader:(APDNativeAdLoader *)loader didLoadNativeAds:(NSArray<__kindof APDNativeAd *> *)nativeAds;
        [Abstract]
        [Export("nativeAdLoader:didLoadNativeAds:")]
        void DidLoadNativeAds(APDNativeAdLoader loader, APDNativeAd[] nativeAds);

        // @required -(void)nativeAdLoader:(APDNativeAdLoader *)loader didFailToLoadWithError:(NSError *)error;
        [Abstract]
        [Export("nativeAdLoader:didFailToLoadWithError:")]
        void DidFailToLoadWithError(APDNativeAdLoader loader, NSError error);
    }

    // @interface APDNativeAdLoader : NSObject
    [BaseType(typeof(NSObject))]
    interface APDNativeAdLoader
    {
        [Wrap("WeakRequestDelegate")]
        APDNativeAdRequestDelegate RequestDelegate { get; set; }

        // @property (nonatomic, weak) id<APDNativeAdRequestDelegate> requestDelegate;
        [NullAllowed, Export("requestDelegate", ArgumentSemantic.Weak)]
        NSObject WeakRequestDelegate { get; set; }

        [Wrap("WeakDelegate")]
        APDNativeAdLoaderDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDNativeAdLoaderDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSString * placement;
        [Export("placement")]
        string Placement { get; set; }

        // @property (nonatomic, weak) APDSdk * customSdk;
        [Export("customSdk", ArgumentSemantic.Weak)]
        APDSdk CustomSdk { get; set; }

        // -(void)loadAdWithType:(APDNativeAdType)type;
        [Export("loadAdWithType:")]
        void LoadAdWithType(APDNativeAdType type);

        // -(void)loadAdWithType:(APDNativeAdType)type capacity:(NSInteger)capacity;
        [Export("loadAdWithType:capacity:")]
        void LoadAdWithType(APDNativeAdType type, nint capacity);
    }

    // @protocol APDNativeAdQueueDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDNativeAdQueueDelegate
    {
        // @optional -(void)adQueueAdIsAvailable:(APDNativeAdQueue *)adQueue ofCount:(NSInteger)count;
        [Export("adQueueAdIsAvailable:ofCount:")]
        void AdQueueAdIsAvailable(APDNativeAdQueue adQueue, nint count);

        // @optional -(void)adQueue:(APDNativeAdQueue *)adQueue failedWithError:(NSError *)error;
        [Export("adQueue:failedWithError:")]
        void AdQueue(APDNativeAdQueue adQueue, NSError error);
    }

    // @interface APDNativeAdQueue : NSObject
    [BaseType(typeof(NSObject))]
    interface APDNativeAdQueue
    {
        [Wrap("WeakDelegate")]
        APDNativeAdQueueDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDNativeAdQueueDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, assign, nonatomic) NSInteger currentAdCount;
        [Export("currentAdCount")]
        nint CurrentAdCount { get; }

        // -(void)setMaxAdSize:(NSInteger)adSize;
        [Export("setMaxAdSize:")]
        void SetMaxAdSize(nint adSize);

        // -(void)loadAdOfType:(APDNativeAdType)type;
        [Export("loadAdOfType:")]
        void LoadAdOfType(APDNativeAdType type);

        // -(NSArray<__kindof APDNativeAd *> *)getNativeAdsOfCount:(NSInteger)count;
        [Export("getNativeAdsOfCount:")]
        APDNativeAd[] GetNativeAdsOfCount(nint count);
    }

    // @protocol APDRewardedVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDRewardedVideoDelegate
    {
        // @optional -(void)rewardedVideoDidLoad:(APDRewardedVideo *)rewardedVideo;
        [Export("rewardedVideoDidLoad:")]
        void RewardedVideoDidLoad(APDRewardedVideo rewardedVideo);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToLoadWithError:(NSError *)error;
        [Export("rewardedVideo:didFailToLoadWithError:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, NSError error);

        // @optional -(void)rewardedVideoDidBecomeUnavailable:(APDRewardedVideo *)rewardedVideo;
        [Export("rewardedVideoDidBecomeUnavailable:")]
        void RewardedVideoDidBecomeUnavailable(APDRewardedVideo rewardedVideo);

        // @optional -(void)rewardedVideoDidAppear:(APDRewardedVideo *)rewardedVideo;
        [Export("rewardedVideoDidAppear:")]
        void RewardedVideoDidAppear(APDRewardedVideo rewardedVideo);

        // @optional -(void)rewardedVideoDidDisappear:(APDRewardedVideo *)rewardedVideo;
        [Export("rewardedVideoDidDisappear:")]
        void RewardedVideoDidDisappear(APDRewardedVideo rewardedVideo);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFinishWithReward:(id<APDReward>)reward;
        [Export("rewardedVideo:didFinishWithReward:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, APDReward reward);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToPresentWithError:(NSError *)error;
        [Export("rewardedVideo:didFailToPresentWithError:")]
        void RewardedVideoDidFailToPresentWithError(APDRewardedVideo rewardedVideo, NSError error);
    }

    // @interface APDRewardedVideo : NSObject
    [BaseType(typeof(NSObject))]
    interface APDRewardedVideo
    {
        [Wrap("WeakDelegate")]
        APDRewardedVideoDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDRewardedVideoDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) id<APDReward> reward;
        [Export("reward", ArgumentSemantic.Strong)]
        APDReward Reward { get; }

        // @property (copy, nonatomic) NSString * placement;
        [Export("placement")]
        string Placement { get; set; }

        // @property (nonatomic, weak) APDSdk * customSdk;
        [Export("customSdk", ArgumentSemantic.Weak)]
        APDSdk CustomSdk { get; set; }

        // @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
        [Export("ready")]
        bool Ready { [Bind("isReady")] get; }

        // -(void)loadAd;
        [Export("loadAd")]
        void LoadAd();

        // -(void)presentFromViewController:(UIViewController *)viewController;
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);
    }

    // @protocol APDReward <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDReward
    {
        // @required @property (readonly, copy, nonatomic) NSString * currencyName;
        [Abstract]
        [Export("currencyName")]
        string CurrencyName { get; }

        // @required @property (readonly, assign, nonatomic) NSUInteger amount;
        [Abstract]
        [Export("amount")]
        nuint Amount { get; }
    }

    // @interface APDSdk : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface APDSdk
    {
        // +(instancetype)sharedSdkWithApiKey:(NSString *)apiKey;
        [Static]
        [Export("sharedSdkWithApiKey:")]
        APDSdk SharedSdkWithApiKey(string apiKey);

        // +(instancetype)sharedSdk;
        [Static]
        [Export("sharedSdk")]
        APDSdk SharedSdk();

        // -(void)setFramework:(APDFramework)framework;
        [Export("setFramework:")]
        void SetFramework(APDFramework framework);

        // -(void)setPluginVersion:(NSString *)pluginVersion;
        [Export("setPluginVersion:")]
        void SetPluginVersion(string pluginVersion);

        // -(void)initializeForAdTypes:(APDType)adTypes;
        [Export("initializeForAdTypes:")]
        void InitializeForAdTypes(APDType adTypes);

        // -(BOOL)isInitializedForAdType:(APDType)adType;
        [Export("isInitializedForAdType:")]
        bool IsInitializedForAdType(APDType adType);

        // -(void)setTesingMode:(BOOL)enabled;
        [Export("setTesingMode:")]
        void SetTesingMode(bool enabled);

        // -(void)disableUserInfoForNetworkName:(NSString *)networkName;
        [Export("disableUserInfoForNetworkName:")]
        void DisableUserInfoForNetworkName(string networkName);

        // -(void)setCustomRule:(NSDictionary *)customRule;
        [Export("setCustomRule:")]
        void SetCustomRule(NSDictionary customRule);

        // -(void)setLogLevel:(APDLogLevel)logLevel;
        [Export("setLogLevel:")]
        void SetLogLevel(APDLogLevel logLevel);

        // -(void)setLocationTracking:(BOOL)enabled;
        [Export("setLocationTracking:")]
        void SetLocationTracking(bool enabled);

        // -(void)resetUUID;
        [Export("resetUUID")]
        void ResetUUID();

        // -(void)setMinimumFreeMemoryPercentage:(NSUInteger)percentage observeSystemWarnings:(BOOL)observeSystemWarnings forAdType:(APDType)type;
        [Export("setMinimumFreeMemoryPercentage:observeSystemWarnings:forAdType:")]
        void SetMinimumFreeMemoryPercentage(nuint percentage, bool observeSystemWarnings, APDType type);

        // -(void)setChildDirectedTreatment:(BOOL)childDirectedTreatment;
        [Export("setChildDirectedTreatment:")]
        void SetChildDirectedTreatment(bool childDirectedTreatment);
    }

    // @interface InAppPurchase (APDSdk)
    [Category]
    [BaseType(typeof(APDSdk))]
    interface APDSdk_InAppPurchase
    {
        // -(void)trackInAppPurchase:(NSNumber *)amount currency:(NSString *)currency;
        [Export("trackInAppPurchase:currency:")]
        void TrackInAppPurchase(NSNumber amount, string currency);
    }

    // @protocol APDSkippableVideoDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDSkippableVideoDelegate
    {
        // @optional -(void)skippableVideoDidLoad:(APDSkippableVideo *)skippableVideo;
        [Export("skippableVideoDidLoad:")]
        void SkippableVideoDidLoad(APDSkippableVideo skippableVideo);

        // @optional -(void)skippableVideo:(APDSkippableVideo *)skippableVideo didFailToLoadWithError:(NSError *)error;
        [Export("skippableVideo:didFailToLoadWithError:")]
        void SkippableVideo(APDSkippableVideo skippableVideo, NSError error);

        // @optional -(void)skippableVideoDidBecomeUnavailable:(APDSkippableVideo *)skippableVideo;
        [Export("skippableVideoDidBecomeUnavailable:")]
        void SkippableVideoDidBecomeUnavailable(APDSkippableVideo skippableVideo);

        // @optional -(void)skippableVideoDidAppear:(APDSkippableVideo *)skippableVideo;
        [Export("skippableVideoDidAppear:")]
        void SkippableVideoDidAppear(APDSkippableVideo skippableVideo);

        // @optional -(void)skippableVideoDidFinish:(APDSkippableVideo *)skippableVideo;
        [Export("skippableVideoDidFinish:")]
        void SkippableVideoDidFinish(APDSkippableVideo skippableVideo);

        // @optional -(void)skippableVideoDidDisappear:(APDSkippableVideo *)skippableVideo;
        [Export("skippableVideoDidDisappear:")]
        void SkippableVideoDidDisappear(APDSkippableVideo skippableVideo);

        // @optional -(void)skippableVideo:(APDSkippableVideo *)skippableVideo didFailToPresentWithError:(NSError *)error;
        [Export("skippableVideo:didFailToPresentWithError:")]
        void SkippableVideoDidFailToPresentWithError(APDSkippableVideo skippableVideo, NSError error);
    }

    // @interface APDSkippableVideo : NSObject
    [BaseType(typeof(NSObject))]
    interface APDSkippableVideo
    {
        [Wrap("WeakDelegate")]
        APDSkippableVideoDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<APDSkippableVideoDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) NSString * placement;
        [Export("placement")]
        string Placement { get; set; }

        // @property (nonatomic, weak) APDSdk * customSdk;
        [Export("customSdk", ArgumentSemantic.Weak)]
        APDSdk CustomSdk { get; set; }

        // @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
        [Export("ready")]
        bool Ready { [Bind("isReady")] get; }

        // -(void)loadAd __attribute__((deprecated("As of version 1.4.0 skippable video contains in interstitial ad")));
        [Export("loadAd")]
        void LoadAd();

        // -(void)presentFromViewController:(UIViewController *)viewController __attribute__((deprecated("As of version 1.4.0 skippable video contains in interstitial ad")));
        [Export("presentFromViewController:")]
        void PresentFromViewController(UIViewController viewController);
    }

    // @interface Appodeal : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface Appodeal
    {
        // +(void)disableNetworkForAdType:(AppodealAdType)adType name:(NSString *)networkName __attribute__((deprecated("Now you can delete network in segments settings on Appodeal Dashboard")));
        [Static]
        [Export("disableNetworkForAdType:name:")]
        void DisableNetworkForAdType(AppodealAdType adType, string networkName);

        // +(void)disableLocationPermissionCheck __attribute__((deprecated("use method setLocationTracking:")));
        [Static]
        [Export("disableLocationPermissionCheck")]
        void DisableLocationPermissionCheck();

        // +(void)setLocationTracking:(BOOL)enabled;
        [Static]
        [Export("setLocationTracking:")]
        void SetLocationTracking(bool enabled);

        // +(void)setAutocache:(BOOL)autocache types:(AppodealAdType)types;
        [Static]
        [Export("setAutocache:types:")]
        void SetAutocache(bool autocache, AppodealAdType types);

        // +(BOOL)isAutocacheEnabled:(AppodealAdType)types;
        [Static]
        [Export("isAutocacheEnabled:")]
        bool IsAutocacheEnabled(AppodealAdType types);

        // +(void)initializeWithApiKey:(NSString *)apiKey types:(AppodealAdType)types;
        [Static]
        [Export("initializeWithApiKey:types:")]
        void InitializeWithApiKey(string apiKey, AppodealAdType types);

        // +(BOOL)isInitalized;
        [Static]
        [Export("isInitalized")]
        bool IsInitalized { get; }

        // +(void)setLogLevel:(APDLogLevel)logLevel;
        [Static]
        [Export("setLogLevel:")]
        void SetLogLevel(APDLogLevel logLevel);

        // +(void)setFramework:(APDFramework)framework;
        [Static]
        [Export("setFramework:")]
        void SetFramework(APDFramework framework);

        // +(void)setPluginVersion:(NSString *)pluginVersion;
        [Static]
        [Export("setPluginVersion:")]
        void SetPluginVersion(string pluginVersion);

        // +(void)setInterstitialDelegate:(id<AppodealInterstitialDelegate>)interstitialDelegate;
        [Static]
        [Export("setInterstitialDelegate:")]
        void SetInterstitialDelegate(AppodealInterstitialDelegate interstitialDelegate);

        // +(void)setBannerDelegate:(id<AppodealBannerDelegate>)bannerDelegate;
        [Static]
        [Export("setBannerDelegate:")]
        void SetBannerDelegate(AppodealBannerDelegate bannerDelegate);

        // +(void)setSkippableVideoDelegate:(id<AppodealSkippableVideoDelegate>)videoDelegate __attribute__((deprecated("use Interstitial")));
        [Static]
        [Export("setSkippableVideoDelegate:")]
        void SetSkippableVideoDelegate(AppodealSkippableVideoDelegate videoDelegate);

        // +(void)setRewardedVideoDelegate:(id<AppodealRewardedVideoDelegate>)rewardedVideoDelegate;
        [Static]
        [Export("setRewardedVideoDelegate:")]
        void SetRewardedVideoDelegate(AppodealRewardedVideoDelegate rewardedVideoDelegate);

        // +(void)setNonSkippableVideoDelegate:(id<AppodealNonSkippableVideoDelegate>)nonSkippableVideoDelegate;
        [Static]
        [Export("setNonSkippableVideoDelegate:")]
        void SetNonSkippableVideoDelegate(AppodealNonSkippableVideoDelegate nonSkippableVideoDelegate);

        // +(void)setNativeAdDelegate:(id<AppodealNativeAdDelegate>)nativeAdDelegate;
        [Static]
        [Export("setNativeAdDelegate:")]
        void SetNativeAdDelegate(AppodealNativeAdDelegate nativeAdDelegate);

        // +(void)setRequestDelegate:(id<AppodealRequestDelegate>)requestDelegate;
        [Static]
        [Export("setRequestDelegate:")]
        void SetRequestDelegate(AppodealRequestDelegate requestDelegate);

        // +(UIView *)banner;
        [Static]
        [Export("banner")]
        UIView Banner { get; }

        // +(BOOL)showAd:(AppodealShowStyle)style rootViewController:(UIViewController *)rootViewController;
        [Static]
        [Export("showAd:rootViewController:")]
        bool ShowAd(AppodealShowStyle style, UIViewController rootViewController);

        // +(BOOL)showAd:(AppodealShowStyle)style forPlacement:(NSString *)placement rootViewController:(UIViewController *)rootViewController;
        [Static]
        [Export("showAd:forPlacement:rootViewController:")]
        bool ShowAd(AppodealShowStyle style, string placement, UIViewController rootViewController);

        // +(BOOL)canShowAd:(AppodealShowStyle)style forPlacement:(NSString *)placement;
        [Static]
        [Export("canShowAd:forPlacement:")]
        bool CanShowAd(AppodealShowStyle style, string placement);

        // +(id<APDReward>)rewardForPlacement:(NSString *)placement;
        [Static]
        [Export("rewardForPlacement:")]
        APDReward RewardForPlacement(string placement);

        // +(void)cacheAd:(AppodealAdType)type;
        [Static]
        [Export("cacheAd:")]
        void CacheAd(AppodealAdType type);

        // +(void)cacheAd:(AppodealAdType)type forPlacement:(NSString *)placement;
        [Static]
        [Export("cacheAd:forPlacement:")]
        void CacheAd(AppodealAdType type, string placement);

        // +(void)hideBanner;
        [Static]
        [Export("hideBanner")]
        void HideBanner();

        // +(void)setDebugEnabled:(BOOL)debugEnabled;
        [Static]
        [Export("setDebugEnabled:")]
        void SetDebugEnabled(bool debugEnabled);

        // +(void)setTestingEnabled:(BOOL)testingEnabled;
        [Static]
        [Export("setTestingEnabled:")]
        void SetTestingEnabled(bool testingEnabled);

        // +(void)trackInAppPurchase:(NSNumber *)amount currency:(NSString *)currency;
        [Static]
        [Export("trackInAppPurchase:currency:")]
        void TrackInAppPurchase(NSNumber amount, string currency);

        // +(NSString *)getUUID;
        [Static]
        [Export("getUUID")]
        string UUID { get; }

        // +(NSString *)getVersion;
        [Static]
        [Export("getVersion")]
        string Version { get; }

        // +(BOOL)isReadyForShowWithStyle:(AppodealShowStyle)showStyle;
        [Static]
        [Export("isReadyForShowWithStyle:")]
        bool IsReadyForShowWithStyle(AppodealShowStyle showStyle);

        // +(void)setCustomRule:(NSDictionary *)customRule;
        [Static]
        [Export("setCustomRule:")]
        void SetCustomRule(NSDictionary customRule);

        // +(void)confirmUsage:(AppodealAdType)adTypes;
        [Static]
        [Export("confirmUsage:")]
        void ConfirmUsage(AppodealAdType adTypes);

        // +(void)setSmartBannersEnabled:(BOOL)smartBannerEnabled;
        [Static]
        [Export("setSmartBannersEnabled:")]
        void SetSmartBannersEnabled(bool smartBannerEnabled);

        // +(void)setBannerBackgroundVisible:(BOOL)bannerBackgroundVisible;
        [Static]
        [Export("setBannerBackgroundVisible:")]
        void SetBannerBackgroundVisible(bool bannerBackgroundVisible);

        // +(void)setBannerAnimationEnabled:(BOOL)bannerAnimationEnabled;
        [Static]
        [Export("setBannerAnimationEnabled:")]
        void SetBannerAnimationEnabled(bool bannerAnimationEnabled);

        // +(void)loadNaitveAd:(APDNativeAdType)type capacity:(NSInteger)capacity;
        [Static]
        [Export("loadNaitveAd:capacity:")]
        void LoadNaitveAd(APDNativeAdType type, nint capacity);

        // +(NSArray *)getNativeAdsOfCount:(NSInteger)count;
        [Static]
        [Export("getNativeAdsOfCount:")]
        NSObject[] GetNativeAdsOfCount(nint count);

        // +(NSInteger)availableNativeAdsCount;
        [Static]
        [Export("availableNativeAdsCount")]
        nint AvailableNativeAdsCount { get; }

        // +(void)disableUserData:(NSString *)networkName;
        [Static]
        [Export("disableUserData:")]
        void DisableUserData(string networkName);

        // +(void)setMinimumFreeMemoryPercentage:(NSUInteger)percentage forAdType:(AppodealAdType)type __attribute__((deprecated("Use -setMinimumFreeMemoryPercentage:observeSystemWarnings:forAdType: instead")));
        [Static]
        [Export("setMinimumFreeMemoryPercentage:forAdType:")]
        void SetMinimumFreeMemoryPercentage(nuint percentage, AppodealAdType type);

        // +(void)setMinimumFreeMemoryPercentage:(NSUInteger)percentage observeSystemWarnings:(BOOL)observeSystemWarnings forAdType:(AppodealAdType)type;
        [Static]
        [Export("setMinimumFreeMemoryPercentage:observeSystemWarnings:forAdType:")]
        void SetMinimumFreeMemoryPercentage(nuint percentage, bool observeSystemWarnings, AppodealAdType type);

        // +(void)setChildDirectedTreatment:(BOOL)childDirectedTreatment;
        [Static]
        [Export("setChildDirectedTreatment:")]
        void SetChildDirectedTreatment(bool childDirectedTreatment);
    }

    // @interface UserMetadata (Appodeal)
    [Category]
    [BaseType(typeof(Appodeal))]
    interface Appodeal_UserMetadata
    {
        // +(void)setUserId:(NSString *)userId;
        [Static]
        [Export("setUserId:")]
        void SetUserId(string userId);

        // +(void)setUserEmail:(NSString *)email;
        [Static]
        [Export("setUserEmail:")]
        void SetUserEmail(string email);

        // +(void)setUserBirthday:(NSDate *)birthday;
        [Static]
        [Export("setUserBirthday:")]
        void SetUserBirthday(NSDate birthday);

        // +(void)setUserAge:(NSUInteger)age;
        [Static]
        [Export("setUserAge:")]
        void SetUserAge(nuint age);

        // +(void)setUserGender:(AppodealUserGender)gender;
        [Static]
        [Export("setUserGender:")]
        void SetUserGender(AppodealUserGender gender);

        // +(void)setUserOccupation:(AppodealUserOccupation)occupation;
        [Static]
        [Export("setUserOccupation:")]
        void SetUserOccupation(AppodealUserOccupation occupation);

        // +(void)setUserRelationship:(AppodealUserRelationship)relationship;
        [Static]
        [Export("setUserRelationship:")]
        void SetUserRelationship(AppodealUserRelationship relationship);

        // +(void)setUserSmokingAttitude:(AppodealUserSmokingAttitude)smokingAttitude;
        [Static]
        [Export("setUserSmokingAttitude:")]
        void SetUserSmokingAttitude(AppodealUserSmokingAttitude smokingAttitude);

        // +(void)setUserAlcoholAttitude:(AppodealUserAlcoholAttitude)alcoholAttitude;
        [Static]
        [Export("setUserAlcoholAttitude:")]
        void SetUserAlcoholAttitude(AppodealUserAlcoholAttitude alcoholAttitude);

        // +(void)setUserInterests:(NSString *)interests;
        [Static]
        [Export("setUserInterests:")]
        void SetUserInterests(string interests);
    }

    // @protocol AppodealBannerViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealBannerViewDelegate
    {
        // @optional -(void)bannerViewDidLoadAd:(APDBannerView *)bannerView;
        [Export("bannerViewDidLoadAd:")]
        void BannerViewDidLoadAd(APDBannerView bannerView);

        // @optional -(void)bannerView:(APDBannerView *)bannerView didFailToLoadAdWithError:(NSError *)error;
        [Export("bannerView:didFailToLoadAdWithError:")]
        void BannerView(APDBannerView bannerView, NSError error);

        // @optional -(void)bannerViewDidInteract:(APDBannerView *)bannerView;
        [Export("bannerViewDidInteract:")]
        void BannerViewDidInteract(APDBannerView bannerView);

        // @optional -(void)bannerViewDidShow:(APDBannerView *)bannerView;
        [Export("bannerViewDidShow:")]
        void BannerViewDidShow(APDBannerView bannerView);

        // @optional -(void)bannerViewDidRefresh:(APDBannerView *)bannerView __attribute__((deprecated("Use -bannerViewDidShow: instead")));
        [Export("bannerViewDidRefresh:")]
        void BannerViewDidRefresh(APDBannerView bannerView);
    }

    // @interface AppodealBannerView : APDBannerView
    [BaseType(typeof(APDBannerView))]
    interface AppodealBannerView
    {
        // @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
        [Export("ready")]
        bool Ready { [Bind("isReady")] get; }

        // -(id<AppodealBannerViewDelegate>)delegate;
        // -(void)setDelegate:(id<AppodealBannerViewDelegate>)delegate;
        [Export("delegate")]
        AppodealBannerViewDelegate Delegate { get; set; }

        // -(instancetype)initWithSize:(CGSize)size rootViewController:(UIViewController *)rootViewController;
        [Export("initWithSize:rootViewController:")]
        IntPtr Constructor(CGSize size, UIViewController rootViewController);

        // -(void)loadAd;
        [Export("loadAd")]
        void LoadAd();
    }

    // @interface AppodealMRECView : APDMRECView
    [BaseType(typeof(APDMRECView))]
    interface AppodealMRECView
    {
        // -(id<AppodealBannerViewDelegate>)delegate;
        // -(void)setDelegate:(id<AppodealBannerViewDelegate>)delegate;
        [Export("delegate")]
        AppodealBannerViewDelegate Delegate { get; set; }

        // -(instancetype)initWithRootViewController:(UIViewController *)rootViewController;
        [Export("initWithRootViewController:")]
        IntPtr Constructor(UIViewController rootViewController);
    }

    // @protocol AppodealRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppodealRequestDelegate
    {
        // @required -(void)mediationDidStartForAdType:(AppodealAdType)adType;
        [Abstract]
        [Export("mediationDidStartForAdType:")]
        void MediationDidStartForAdType(AppodealAdType adType);

        // @required -(void)willStartAdRequestForAdNetwork:(NSString *)adNetwork adType:(AppodealAdType)adType;
        [Abstract]
        [Export("willStartAdRequestForAdNetwork:adType:")]
        void WillStartAdRequestForAdNetwork(string adNetwork, AppodealAdType adType);

        // @required -(void)didReceiveAdResponseFromAdNetwork:(NSString *)adNetwork adType:(AppodealAdType)adType wasFilled:(BOOL)filled;
        [Abstract]
        [Export("didReceiveAdResponseFromAdNetwork:adType:wasFilled:")]
        void DidReceiveAdResponseFromAdNetwork(string adNetwork, AppodealAdType adType, bool filled);

        // @required -(void)didFinishMediationForAdType:(AppodealAdType)adType hasFilledAd:(BOOL)filled;
        [Abstract]
        [Export("didFinishMediationForAdType:hasFilledAd:")]
        void DidFinishMediationForAdType(AppodealAdType adType, bool filled);

        // @required -(void)didDetectImpressionForAdNetwork:(NSString *)adNetwork adType:(AppodealAdType)adType;
        [Abstract]
        [Export("didDetectImpressionForAdNetwork:adType:")]
        void DidDetectImpressionForAdNetwork(string adNetwork, AppodealAdType adType);

        // @required -(void)didDetectClickForAdNetwork:(NSString *)adNetwork adType:(AppodealAdType)adType;
        [Abstract]
        [Export("didDetectClickForAdNetwork:adType:")]
        void DidDetectClickForAdNetwork(string adNetwork, AppodealAdType adType);
    }

    // @protocol APDBannerViewRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDBannerViewRequestDelegate
    {
        // @optional -(void)bannerViewDidStartMediation:(APDBannerView *)bannerView;
        [Export("bannerViewDidStartMediation:")]
        void BannerViewDidStartMediation(APDBannerView bannerView);

        // @optional -(void)bannerView:(APDBannerView *)bannerView willSendRequestToAdNetwork:(NSString *)adNetwork;
        [Export("bannerView:willSendRequestToAdNetwork:")]
        void BannerView(APDBannerView bannerView, string adNetwork);

        // @optional -(void)bannerView:(APDBannerView *)bannerView didRecieveResponseFromAdNetwork:(NSString *)adNetwork wasFilled:(BOOL)filled;
        [Export("bannerView:didRecieveResponseFromAdNetwork:wasFilled:")]
        void BannerView(APDBannerView bannerView, string adNetwork, bool filled);

        // @optional -(void)bannerView:(APDBannerView *)bannerView didFinishMediationAdWasFilled:(BOOL)filled;
        [Export("bannerView:didFinishMediationAdWasFilled:")]
        void BannerView(APDBannerView bannerView, bool filled);

        // @optional -(void)bannerView:(APDBannerView *)bannerView logImpressionForAdNetwork:(NSString *)adNetwork;
        [Export("bannerView:logImpressionForAdNetwork:")]
        void BannerViewLogImpressionForAdNetwork(APDBannerView bannerView, string adNetwork);

        // @optional -(void)bannerView:(APDBannerView *)bannerView logClickForAdNetwork:(NSString *)adNetwork;
        [Export("bannerView:logClickForAdNetwork:")]
        void BannerViewLogClickForAdNetwork(APDBannerView bannerView, string adNetwork);
    }

    // @protocol APDInterstitalAdRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDInterstitalAdRequestDelegate
    {
        // @optional -(void)interstitialDidStartMediation:(APDInterstitialAd *)interstitial;
        [Export("interstitialDidStartMediation:")]
        void InterstitialDidStartMediation(APDInterstitialAd interstitial);

        // @optional -(void)interstitial:(APDInterstitialAd *)interstitial willSendRequestToAdNetwork:(NSString *)adNetwork;
        [Export("interstitial:willSendRequestToAdNetwork:")]
        void Interstitial(APDInterstitialAd interstitial, string adNetwork);

        // @optional -(void)interstitial:(APDInterstitialAd *)interstitial didRecieveResponseFromAdNetwork:(NSString *)adNetwork wasFilled:(BOOL)filled;
        [Export("interstitial:didRecieveResponseFromAdNetwork:wasFilled:")]
        void Interstitial(APDInterstitialAd interstitial, string adNetwork, bool filled);

        // @optional -(void)interstitial:(APDInterstitialAd *)interstitial didFinishMediationAdWasFilled:(BOOL)filled;
        [Export("interstitial:didFinishMediationAdWasFilled:")]
        void Interstitial(APDInterstitialAd interstitial, bool filled);

        // @optional -(void)interstitial:(APDInterstitialAd *)interstitial logImpressionForAdNetwork:(NSString *)adNetwork;
        [Export("interstitial:logImpressionForAdNetwork:")]
        void InterstitialLogImpressionForAdNetwork(APDInterstitialAd interstitial, string adNetwork);

        // @optional -(void)interstitial:(APDInterstitialAd *)interstitial logClickForAdNetwork:(NSString *)adNetwork;
        [Export("interstitial:logClickForAdNetwork:")]
        void InterstitialLogClickForAdNetwork(APDInterstitialAd interstitial, string adNetwork);
    }

    // @protocol APDRewardedVideoRequestDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface APDRewardedVideoRequestDelegate
    {
        // @optional -(void)rewardedVideoDidStartMediation:(APDRewardedVideo *)rewardedVideo;
        [Export("rewardedVideoDidStartMediation:")]
        void RewardedVideoDidStartMediation(APDRewardedVideo rewardedVideo);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo willSendRequestToAdNetwork:(NSString *)adNetwork;
        [Export("rewardedVideo:willSendRequestToAdNetwork:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, string adNetwork);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didRecieveResponseFromAdNetwork:(NSString *)adNetwork wasFilled:(BOOL)filled;
        [Export("rewardedVideo:didRecieveResponseFromAdNetwork:wasFilled:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, string adNetwork, bool filled);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFinishMediationAdWasFilled:(BOOL)filled;
        [Export("rewardedVideo:didFinishMediationAdWasFilled:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, bool filled);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo logImpressionForAdNetwork:(NSString *)adNetwork;
        [Export("rewardedVideo:logImpressionForAdNetwork:")]
        void RewardedVideoLogImpressionForAdNetwork(APDRewardedVideo rewardedVideo, string adNetwork);

        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo logClickForAdNetwork:(NSString *)adNetwork;
        [Export("rewardedVideo:logClickForAdNetwork:")]
        void RewardedVideoLogClickForAdNetwork(APDRewardedVideo rewardedVideo, string adNetwork);
    }


}