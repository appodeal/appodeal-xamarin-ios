using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace AppodealBinding
{
	// @protocol AppodealInterstitialDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface AppodealInterstitialDelegate
	{
		// @optional -(void)interstitialDidLoadAd;
		[Export("interstitialDidLoadAd")]
		void InterstitialDidLoadAd();

		// @optional -(void)interstitialDidFailToLoadAd;
		[Export("interstitialDidFailToLoadAd")]
		void InterstitialDidFailToLoadAd();

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

	// @protocol AppodealBannerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface AppodealBannerDelegate
	{
		// @optional -(void)bannerDidLoadAd;
		[Export("bannerDidLoadAd")]
		void BannerDidLoadAd();

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

	// @protocol AppodealSkippableVideoDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface AppodealSkippableVideoDelegate
	{
		// @optional -(void)videoDidLoadAd;
		[Export("skippableVideoDidLoadAd")]
		void SkippableVideoDidLoadAd();

		// @optional -(void)videoDidFailToLoadAd;
		[Export("skippableVideoDidFailToLoadAd")]
		void SkippableVideoDidFailToLoadAd();

		// @optional -(void)videoDidPresent;
		[Export("skippableVideoDidPresent")]
		void SkippableVideoDidPresent();

		// @optional -(void)videoWillDismiss;
		[Export("skippableVideoWillDismiss")]
		void SkippableVideoWillDismiss();

		// @optional -(void)videoDidFinish;
		[Export("skippableVideoDidFinish")]
		void SkippableVideoDidFinish();

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

		// @optional -(void)rewardedVideoDidPresent;
		[Export("rewardedVideoDidPresent")]
		void RewardedVideoDidPresent();

		// @optional -(void)rewardedVideoWillDismiss;
		[Export("rewardedVideoWillDismiss")]
		void RewardedVideoWillDismiss();

		// @optional -(void)rewardedVideoDidFinish:(NSUInteger)rewardAmount name:(NSString *)rewardName;
		[Export("rewardedVideoDidFinish:name:")]
		void RewardedVideoDidFinish(nuint rewardAmount, string rewardName);

		// @optional -(void)rewardedVideoDidClick;
		[Export("rewardedVideoDidClick")]
		void RewardedVideoDidClick();
	}

	[Static]
	partial interface NetworkNames
	{
		// extern NSString *const kAppodealAdColonyNetworkName;
		[Field("kAppodealAdColonyNetworkName", "__Internal")]
		NSString kAppodealAdColonyNetworkName { get; }

		// extern NSString *const kAppodealAdMobNetworkName;
		[Field("kAppodealAdMobNetworkName", "__Internal")]
		NSString kAppodealAdMobNetworkName { get; }

		// extern NSString *const kAppodealAdMobVideoNetworkName;
		[Field("kAppodealAdMobVideoNetworkName", "__Internal")]
		NSString kAppodealAdMobVideoNetworkName { get; }

		// extern NSString *const kAppodealAmazonAdsNetworkName;
		[Field("kAppodealAmazonAdsNetworkName", "__Internal")]
		NSString kAppodealAmazonAdsNetworkName { get; }

		// extern NSString *const kAppodealAppLovinNetworkName;
		[Field("kAppodealAppLovinNetworkName", "__Internal")]
		NSString kAppodealAppLovinNetworkName { get; }

		// extern NSString *const kAppodealChartboostNetworkName;
		[Field("kAppodealChartboostNetworkName", "__Internal")]
		NSString kAppodealChartboostNetworkName { get; }

		// extern NSString *const kAppodealFacebookNetworkName;
		[Field("kAppodealFacebookNetworkName", "__Internal")]
		NSString kAppodealFacebookNetworkName { get; }

		// extern NSString *const kAppodealInMobiNetworkName;
		[Field("kAppodealInMobiNetworkName", "__Internal")]
		NSString kAppodealInMobiNetworkName { get; }

		// extern NSString *const kAppodealMyTargetNetworkName;
		[Field("kAppodealMyTargetNetworkName", "__Internal")]
		NSString kAppodealMyTargetNetworkName { get; }

		// extern NSString *const kAppodealMyTargetBannerNetworkName;
		[Field("kAppodealMyTargetBannerNetworkName", "__Internal")]
		NSString kAppodealMyTargetBannerNetworkName { get; }

		// extern NSString *const kAppodealMopubNetworkName;
		[Field("kAppodealMopubNetworkName", "__Internal")]
		NSString kAppodealMopubNetworkName { get; }

		// extern NSString *const kAppodealMRAIDNetworkName;
		[Field("kAppodealMRAIDNetworkName", "__Internal")]
		NSString kAppodealMRAIDNetworkName { get; }

		// extern NSString *const kAppodealOpenXNetworkName;
		[Field("kAppodealOpenXNetworkName", "__Internal")]
		NSString kAppodealOpenXNetworkName { get; }

		// extern NSString *const kAppodealTapSenceNetworkName;
		[Field("kAppodealTapSenceNetworkName", "__Internal")]
		NSString kAppodealTapSenceNetworkName { get; }

		// extern NSString *const kAppodealUnityAdsNetworkName;
		[Field("kAppodealUnityAdsNetworkName", "__Internal")]
		NSString kAppodealUnityAdsNetworkName { get; }

		// extern NSString *const kAppodealVungleNetworkName;
		[Field("kAppodealVungleNetworkName", "__Internal")]
		NSString kAppodealVungleNetworkName { get; }

		// extern NSString *const kAppodealSmaatoNetworkName;
		[Field("kAppodealSmaatoNetworkName", "__Internal")]
		NSString kAppodealSmaatoNetworkName { get; }

		// extern NSString *const kAppodealYandexNetworkName;
		[Field("kAppodealYandexNetworkName", "__Internal")]
		NSString kAppodealYandexNetworkName { get; }

		// extern NSString *const kAppodealStartAppNetworkName;
		[Field("kAppodealStartAppNetworkName", "__Internal")]
		NSString kAppodealStartAppNetworkName { get; }

		// extern NSString *const kAppodealAppNexusNetworkName;
		[Field("kAppodealAppNexusNetworkName", "__Internal")]
		NSString kAppodealAppNexusNetworkName { get; }

		// extern NSString *const kAppodealRubiconNetworkName;
		[Field("kAppodealRubiconNetworkName", "__Internal")]
		NSString kAppodealRubiconNetworkName { get; }

		// extern NSString *const kAppodealAvocarrotNetworkName;
		[Field("kAppodealAvocarrotNetworkName", "__Internal")]
		NSString kAppodealAvocarrotNetworkName { get; }

		// extern NSString *const kAppodealPubNativeNetworkName;
		[Field("kAppodealPubNativeNetworkName", "__Internal")]
		NSString kAppodealPubNativeNetworkName { get; }

		// extern NSString *const kAppodealFlurryNetworkName;
		[Field("kAppodealFlurryNetworkName", "__Internal")]
		NSString kAppodealFlurryNetworkName { get; }

		// extern NSString *const kAppodealLiveRailNetworkName;
		[Field("kAppodealLiveRailNetworkName", "__Internal")]
		NSString kAppodealLiveRailNetworkName { get; }

		// extern NSString *const kAppodealSpotXNetworkName;
		[Field("kAppodealSpotXNetworkName", "__Internal")]
		NSString kAppodealSpotXNetworkName { get; }

		// extern NSString *const kAppodealVASTNetworkName;
		[Field("kAppodealVASTNetworkName", "__Internal")]
		NSString kAppodealVASTNetworkName { get; }

		// extern NSString *const kAppodealInnerActiveNetworkName;
		[Field("kAppodealInnerActiveNetworkName", "__Internal")]
		NSString kAppodealInnerActiveNetworkName { get; }

		// extern NSString *const kAppodealMillenialMediaNetworkName;
		[Field("kAppodealMillenialMediaNetworkName", "__Internal")]
		NSString kAppodealMillenialMediaNetworkName { get; }

		// extern NSString *const kAppodealNativeTestNetworkName;
		[Field("kAppodealNativeTestNetworkName", "__Internal")]
		NSString kAppodealNativeTestNetworkName { get; }
	}

	[Static]
	partial interface UnitSizes
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

	// @protocol AppodealBannerViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface AppodealBannerViewDelegate
	{
		// @optional -(void)bannerViewDidLoadAd:(AppodealBannerView *)bannerView;
		[Export("bannerViewDidLoadAd:")]
		void BannerViewDidLoadAd(AppodealBannerView bannerView);

		// @optional -(void)bannerView:(AppodealBannerView *)bannerView didFailToLoadAdWithError:(NSError *)error;
		[Export("bannerView:didFailToLoadAdWithError:")]
		void BannerView(AppodealBannerView bannerView, NSError error);

		// @optional -(void)bannerViewDidInteract:(AppodealBannerView *)bannerView;
		[Export("bannerViewDidInteract:")]
		void BannerViewDidInteract(AppodealBannerView bannerView);
	}


	// @interface AppodealBannerView : UIView
	[BaseType(typeof(UIView))]
	interface AppodealBannerView
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		AppodealBannerViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<AppodealBannerViewDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }


		// @property (readonly, getter = isReady, assign, nonatomic) BOOL ready;
		[Export("ready")]
		bool Ready { [Bind("isReady")] get; }

		// -(instancetype)initWithSize:(CGSize)size rootViewController:(UIViewController *)rootViewController;
		[Export("initWithSize:rootViewController:")]
		IntPtr Constructor(CGSize size, UIViewController rootViewController);

		// -(void)loadAd;
		[Export("loadAd")]
		void LoadAd();
	}

	// @interface AppodealMRECView : AppodealBannerView
	[BaseType(typeof(AppodealBannerView))]
	interface AppodealMRECView
	{
		// -(instancetype)initWithRootViewController:(UIViewController *)rootViewController;
		[Export("initWithRootViewController:")]
		IntPtr Constructor(UIViewController rootViewController);
	}

	// @interface APDImage : NSObject
	[BaseType(typeof(NSObject))]
	interface APDImage
	{
		// @property (readonly, assign, nonatomic) CGSize size;
		[Export("size", ArgumentSemantic.Assign)]
		CGSize Size { get; }

		// @property (readonly, copy, nonatomic) NSURL * imageUrl;
		[Export("imageUrl", ArgumentSemantic.Copy)]
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
	[BaseType(typeof(NSObject))]
	interface APDNativeAdLoaderDelegate
	{
		// - (void)nativeAdLoader:(APDNativeAdLoader *)loader didLoadNativeAd:(APDNativeAd *)nativeAd;
		[Export("nativeAdLoader:didLoadNativeAd:")]
		void NativeAdLoader(APDNativeAdLoader loader, APDNativeAd nativeAd);

		// - (void)nativeAdLoader:(APDNativeAdLoader *)loader didFailToLoadWithError:(NSError *)error;
		[Export("nativeAdLoader:didFailToLoadWithError:")]
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
	[BaseType(typeof(NSObject))]
	interface APDNativeAd
	{
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

		// @property (readonly, nonatomic, strong) AppodealImage * mainImage;
		[Export("mainImage", ArgumentSemantic.Strong)]
		APDImage MainImage { get; }

		// @property (readonly, nonatomic, strong) AppodealImage * iconImage;
		[Export("iconImage", ArgumentSemantic.Strong)]
		APDImage IconImage { get; }

		// @property (nonatomic, strong, readonly) UIView * adChoicesView;
		[Export("adChoicesView", ArgumentSemantic.Strong)]
		UIView AdChoicesView { get; }

		// @property (nonatomic, readonly, getter=isContainsVideo) BOOL containsVideo;
		[Export("containsVideo", ArgumentSemantic.Strong)]
		bool Ready { [Bind("isContainsVideo")] get; }

		// -(void)attachToView:(UIView *)view viewController:(UIViewController *)viewController;
		[Export("attachToView:viewController:")]
		void AttachToView(UIView view, UIViewController viewController);

		// -(void)detachFromView;
		[Export("detachFromView")]
		void DetachFromView();
	}

	// @interface Appodeal : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface Appodeal
	{
		// +(void)disableNetworkForAdType:(AppodealAdType)adType name:(NSString *)networkName;
		[Static]
		[Export("disableNetworkForAdType:name:")]
		void DisableNetworkForAdType(AppodealAdType adType, string networkName);

		// +(void)disableLocationPermissionCheck;
		[Static]
		[Export("disableLocationPermissionCheck")]
		void DisableLocationPermissionCheck();

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

		// + (void)setFramework:(APDFramework)framework;
		[Static]
		[Export("setFramework:")]
		void SetFramework(APDFramework framework);

		// +(BOOL)isInitalized;
		[Static]
		[Export("isInitalized")]
		bool IsInitalized { get; }

		// +(void)setInterstitialDelegate:(id<AppodealInterstitialDelegate>)interstitialDelegate;
		[Static]
		[Export("setInterstitialDelegate:")]
		void SetInterstitialDelegate(AppodealInterstitialDelegate interstitialDelegate);

		// +(void)setBannerDelegate:(id<AppodealBannerDelegate>)bannerDelegate;
		[Static]
		[Export("setBannerDelegate:")]
		void SetBannerDelegate(AppodealBannerDelegate bannerDelegate);

		// +(void)setVideoDelegate:(id<AppodealVideoDelegate>)videoDelegate;
		[Static]
		[Export("setSkippableVideoDelegate:")]
		void SetSkippableVideoDelegate(AppodealSkippableVideoDelegate skippableVideoDelegate);

		// +(void)setRewardedVideoDelegate:(id<AppodealRewardedVideoDelegate>)rewardedVideoDelegate;
		[Static]
		[Export("setRewardedVideoDelegate:")]
		void SetRewardedVideoDelegate(AppodealRewardedVideoDelegate rewardedVideoDelegate);

		// +(UIView *)banner;
		[Static]
		[Export("banner")]
		UIView Banner { get; }

		// +(BOOL)showAd:(AppodealShowStyle)style rootViewController:(UIViewController *)rootViewController;
		[Static]
		[Export("showAd:rootViewController:")]
		bool ShowAd(AppodealShowStyle style, UIViewController rootViewController);

		// + (BOOL)showAd:(AppodealShowStyle)style forPlacement:(NSString *)placement rootViewController:(UIViewController *)rootViewController;
		[Static]
		[Export("showAd:forPlacement:rootViewController:")]
		bool showAd(AppodealShowStyle style, string placement, UIViewController rootViewController);

		// +(void)cacheAd:(AppodealAdType)type;
		[Static]
		[Export("cacheAd:")]
		void CacheAd(AppodealAdType type);

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

		// +(NSString *)getVersion;
		[Static]
		[Export("getVersion")]
		string Version { get; }

		// +(BOOL)isReadyForShowWithStyle:(AppodealShowStyle)showStyle;
		[Static]
		[Export("isReadyForShowWithStyle:")]
		bool IsReadyForShowWithStyle(AppodealShowStyle showStyle);

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
		[Export("confirmUsage:")]
		void ConfirmUsage(AppodealAdType adTypes);

		// + (void)setUserId:(NSString *)userId;
		[Static]
		[Export("setUserId:")]
		void SetUserId(NSString userId);

		// + (void)setUserEmail:(NSString*)email;
		[Static]
		[Export("setUserEmail:")]
		void SetUserEmail(NSString email);

		// + (void)setUserBirthday:(NSDate *)birthday;
		[Static]
		[Export("setUserBirthday:")]
		void SetUserBirthday(NSDate birthday);

		// + (void)setUserAge:(NSUInteger)age;
		[Static]
		[Export("setUserAge:")]
		void SetUserAge(uint age);

		// + (void)setUserGender:(AppodealUserGender)gender;
		[Static]
		[Export("setUserGender:")]
		void SetUserGender(AppodealUserGender gender);

		// + (void)setUserOccupation:(AppodealUserOccupation)occupation;
		[Static]
		[Export("setUserOccupation:")]
		void SetUserOccupation(AppodealUserOccupation occupation);

		// + (void)setUserRelationship:(AppodealUserRelationship)relationship;
		[Static]
		[Export("setUserRelationship:")]
		void SetUserRelationship(AppodealUserRelationship relationship);

		// + (void)setUserSmokingAttitude:(AppodealUserSmokingAttitude)smokingAttitude;
		[Static]
		[Export("setUserSmokingAttitude:")]
		void SetUserSmokingAttitude(AppodealUserSmokingAttitude smokingAttitude);

		// + (void)setUserAlcoholAttitude:(AppodealUserAlcoholAttitude)alcoholAttitude;
		[Static]
		[Export("setUserAlcoholAttitude:")]
		void SetUserAlcoholAttitude(AppodealUserAlcoholAttitude alcoholAttitude);

		// + (void)setUserInterests:(NSString *)interests;
		[Static]
		[Export("setUserInterests:")]
		void SetUserInterests(NSString interests);
	}
}
