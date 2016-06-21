using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppodealBinding
{
	static class CFunctions
	{
		// extern NSString * AppodealPrettyNetworkName (NSString *networkName);
		[DllImport ("__Internal")]
		static extern NSString AppodealPrettyNetworkName (NSString networkName);

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

		// extern NSString * AppodealSdkVersionString ();
		[DllImport ("__Internal")]
		static extern NSString AppodealSdkVersionString ();

		// extern NSString * AppodealApiVersionString ();
		[DllImport ("__Internal")]
		static extern NSString AppodealApiVersionString ();
	}

	[Native]
	public enum AppodealUserGender : ulong
	{
		Other = 0,
		Male,
		Female
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
	public enum AppodealVideoEvent : ulong
	{
		Start = 0,
		Finish,
		Skip,
		FirstQurtile,
		Midpoint,
		ThirdQurtile,
		Click,
		Ready,
		Error
	}

	[Native]
	public enum AppodealNativeAdViewType : ulong
	{
		NewsFeed = 1,
		ContentStream,
		AppodealNativeAdType320x50,
		AppodealNativeAdType728x90
	}

	[Native]
	public enum AppodealAdType : ulong
	{
		Interstitial = 1 << 0,
		SkippableVideo = 1 << 1,
		Video = SkippableVideo,
		Banner = 1 << 2,
		NativeAd = 1 << 3,
		RewardedVideo = 1 << 4,
		Mrec = 1 << 5,
		NonSkippableVideo = RewardedVideo,
		All = Interstitial | SkippableVideo | Banner | NativeAd | RewardedVideo
	}

	[Native]
	public enum AppodealShowStyle : ulong
	{
		Interstitial = 1,
		SkippableVideo,
		VideoOrInterstitial,
		BannerTop,
		BannerCenter,
		BannerBottom,
		RewardedVideo,
		Video = SkippableVideo,
		NonSkippableVideo = RewardedVideo
	}
}

