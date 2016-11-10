using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace AppodealBinding
{
	// @protocol AppodealInterstitialDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealInterstitialDelegate
	{
		// @optional -(void)interstitialDidLoadAd;
		[Export ("interstitialDidLoadAd")]
		void InterstitialDidLoadAd ();

		// @optional -(void)interstitialDidFailToLoadAd;
		[Export ("interstitialDidFailToLoadAd")]
		void InterstitialDidFailToLoadAd ();

		// @optional -(void)interstitialWillPresent;
		[Export ("interstitialWillPresent")]
		void InterstitialWillPresent ();

		// @optional -(void)interstitialDidDismiss;
		[Export ("interstitialDidDismiss")]
		void InterstitialDidDismiss ();

		// @optional -(void)interstitialDidClick;
		[Export ("interstitialDidClick")]
		void InterstitialDidClick ();
	}

	// @protocol AppodealBannerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealBannerDelegate
	{
		// @optional -(void)bannerDidLoadAd;
		[Export ("bannerDidLoadAd")]
		void BannerDidLoadAd ();

		// @optional -(void)bannerDidFailToLoadAd;
		[Export ("bannerDidFailToLoadAd")]
		void BannerDidFailToLoadAd ();

		// @optional -(void)bannerDidClick;
		[Export ("bannerDidClick")]
		void BannerDidClick ();

		// @optional -(void)bannerDidShow;
		[Export ("bannerDidShow")]
		void BannerDidShow ();
	}

	// @protocol AppodealVideoDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealVideoDelegate
	{
		// @optional -(void)videoDidLoadAd;
		[Export ("videoDidLoadAd")]
		void VideoDidLoadAd ();

		// @optional -(void)videoDidFailToLoadAd;
		[Export ("videoDidFailToLoadAd")]
		void VideoDidFailToLoadAd ();

		// @optional -(void)videoDidPresent;
		[Export ("videoDidPresent")]
		void VideoDidPresent ();

		// @optional -(void)videoWillDismiss;
		[Export ("videoWillDismiss")]
		void VideoWillDismiss ();

		// @optional -(void)videoDidFinish;
		[Export ("videoDidFinish")]
		void VideoDidFinish ();

		// @optional -(void)videoDidClick;
		[Export ("videoDidClick")]
		void VideoDidClick ();
	}

	// @protocol AppodealRewardedVideoDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealRewardedVideoDelegate
	{
		// @optional -(void)rewardedVideoDidLoadAd;
		[Export ("rewardedVideoDidLoadAd")]
		void RewardedVideoDidLoadAd ();

		// @optional -(void)rewardedVideoDidFailToLoadAd;
		[Export ("rewardedVideoDidFailToLoadAd")]
		void RewardedVideoDidFailToLoadAd ();

		// @optional -(void)rewardedVideoDidPresent;
		[Export ("rewardedVideoDidPresent")]
		void RewardedVideoDidPresent ();

		// @optional -(void)rewardedVideoWillDismiss;
		[Export ("rewardedVideoWillDismiss")]
		void RewardedVideoWillDismiss ();

		// @optional -(void)rewardedVideoDidFinish:(NSUInteger)rewardAmount name:(NSString *)rewardName;
		[Export ("rewardedVideoDidFinish:name:")]
		void RewardedVideoDidFinish (nuint rewardAmount, string rewardName);

		// @optional -(void)rewardedVideoDidClick;
		[Export ("rewardedVideoDidClick")]
		void RewardedVideoDidClick ();
	}

	[Static]
	partial interface NetworkNames
	{
		// extern NSString *const kAppodealAdColonyNetworkName;
		[Field ("kAppodealAdColonyNetworkName", "__Internal")]
		NSString kAppodealAdColonyNetworkName { get; }

		// extern NSString *const kAppodealAdMobNetworkName;
		[Field ("kAppodealAdMobNetworkName", "__Internal")]
		NSString kAppodealAdMobNetworkName { get; }

		// extern NSString *const kAppodealAdMobVideoNetworkName;
		[Field ("kAppodealAdMobVideoNetworkName", "__Internal")]
		NSString kAppodealAdMobVideoNetworkName { get; }

		// extern NSString *const kAppodealAmazonAdsNetworkName;
		[Field ("kAppodealAmazonAdsNetworkName", "__Internal")]
		NSString kAppodealAmazonAdsNetworkName { get; }

		// extern NSString *const kAppodealAppLovinNetworkName;
		[Field ("kAppodealAppLovinNetworkName", "__Internal")]
		NSString kAppodealAppLovinNetworkName { get; }

		// extern NSString *const kAppodealChartboostNetworkName;
		[Field ("kAppodealChartboostNetworkName", "__Internal")]
		NSString kAppodealChartboostNetworkName { get; }

		// extern NSString *const kAppodealFacebookNetworkName;
		[Field ("kAppodealFacebookNetworkName", "__Internal")]
		NSString kAppodealFacebookNetworkName { get; }

		// extern NSString *const kAppodealInMobiNetworkName;
		[Field ("kAppodealInMobiNetworkName", "__Internal")]
		NSString kAppodealInMobiNetworkName { get; }

		// extern NSString *const kAppodealMyTargetNetworkName;
		[Field ("kAppodealMyTargetNetworkName", "__Internal")]
		NSString kAppodealMyTargetNetworkName { get; }

		// extern NSString *const kAppodealMyTargetBannerNetworkName;
		[Field ("kAppodealMyTargetBannerNetworkName", "__Internal")]
		NSString kAppodealMyTargetBannerNetworkName { get; }

		// extern NSString *const kAppodealMopubNetworkName;
		[Field ("kAppodealMopubNetworkName", "__Internal")]
		NSString kAppodealMopubNetworkName { get; }

		// extern NSString *const kAppodealMRAIDNetworkName;
		[Field ("kAppodealMRAIDNetworkName", "__Internal")]
		NSString kAppodealMRAIDNetworkName { get; }

		// extern NSString *const kAppodealOpenXNetworkName;
		[Field ("kAppodealOpenXNetworkName", "__Internal")]
		NSString kAppodealOpenXNetworkName { get; }

		// extern NSString *const kAppodealTapSenceNetworkName;
		[Field ("kAppodealTapSenceNetworkName", "__Internal")]
		NSString kAppodealTapSenceNetworkName { get; }

		// extern NSString *const kAppodealUnityAdsNetworkName;
		[Field ("kAppodealUnityAdsNetworkName", "__Internal")]
		NSString kAppodealUnityAdsNetworkName { get; }

		// extern NSString *const kAppodealVungleNetworkName;
		[Field ("kAppodealVungleNetworkName", "__Internal")]
		NSString kAppodealVungleNetworkName { get; }

		// extern NSString *const kAppodealSmaatoNetworkName;
		[Field ("kAppodealSmaatoNetworkName", "__Internal")]
		NSString kAppodealSmaatoNetworkName { get; }

		// extern NSString *const kAppodealYandexNetworkName;
		[Field ("kAppodealYandexNetworkName", "__Internal")]
		NSString kAppodealYandexNetworkName { get; }

		// extern NSString *const kAppodealStartAppNetworkName;
		[Field ("kAppodealStartAppNetworkName", "__Internal")]
		NSString kAppodealStartAppNetworkName { get; }

		// extern NSString *const kAppodealAppNexusNetworkName;
		[Field ("kAppodealAppNexusNetworkName", "__Internal")]
		NSString kAppodealAppNexusNetworkName { get; }

		// extern NSString *const kAppodealRubiconNetworkName;
		[Field ("kAppodealRubiconNetworkName", "__Internal")]
		NSString kAppodealRubiconNetworkName { get; }

		// extern NSString *const kAppodealAvocarrotNetworkName;
		[Field ("kAppodealAvocarrotNetworkName", "__Internal")]
		NSString kAppodealAvocarrotNetworkName { get; }

		// extern NSString *const kAppodealPubNativeNetworkName;
		[Field ("kAppodealPubNativeNetworkName", "__Internal")]
		NSString kAppodealPubNativeNetworkName { get; }

		// extern NSString *const kAppodealFlurryNetworkName;
		[Field ("kAppodealFlurryNetworkName", "__Internal")]
		NSString kAppodealFlurryNetworkName { get; }

		// extern NSString *const kAppodealLiveRailNetworkName;
		[Field ("kAppodealLiveRailNetworkName", "__Internal")]
		NSString kAppodealLiveRailNetworkName { get; }

		// extern NSString *const kAppodealSpotXNetworkName;
		[Field ("kAppodealSpotXNetworkName", "__Internal")]
		NSString kAppodealSpotXNetworkName { get; }

		// extern NSString *const kAppodealVASTNetworkName;
		[Field ("kAppodealVASTNetworkName", "__Internal")]
		NSString kAppodealVASTNetworkName { get; }

		// extern NSString *const kAppodealInnerActiveNetworkName;
		[Field ("kAppodealInnerActiveNetworkName", "__Internal")]
		NSString kAppodealInnerActiveNetworkName { get; }

		// extern NSString *const kAppodealMillenialMediaNetworkName;
		[Field ("kAppodealMillenialMediaNetworkName", "__Internal")]
		NSString kAppodealMillenialMediaNetworkName { get; }

		// extern NSString *const kAppodealNativeTestNetworkName;
		[Field ("kAppodealNativeTestNetworkName", "__Internal")]
		NSString kAppodealNativeTestNetworkName { get; }
	}

	[Static]
	partial interface UnitSizes
	{
		// extern const CGSize kAppodealUnitSize_320x50;
		[Field ("kAppodealUnitSize_320x50", "__Internal")]
		CGSize kAppodealUnitSize_320x50 { get; }

		// extern const CGSize kAppodealUnitSize_300x250;
		[Field ("kAppodealUnitSize_300x250", "__Internal")]
		CGSize kAppodealUnitSize_300x250 { get; }

		// extern const CGSize kAppodealUnitSize_728x90;
		[Field ("kAppodealUnitSize_728x90", "__Internal")]
		CGSize kAppodealUnitSize_728x90 { get; }
	}

	// @protocol AppodealBannerViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealBannerViewDelegate
	{
		// @optional -(void)bannerViewDidLoadAd:(AppodealBannerView *)bannerView;
		[Export ("bannerViewDidLoadAd:")]
		void BannerViewDidLoadAd (AppodealBannerView bannerView);

		// @optional -(void)bannerView:(AppodealBannerView *)bannerView didFailToLoadAdWithError:(NSError *)error;
		[Export ("bannerView:didFailToLoadAdWithError:")]
		void BannerView (AppodealBannerView bannerView, NSError error);

		// @optional -(void)bannerViewDidInteract:(AppodealBannerView *)bannerView;
		[Export ("bannerViewDidInteract:")]
		void BannerViewDidInteract (AppodealBannerView bannerView);
	}

	/* @protocol AppodealBannerViewRequestDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealBannerViewRequestDelegate
	{
		// @required -(void)bannerViewDidStart:(AppodealBannerView *)bannerView;
		[Abstract]
		[Export ("bannerViewDidStart:")]
		void BannerViewDidStart (AppodealBannerView bannerView);

		// @required -(void)requestDidStart:(AppodealBannerView *)bannerView andNetwork:(NSString *)networkName;
		[Abstract]
		[Export ("requestDidStart:andNetwork:")]
		void RequestDidStart (AppodealBannerView bannerView, string networkName);

		// @required -(void)requestDidFinish:(AppodealBannerView *)bannerView andNetwork:(NSString *)networkName adFilled:(BOOL)filled;
		[Abstract]
		[Export ("requestDidFinish:andNetwork:adFilled:")]
		void RequestDidFinish (AppodealBannerView bannerView, string networkName, bool filled);

		// @required -(void)bannerViewDidFinish:(AppodealBannerView *)bannerView adFilled:(BOOL)filled;
		[Abstract]
		[Export ("bannerViewDidFinish:adFilled:")]
		void BannerViewDidFinish (AppodealBannerView bannerView, bool filled);
	}*/

	// @interface AppodealBannerView : UIView
	[BaseType (typeof(UIView))]
	interface AppodealBannerView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		AppodealBannerViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AppodealBannerViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		/*[Wrap ("WeakRequestDelegate")]
		[NullAllowed]
		AppodealBannerViewRequestDelegate RequestDelegate { get; set; }*/

		/* @property (nonatomic, weak) id<AppodealBannerViewRequestDelegate> _Nullable requestDelegate;
		[NullAllowed, Export ("requestDelegate", ArgumentSemantic.Weak)]
		NSObject WeakRequestDelegate { get; set; }*/

		// @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
		[Export ("ready")]
		bool Ready { [Bind ("isReady")] get; }

		// -(instancetype)initWithSize:(CGSize)size rootViewController:(UIViewController *)rootViewController;
		[Export ("initWithSize:rootViewController:")]
		IntPtr Constructor (CGSize size, UIViewController rootViewController);

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();
	}

	// @interface AppodealMRECView : AppodealBannerView
	[BaseType (typeof(AppodealBannerView))]
	interface AppodealMRECView
	{
		// -(instancetype)initWithRootViewController:(UIViewController *)rootViewController;
		[Export ("initWithRootViewController:")]
		IntPtr Constructor (UIViewController rootViewController);
	}

	// @interface APDImage : NSObject
	[BaseType (typeof(NSObject))]
	interface APDImage
	{
		// @property (readonly, assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; }

		// @property (readonly, copy, nonatomic) NSURL * imageUrl;
		[Export ("imageUrl", ArgumentSemantic.Copy)]
		NSUrl ImageUrl { get; }
	}

	// @interface APDNativeAdLoader : NSObject
	[BaseType(typeof(NSObject))]
	interface APDNativeAdLoader
	{
		[Wrap("WeakDelegate")]
		APDNativeAdLoaderDelegate Delegate { get; set; }

		// @property (weak, nonatomic) id<APDNativeAdLoaderDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// - (void)loadAdWithType:(APDNativeAdType)type;
		[Export("loadAdWithType:")]
		void LoadAdWithType(APDNativeAdType type);
	}

	// @protocol AppodealNativeAdDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface APDNativeAdLoaderDelegate
	{
		// - (void)nativeAdLoader:(APDNativeAdLoader *)loader didLoadNativeAd:(APDNativeAd *)nativeAd;
		[Export ("nativeAdLoader:didLoadNativeAd:")]
		void NativeAdLoader (APDNativeAdLoader loader, APDNativeAd nativeAd);

		// - (void)nativeAdLoader:(APDNativeAdLoader *)loader didFailToLoadWithError:(NSError *)error;
		[Export ("nativeAdLoader:didFailToLoadWithError:")]
		void NativeAdLoader(APDNativeAdLoader loader, NSError error);
	}

	[BaseType(typeof(UIView))]
	interface APDMediaView
	{
		[Wrap("WeakDelegate")]
		APDMediaViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<APDMediaViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, assign) APDMediaViewType type;
		[Export("type", ArgumentSemantic.Assign)]
		APDMediaViewType Type { get; }

		// @property (nonatomic, assign) BOOL skippable;
		[Export("skippable")]
		bool Skippable { get; }

		// @property (nonatomic, assign) BOOL muted;
		[Export("muted")]
		bool Muted { get; }

		// @property (nonatomic, assign) BOOL useDefaultMuteButton;
		[Export("useDefaultMuteButton")]
		bool UseDefaultMuteButton { get; }

		// - (void)setNativeAd:(APDNativeAd *)nativeAd rootViewController:(UIViewController *)controller;
		[Export("setNativeAd:rootViewController:")]
		void SetNativeAd(APDNativeAd nativeAd, UIViewController controller);

		// - (void)clearView;
		[Export("clearView")]
		void ClearView();

		// - (void)initWithFrame;
		[Export("initWithFrame:")]
		IntPtr Constructor(CGRect frame);
	}

	// @protocol APDMediaViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface APDMediaViewDelegate
	{
		// - (void)mediaViewStartPlaying:(APDMediaView *)mediaView;
		[Export("mediaViewStartPlaying:")]
		void MediaViewStartPlaying(APDMediaView mediaView);

		// - (void)mediaViewFinishPlaying:(APDMediaView *)mediaView videoWasSkipped:(BOOL)wasSkipped;
		[Export("mediaViewFinishPlaying:videoWasSkipped:")]
		void MediaViewFinishPlaying(APDMediaView mediaView, bool wasSkipped);

		// - (void)mediaView:(APDMediaView *)mediaView didPresentFullScreenView:(UIView *)presentedView;
		[Export("mediaView:didPresentFullScreenView:")]
		void MediaView(APDMediaView mediaView, UIView presentedView);

		// - (void)mediaViewDidDismissFullScreen:(APDMediaView *)mediaView;
		[Export("mediaViewDidDismissFullScreen:")]
		void MediaViewDidDismissFullScreen(APDMediaView mediaView);
	}


	// @interface AppodealNativeAd : NSObject
	[BaseType (typeof(NSObject))]
	interface APDNativeAd
	{
		// @property (readonly, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, copy, nonatomic) NSString * descriptionText;
		[Export ("descriptionText")]
		string DescriptionText { get; }

		// @property (readonly, copy, nonatomic) NSString * callToActionText;
		[Export ("callToActionText")]
		string CallToActionText { get; }

		// @property (readonly, copy, nonatomic) NSString * contentRating;
		[Export ("contentRating")]
		string ContentRating { get; }

		// @property (readonly, copy, nonatomic) NSNumber * starRating;
		[Export ("starRating", ArgumentSemantic.Copy)]
		NSNumber StarRating { get; }

		// @property (readonly, nonatomic, strong) AppodealImage * mainImage;
		[Export ("mainImage", ArgumentSemantic.Strong)]
		APDImage MainImage { get; }

		// @property (readonly, nonatomic, strong) AppodealImage * iconImage;
		[Export ("iconImage", ArgumentSemantic.Strong)]
		APDImage IconImage { get; }

		// @property (nonatomic, strong, readonly) UIView * adChoicesView;
		[Export("adChoicesView", ArgumentSemantic.Strong)]
		UIView AdChoicesView { get; }

		// @property (nonatomic, readonly, getter=isContainsVideo) BOOL containsVideo;
		[Export("containsVideo", ArgumentSemantic.Strong)]
		bool Ready { [Bind("isContainsVideo")] get; }

		// -(void)attachToView:(UIView *)view viewController:(UIViewController *)viewController;
		[Export ("attachToView:viewController:")]
		void AttachToView (UIView view, UIViewController viewController);

		// -(void)detachFromView;
		[Export ("detachFromView")]
		void DetachFromView ();
	}
	/*
	// @protocol AppodealNativeAdServiceRequestDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealNativeAdServiceRequestDelegate
	{
		// @required -(void)nativeDidStart:(AppodealNativeAdService *)service;
		[Abstract]
		[Export ("nativeDidStart:")]
		void NativeDidStart (AppodealNativeAdService service);

		// @required -(void)requestDidStart:(AppodealNativeAdService *)service andNetwork:(NSString *)networkName;
		[Abstract]
		[Export ("requestDidStart:andNetwork:")]
		void RequestDidStart (AppodealNativeAdService service, string networkName);

		// @required -(void)requestDidFinish:(AppodealNativeAdService *)service andNetwork:(NSString *)networkName adFilled:(BOOL)filled;
		[Abstract]
		[Export ("requestDidFinish:andNetwork:adFilled:")]
		void RequestDidFinish (AppodealNativeAdService service, string networkName, bool filled);

		// @required -(void)nativeDidFinish:(AppodealNativeAdService *)service adFilled:(BOOL)filled;
		[Abstract]
		[Export ("nativeDidFinish:adFilled:")]
		void NativeDidFinish (AppodealNativeAdService service, bool filled);
	}

	// @protocol AppodealNativeAdServiceDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealNativeAdServiceDelegate
	{
		// @optional -(void)nativeAdServiceDidLoad:(AppodealNativeAd *)nativeAd;
		[Export ("nativeAdServiceDidLoad:")]
		void NativeAdServiceDidLoad (AppodealNativeAd nativeAd);

		// @optional -(void)nativeAdServiceDidLoadSeveralAds __attribute__((deprecated("")));
		[Export ("nativeAdServiceDidLoadSeveralAds")]
		void NativeAdServiceDidLoadSeveralAds ();

		// @optional -(void)nativeAdServiceDidFailedToLoad;
		[Export ("nativeAdServiceDidFailedToLoad")]
		void NativeAdServiceDidFailedToLoad ();
	}

	// @interface AppodealNativeAdService : NSObject
	[BaseType (typeof(NSObject))]
	interface AppodealNativeAdService
	{
		[Wrap ("WeakRequestDelegate")]
		[NullAllowed]
		AppodealNativeAdServiceRequestDelegate RequestDelegate { get; set; }

		// @property (nonatomic, weak) id<AppodealNativeAdServiceRequestDelegate> _Nullable requestDelegate;
		[NullAllowed, Export ("requestDelegate", ArgumentSemantic.Weak)]
		NSObject WeakRequestDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		AppodealNativeAdServiceDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AppodealNativeAdServiceDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
		[Export ("ready")]
		bool Ready { [Bind ("isReady")] get; }

		// -(void)loadAd;
		[Export ("loadAd")]
		void LoadAd ();

		// -(AppodealNativeAd *)nextAd;
		[Export ("nextAd")]
		AppodealNativeAd NextAd { get; }
	}

	/* @interface AppodealNativeAdViewAttributes : NSObject
	[BaseType (typeof(NSObject))]
	interface AppodealNativeAdViewAttributes
	{
		// @property (assign, nonatomic) BOOL roundedIcon;
		[Export ("roundedIcon")]
		bool RoundedIcon { get; set; }

		// @property (assign, nonatomic) BOOL sponsored;
		[Export ("sponsored")]
		bool Sponsored { get; set; }

		// @property (assign, nonatomic) CGFloat width;
		[Export ("width")] 
		nfloat Width { get; set; }

		// @property (assign, nonatomic) CGFloat heigth;
		[Export ("heigth")]
		nfloat Heigth { get; set; }

		// @property (copy, nonatomic) UIFont * titleFont;
		[Export ("titleFont", ArgumentSemantic.Copy)]
		UIFont TitleFont { get; set; }

		// @property (copy, nonatomic) UIFont * descriptionFont;
		[Export ("descriptionFont", ArgumentSemantic.Copy)]
		UIFont DescriptionFont { get; set; }

		// @property (copy, nonatomic) UIFont * subtitleFont;
		[Export ("subtitleFont", ArgumentSemantic.Copy)]
		UIFont SubtitleFont { get; set; }

		// @property (copy, nonatomic) UIFont * buttonTitleFont;
		[Export ("buttonTitleFont", ArgumentSemantic.Copy)]
		UIFont ButtonTitleFont { get; set; }

		// @property (copy, nonatomic) UIColor * titleFontColor;
		[Export ("titleFontColor", ArgumentSemantic.Copy)]
		UIColor TitleFontColor { get; set; }

		// @property (copy, nonatomic) UIColor * descriptionFontColor;
		[Export ("descriptionFontColor", ArgumentSemantic.Copy)]
		UIColor DescriptionFontColor { get; set; }

		// @property (copy, nonatomic) UIColor * subtitleColor;
		[Export ("subtitleColor", ArgumentSemantic.Copy)]
		UIColor SubtitleColor { get; set; }

		// @property (copy, nonatomic) UIColor * buttonColor;
		[Export ("buttonColor", ArgumentSemantic.Copy)]
		UIColor ButtonColor { get; set; }

		// @property (copy, nonatomic) UIColor * starRatingColor;
		[Export ("starRatingColor", ArgumentSemantic.Copy)]
		UIColor StarRatingColor { get; set; }
	}

	// @interface AppodealNativeAdView : UIView
	[BaseType (typeof(UIView))]
	interface AppodealNativeAdView
	{
		// @property (readonly, assign, nonatomic) AppodealNativeAdViewType type;
		[Export ("type", ArgumentSemantic.Assign)]
		AppodealNativeAdViewType Type { get; }

		// @property (nonatomic, weak) UIViewController * _Nullable rootViewController;
		[NullAllowed, Export ("rootViewController", ArgumentSemantic.Weak)]
		UIViewController RootViewController { get; set; }

		// @property (assign, nonatomic) BOOL autoplayEnabled;
		[Export ("autoplayEnabled")]
		bool AutoplayEnabled { get; set; }

		// +(instancetype _Nonnull)nativeAdViewWithType:(AppodealNativeAdViewType)type andNativeAd:(AppodealNativeAd * _Nonnull)ad andAttributes:(AppodealNativeAdViewAttributes * _Nullable)attributes rootViewController:(UIViewController * _Nonnull)controller;
		[Static]
		[Export ("nativeAdViewWithType:andNativeAd:andAttributes:rootViewController:")]
		AppodealNativeAdView NativeAdViewWithType (AppodealNativeAdViewType type, AppodealNativeAd ad, [NullAllowed] AppodealNativeAdViewAttributes attributes, UIViewController controller);
	}

	// @interface AppodealNativeAd (UIView)
	[Category]
	[BaseType (typeof(UIView))]
	interface UIView_AppodealNativeAd
	{
		// -(AppodealNativeAd *)appodeal_attachedNativeAd;
		[Static]
		[Export ("appodeal_attachedNativeAd")]
		AppodealNativeAd Appodeal_attachedNativeAd { get; }
	}

	// @interface AppodealAdChoicesView : UIView
	[BaseType (typeof(UIView))]
	interface AppodealAdChoicesView
	{
		// -(instancetype)initWithNativeAd:(AppodealNativeAd *)nativeAd;
		[Export ("initWithNativeAd:")]
		IntPtr Constructor (AppodealNativeAd nativeAd);

		// -(void)setBackgroundColor:(UIColor *)backgroundColor;
		[Export ("setBackgroundColor:")]
		void SetBackgroundColor (UIColor backgroundColor);
	}

	// @protocol AppodealNativeMediaViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealNativeMediaViewDelegate
	{
		// @optional -(void)mediaViewReady;
		[Export ("mediaViewReady")]
		void MediaViewReady ();

		// @optional -(void)mediaViewError;
		[Export ("mediaViewError")]
		void MediaViewError ();

		// @optional -(void)mediaViewStartPlaying;
		[Export ("mediaViewStartPlaying")]
		void MediaViewStartPlaying ();

		// @optional -(void)mediaViewPresentFullScreen;
		[Export ("mediaViewPresentFullScreen")]
		void MediaViewPresentFullScreen ();

		// @optional -(void)mediaViewCompleteVideoPlaying;
		[Export ("mediaViewCompleteVideoPlaying")]
		void MediaViewCompleteVideoPlaying ();

		// @optional -(void)mediaViewSkip;
		[Export ("mediaViewSkip")]
		void MediaViewSkip ();
	}

	// @interface AppodealNativeMediaView : UIView
	[BaseType (typeof(UIView))]
	interface AppodealNativeMediaView
	{
		[Wrap ("WeakDelegate")]
		AppodealNativeMediaViewDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<AppodealNativeMediaViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) BOOL fullscreenSupport;
		[Export ("fullscreenSupport")]
		bool FullscreenSupport { get; set; }

		// -(instancetype)initWithNativeAd:(AppodealNativeAd *)nativeAd andRootViewController:(UIViewController *)controller;
		[Export ("initWithNativeAd:andRootViewController:")]
		IntPtr Constructor (AppodealNativeAd nativeAd, UIViewController controller);

		// -(void)prepareToPlay;
		[Export ("prepareToPlay")]
		void PrepareToPlay ();

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)setMute:(BOOL)mute;
		[Export ("setMute:")]
		void SetMute (bool mute);

		// -(void)stop;
		[Export ("stop")]
		void Stop ();
	}
	*/
	// @interface Appodeal : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface Appodeal
	{
		// +(void)disableNetworkForAdType:(AppodealAdType)adType name:(NSString *)networkName;
		[Static]
		[Export ("disableNetworkForAdType:name:")]
		void DisableNetworkForAdType (AppodealAdType adType, string networkName);

		// +(void)disableLocationPermissionCheck;
		[Static]
		[Export ("disableLocationPermissionCheck")]
		void DisableLocationPermissionCheck ();

		// +(void)setAutocache:(BOOL)autocache types:(AppodealAdType)types;
		[Static]
		[Export ("setAutocache:types:")]
		void SetAutocache (bool autocache, AppodealAdType types);

		// +(BOOL)isAutocacheEnabled:(AppodealAdType)types;
		[Static]
		[Export ("isAutocacheEnabled:")]
		bool IsAutocacheEnabled (AppodealAdType types);

		// +(void)initializeWithApiKey:(NSString *)apiKey types:(AppodealAdType)types;
		[Static]
		[Export ("initializeWithApiKey:types:")]
		void InitializeWithApiKey (string apiKey, AppodealAdType types);

		// + (void)setFramework:(APDFramework)framework;
		[Static]
		[Export("setFramework:")]
		void SetFramework(APDFramework framework);

		// +(BOOL)isInitalized;
		[Static]
		[Export ("isInitalized")]
		bool IsInitalized { get; }

		// +(void)setInterstitialDelegate:(id<AppodealInterstitialDelegate>)interstitialDelegate;
		[Static]
		[Export ("setInterstitialDelegate:")]
		void SetInterstitialDelegate (AppodealInterstitialDelegate interstitialDelegate);

		// +(void)setBannerDelegate:(id<AppodealBannerDelegate>)bannerDelegate;
		[Static]
		[Export ("setBannerDelegate:")]
		void SetBannerDelegate (AppodealBannerDelegate bannerDelegate);

		// +(void)setVideoDelegate:(id<AppodealVideoDelegate>)videoDelegate;
		[Static]
		[Export ("setVideoDelegate:")]
		void SetVideoDelegate (AppodealVideoDelegate videoDelegate);

		// +(void)setRewardedVideoDelegate:(id<AppodealRewardedVideoDelegate>)rewardedVideoDelegate;
		[Static]
		[Export ("setRewardedVideoDelegate:")]
		void SetRewardedVideoDelegate (AppodealRewardedVideoDelegate rewardedVideoDelegate);

		/* +(void)setRequestDelgate:(id<AppodealRequestDelegate>)requestDelegate;
		[Static]
		[Export ("setRequestDelgate:")]
		void SetRequestDelgate (AppodealRequestDelegate requestDelegate);*/

		// +(UIView *)banner;
		[Static]
		[Export ("banner")]
		UIView Banner { get; }

		// +(BOOL)showAd:(AppodealShowStyle)style rootViewController:(UIViewController *)rootViewController;
		[Static]
		[Export ("showAd:rootViewController:")]
		bool ShowAd (AppodealShowStyle style, UIViewController rootViewController);

		// + (BOOL)showAd:(AppodealShowStyle)style forPlacement:(NSString *)placement rootViewController:(UIViewController *)rootViewController;
		[Static]
		[Export ("showAd:forPlacement:rootViewController:")]
		bool showAd (AppodealShowStyle style, string placement, UIViewController rootViewController);

		// +(void)cacheAd:(AppodealAdType)type;
		[Static]
		[Export ("cacheAd:")]
		void CacheAd (AppodealAdType type);

		// +(void)hideBanner;
		[Static]
		[Export ("hideBanner")]
		void HideBanner ();

		// +(void)setDebugEnabled:(BOOL)debugEnabled;
		[Static]
		[Export("setDebugEnabled:")]
		void SetDebugEnabled(bool debugEnabled);

		// +(void)setTestingEnabled:(BOOL)testingEnabled;
		[Static]
		[Export ("setTestingEnabled:")]
		void SetTestingEnabled (bool testingEnabled);

		// +(NSString *)getVersion;
		[Static]
		[Export ("getVersion")]
		string Version { get; }

		// +(BOOL)isReadyForShowWithStyle:(AppodealShowStyle)showStyle;
		[Static]
		[Export ("isReadyForShowWithStyle:")]
		bool IsReadyForShowWithStyle (AppodealShowStyle showStyle);

		// + (void)setCustomRule:(NSDictionary*)customRule;
		[Static]
		[Export("setCustomRule:")]
		void SetCustomRule(NSDictionary customRule);

		// + (void)setSmartBannersEnabled:(BOOL)smartBannerEnabled;
		[Static]
		[Export("setSmartBannersEnabled:")]
		void SetSmartBannersEnabled(bool smartBannerEnabled);

		// + (void)setBannerBackgroundVisible:(BOOL)bannerBackgroundVisible;
		[Static]
		[Export("setBannerBackgroundVisible:")]
		void SetBannerBackgroundVisible(bool bannerBackgroundVisible);

		// + (void)setBannerAnimationEnabled:(BOOL)bannerAnimationEnabled;
		[Static]
		[Export("setBannerAnimationEnabled:")]
		void SetBannerAnimationEnabled(bool bannerAnimationEnabled);

		// +(void)confirmUsage:(AppodealAdType)adTypes;
		[Static]
		[Export ("confirmUsage:")]
		void ConfirmUsage (AppodealAdType adTypes);
	}

	// @interface UserMetadata (Appodeal)
	[Category]
	[BaseType (typeof(Appodeal))]
	interface Appodeal_UserMetadata
	{
		// +(void)setUserId:(NSString *)userId;
		[Static]
		[Export ("setUserId:")]
		void SetUserId (string userId);

		// +(void)setUserEmail:(NSString *)email;
		[Static]
		[Export ("setUserEmail:")]
		void SetUserEmail (string email);

		// +(void)setUserBirthday:(NSDate *)birthday;
		[Static]
		[Export ("setUserBirthday:")]
		void SetUserBirthday (NSDate birthday);

		// +(void)setUserAge:(NSUInteger)age;
		[Static]
		[Export ("setUserAge:")]
		void SetUserAge (nuint age);

		// +(void)setUserGender:(AppodealUserGender)gender;
		[Static]
		[Export ("setUserGender:")]
		void SetUserGender (AppodealUserGender gender);

		// +(void)setUserOccupation:(AppodealUserOccupation)occupation;
		[Static]
		[Export ("setUserOccupation:")]
		void SetUserOccupation (AppodealUserOccupation occupation);

		// +(void)setUserRelationship:(AppodealUserRelationship)relationship;
		[Static]
		[Export ("setUserRelationship:")]
		void SetUserRelationship (AppodealUserRelationship relationship);

		// +(void)setUserSmokingAttitude:(AppodealUserSmokingAttitude)smokingAttitude;
		[Static]
		[Export ("setUserSmokingAttitude:")]
		void SetUserSmokingAttitude (AppodealUserSmokingAttitude smokingAttitude);

		// +(void)setUserAlcoholAttitude:(AppodealUserAlcoholAttitude)alcoholAttitude;
		[Static]
		[Export ("setUserAlcoholAttitude:")]
		void SetUserAlcoholAttitude (AppodealUserAlcoholAttitude alcoholAttitude);

		// +(void)setUserInterests:(NSString *)interests;
		[Static]
		[Export ("setUserInterests:")]
		void SetUserInterests (string interests);
	}

	/* @protocol AppodealRequestDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface AppodealRequestDelegate
	{
		// @required -(void)waterfallDidStart:(AppodealAdType)adType;
		[Abstract]
		[Export ("waterfallDidStart:")]
		void WaterfallDidStart (AppodealAdType adType);

		// @required -(void)requestDidStartWithType:(AppodealAdType)adType andNetwork:(NSString *)networkName;
		[Abstract]
		[Export ("requestDidStartWithType:andNetwork:")]
		void RequestDidStartWithType (AppodealAdType adType, string networkName);

		// @required -(void)requestDidFinishWithType:(AppodealAdType)adType andNetwork:(NSString *)networkName adFilled:(BOOL)filled;
		[Abstract]
		[Export ("requestDidFinishWithType:andNetwork:adFilled:")]
		void RequestDidFinishWithType (AppodealAdType adType, string networkName, bool filled);

		// @required -(void)waterfallDidFinish:(AppodealAdType)adType adFilled:(BOOL)filled;
		[Abstract]
		[Export ("waterfallDidFinish:adFilled:")]
		void WaterfallDidFinish (AppodealAdType adType, bool filled);
	}*/
}

