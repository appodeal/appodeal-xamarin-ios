# Appodeal iOS SDK Xamarin Bindings

## Download

[![](https://img.shields.io/badge/download-ios-grey.svg)](https://s3.amazonaws.com/appodeal-xamarin/iOS/2.1.10/Appodeal-Xamarin-iOS-2.1.10-100718.zip)

## How to update manually

Please follow this steps to update AppodealBindings.dll to hte latest Appodeal iOS SDK:

1. First of all Clone this repository with: `git clone https://github.com/appodeal/appodeal-xamarin-ios.git`.
2. Download latest Appodeal iOS Fat SDK: [stable](https://appodeal.com/sdk/ios) or [beta](https://appodeal.com/sdk/ios_beta).
3. Unzip downloaded Appodeal iOS SDK somewhere.
4. Install sharpie tool following [this](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/get-started?context=xamarin/ios) doc if not installed yet.
4. Open `Terminal.app` on your Mac. Go to the folder with unzipped Appodeal iOS SDK with `cd` command.
5. Run following command in the terminal ():

```bash
sharpie xcode -sdks
```

it will return the list of installed XCode SDKs, like this:

```bash
sdk: appletvos11.4    arch: arm64   
sdk: iphoneos11.4     arch: arm64   armv7   
sdk: macosx10.13      arch: x86_64  i386    
sdk: watchos4.3       arch: armv7k 
```

`iphoneos11.4` is the sdk you will use to generate bindings.

6. Now lets generate bindings for Appodeal iOS SDK. In this step we will go through a loop process. Run following command for each base header file:

```bash
sharpie bind -sdk iphoneos11.4 Appodeal.framework/Headers/APDDefines.h -scope Appodeal.framework/Headers -c -F .
```

This will generate `ApiDefinitions.cs` file with imports and interfaces and `StructsAndEnums.cs` if header contains some enums and structures. Rename this files to something like `ApiDefinitionsAPDDefines.cs`, `StructsAndEnumsAPDDefines.cs` and leave it there.

Now do the same process for each header in `Appodeal.framework/Headers` folder, run this command:

```bash
sharpie bind -sdk iphoneos11.4 Appodeal.framework/Headers/[header] -scope Appodeal.framework/Headers -c -F .
```

`[header]` should be replaces to the header name.


Now Open `AppodealBinding.sln` with *Visual Studio for Mac*. Open `ApiDefinition.cs` and `StructsAndEnums.cs` source files.
Then open your generated `ApiDefinitions[name].cs` and `StructsAndEnums[name].cs` one by one and copy new code to corresponding source file of `AppodealBinding.sln`

Warning: `ApiDefinition.cs` and `StructsAndEnums.cs` should be under `AppodealBinding` *namespace*.

Note: `sharpie` generated some blocks with errors and with `[verify(*)]` blocks. Lets review some usual errors you should fix:
+ Interfaces has the name `Constants` and verify block.
   * Check the name of included constants, for example it includes `kAppodealUnitSize_320x50`, `kAppodealUnitSize_300x250`, `kAppodealUnitSize_728x90`. As you see it has identical content `AppodealUnitSize`, so change interface name from `Constants` to `AppodealUnitSize`.
+ All `public enum`s with `nuint` or `nint` type.
   * Change `nuint` or `nint` to `ulong`.
+ Some `public enum`s contains numbers with `L` or `uL` suffix.
   * Remove this suffixes.
+ Some methods ot interfaces contains `[Verify(*)]` lines. It is the code you should review.
   * Usually it is generated for getters or setters, just remove `[Verify(*)]` line and save file. For example:
        
        ```
        // +(BOOL)isInitalized;
        [Static]
        [Export("isInitalized")]
        [Verify(MethodToProperty)]
        bool IsInitalized { get; }
        ```

   * Should look like:
        
        ```
        // +(BOOL)isInitalized;
        [Static]
        [Export("isInitalized")]
        bool IsInitalized { get; }
        ```

+ The namespace 'AppodealBinding' already contains a definition for 'APDUserInfo'
  * Remove one copy of APDUserInfo interface

+ Type 'APDRewardedVideoDelegate' already defines a member called 'RewardedVideo' with the same parameter types (CS0111) | Type 'APDSkippableVideoDelegate' already defines a member called 'SkippableVideo' with the same parameter types | Type 'APDBannerViewRequestDelegate' already defines a member called 'BannerView' with the same parameter types | Type 'APDInterstitalAdRequestDelegate' already defines a member called 'Interstitial' with the same parameter types
   * Copy name for method from [Export()] line and paste to void. Example:
        
```
// @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToPresentWithError:(NSError *)error;
[Export("rewardedVideo:didFailToPresentWithError:")]
void RewardedVideo(APDRewardedVideo rewardedVideo, NSError error);
```

should become 

```
// @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToPresentWithError:(NSError *)error;
[Export("rewardedVideo:didFailToPresentWithError:")]
void RewardedVideoDidFailToPresentWithError(APDRewardedVideo rewardedVideo, NSError error);
```

+ The type or namespace name 'VerifyAttribute' could not be found (are you missing a using directive or an assembly reference?) (CS0246)
   * Remove [Verify(MethodToProperty)] line.
+ The type or namespace name 'IAPDUserInfo' could not be found (are you missing a using directive or an assembly reference?) 
   * Remove this intefrace.
+ The type or namespace name 'APDUserInfo' could not be found (are you missing a using directive or an assembly reference?)
   * Remove this method.

7. In the folder where you have extracted *Appodeal iOS SDK* open `Appodeal.framework` as folder. There should be `Appodeal`
binnary file. Rename it to `Appodeal.a` and copy to the folder with AppodealBinding project.

8. In Vusial Studio do the Right click on `Native References` and press `Add Native Reference`. Select `Appodeal.a` you have copied in the step before.

9. Right Click on appeared in *Native References* `Appodeal` and click `Properties`. If window with peroperties blank, press on `Appodeal` in *Native References* one more time.

10. In the `Frameworks` field of `Appodeal` *Properties* check if any changes were made for *Native Appodeal iOS SDK*. Check [stable](https://appodeal.com/sdk/ios) for stable sdk, and [beta](https://appodeal.com/sdk/ios_beta) for beta sdk in section *Manual Integration* -> step #3. Libraries with `lib` prefix should be passed to `Linker Flags` as `-l`, for example `libc++` should be passed as `-lc++`.

Current list of Frameworks for Appodeal iOS SDK 2.1.10:

`AdSupport AudioToolbox AVFoundation CFNetwork CoreGraphics CoreImage CoreLocation CoreMedia CoreMotion CoreTelephony EventKitUI GLKit ImageIO JavaScriptCore MediaPlayer MessageUI MobileCoreServices QuartzCore Security StoreKit SystemConfiguration UIKit WebKit`

Current list of `Linker Flags` for Appodeal iOS SDK 2.1.10:

`-lc++ -lsqlite3 -lxml2.2 -lz`

11. Select `Release` on the top and press `Build`. `AppodealBindings.dll` should appear in `bin/Release` folder.

## Binding Integration

### Plugin Files Integration

Go the the "Project" -> "Edit references" and add there "AppodealBinding.dll" in ".Net Assembly" tab.

![netassembly](https://i.gyazo.com/c8932ef03fbc79ee4ba6247b91f96dcd.png)

Next step is to add Resources from iOS SDK you have downloaded earlier. Right-click on Resources in your project tree view, select "Add files from folder" and choose "Resources" folder from unpacked iOS SDK. After that you should see something like that:

![resources](https://i.gyazo.com/57efdcbab05a31cf0e530f9006862819.png)

For successful complie you should set these settings in your Project options (Note: plugin is not compatible armv7s architecture) :

![appsettings](https://i.gyazo.com/ef1e4fdde3b40fb51214557cb14152b7.png)

### API Integration

#### Ad Types & Show Styles

+ AppodealAdType.Banner
+ AppodealAdType.Interstitial (Fullscreen ad)
+ AppodealAdType.Mrec (Banner 300*250)
+ AppodealAdType.NativeAd
+ AppodealAdType.NonSkippableVideo
+ AppodealAdType.RewardedVideo (same as NonSkippableVideo but with reward - use only ONE type of NonSkippableVideo(RewardedVideo is more likely to use))

Ad types can be combined using "|" operator. For example AppodealAdType.Interstitial | AppodealAdType.NonSkippableVideo

+ AppodealShowStyle.BannerTop
+ AppodealShowStyle.BannerBottom
+ AppodealShowStyle.Interstitial (Banner 300*250)
+ AppodealShowStyle.Mrec
+ AppodealShowStyle.NonSkippableVideo
+ AppodealShowStyle.RewardedVideo 
+ AppodealShowStyle.NativeAd

#### SDK Initialization

```csharp
Appodeal.SetFramework(APDFramework.Xamarin);
Appodeal.InitializeWithApiKey(YOUR_APPLICATION_KEY, SELECTED_AD_TYPES);
```

In AppDelegate.FinishedLaunching method add Appodeal initialization:

```charp
using AppodealAds;

public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
{
// Override point for customization after application launch.
// If not required for your application you can safely delete this method
  String appKey = "e7e04e54ae0a8d28cff2f7e7e7d094e78b2a09743be2cc4a";
  
Appodeal.SetFramework(APDFramework.APDFrameworkXamarin);  //this is required method, just copy-paste it before init
Appodeal.InitializeWithApiKey(appKey, AppodealAdType.Banner | AppodealAdType.Interstitial);

return true;
}
```

#### Display Ad

```charp
Appodeal.ShowAd(SHOW_STYLE, UIApplication.SharedApplication.Windows[0].RootViewController);
```

#### Setting up callbacks

##### Interstitial

Add your custom class with inherited `AppodealInterstitialDelegate`:

```csharp
public class MyInterstitialDelegate : AppodealInterstitialDelegate
{
    public override void InterstitialDidLoadAdisPrecache(bool precache) {
        Console.WriteLine("InterstitialDidLoadAdisPrecache");
    }

    public override void InterstitialDidFailToLoadAd() { 
        Console.WriteLine("InterstitialDidFailToLoadAd");
    }

    public override void InterstitialDidFailToPresent() { 
        Console.WriteLine("InterstitialDidFailToPresent");
    }

    public override void InterstitialWillPresent() { 
        Console.WriteLine("InterstitialWillPresent");
    }

    public override void InterstitialDidDismiss() {
        Console.WriteLine("InterstitialDidDismiss");
    }

    public override void InterstitialDidClick() { 
        Console.WriteLine("InterstitialDidClick");
    }
}
```

Then set it after SDK initialization:

```csharp
Appodeal.SetInterstitialDelegate(new MyInterstitialDelegate());
```

##### Banner

Add your custom class with inherited `AppodealBannerDelegate`:

```csharp
public class MyBannerDelegate : AppodealBannerDelegate
{
    public override void BannerDidFailToLoadAd()
    {
        Console.WriteLine("BannerDidFailToLoadAd");
    }

    public override void BannerDidLoadAdIsPrecache(bool precache)
    {
        Console.WriteLine("BannerDidLoadAdIsPrecache");
    }

    public override void BannerDidShow()
    {
        Console.WriteLine("BannerDidShow");
    }

    public override void BannerDidClick()
    {
        Console.WriteLine("BannerDidClick");
    }

    public override void BannerDidRefresh()
    {
        Console.WriteLine("BannerDidRefresh");
    }
}
```

Then set it after SDK initialization:

```csharp
Appodeal.SetBannerDelegate(new MyBannerDelegate());
```

##### Rewarded Video

Add your custom class with inherited `AppodealRewardedVideoDelegate`:

```csharp
public class MyRewardedVideoDelegate : AppodealRewardedVideoDelegate
{
    public override void RewardedVideoDidLoadAd()
    {
        Console.WriteLine("RewardedVideoDidLoadAd");
    }

    public override void RewardedVideoWillDismiss()
    {
        Console.WriteLine("RewardedVideoWillDismiss");
    }

    public override void RewardedVideoDidFailToLoadAd()
    {
        Console.WriteLine("RewardedVideoDidFailToLoadAd");
    }

    public override void RewardedVideoDidClick()
    {
        Console.WriteLine("RewardedVideoDidClick");
    }

    public override void RewardedVideoDidPresent()
    {
        Console.WriteLine("RewardedVideoDidPresent");
    }

    public override void RewardedVideoDidFailToPresent()
    {
        Console.WriteLine("RewardedVideoDidFailToPresent");
    }

    public override void RewardedVideoDidFinish(nuint rewardAmount, string rewardName)
    {
        Console.WriteLine("RewardedVideoDidFinish");
    }
}
```

Then set it after SDK initialization:

```csharp
Appodeal.SetRewardedVideoDelegate(new MyRewardedVideoDelegate());
```

##### Non Skippable Video

Add your custom class with inherited `AppodealNonSkippableVideoDelegate`:

```csharp
public class MyNonSkippableVideoViewDelegate : AppodealNonSkippableVideoDelegate
{
    public override void NonSkippableVideoDidLoadAd()
    {
        Console.WriteLine("NonSkippableVideoDidLoadAd");
    }

    public override void NonSkippableVideoDidFailToLoadAd()
    {
        Console.WriteLine("NonSkippableVideoDidFailToLoadAd");
    }

    public override void NonSkippableVideoDidClick()
    {
        Console.WriteLine("NonSkippableVideoDidClick");
    }

    public override void NonSkippableVideoDidPresent()
    {
        Console.WriteLine("NonSkippableVideoDidPresent");
    }

    public override void NonSkippableVideoDidFailToPresent()
    {
        Console.WriteLine("NonSkippableVideoDidFailToPresent");
    }

    public override void NonSkippableVideoWillDismiss()
    {
        Console.WriteLine("NonSkippableVideoWillDismiss");
    }

    public override void NonSkippableVideoDidFinish()
    {
        Console.WriteLine("NonSkippableVideoDidFinish");
    }
}
```

Then set it after SDK initialization:

```csharp
Appodeal.SetNonSkippableVideoDelegate(new MyNonSkippableVideoViewDelegate());
```

### Native ads integration

First step is to create class for initializing native ad loader callbacks:

```csharp
public class MyNativeAdDelegate : APDNativeAdLoaderDelegate
{
  ViewController _controller = null;

      public MyNativeAdDelegate(ViewController controller)
  {		
    _controller = controller;		
  }

      public override void DidFailToLoadWithError(APDNativeAdLoader loader, NSError error)
      {
          Console.WriteLine("APDNativeAd DidFailToLoadWithError");
      }

      public override void DidLoadNativeAds(APDNativeAdLoader loader, APDNativeAd[] nativeAds)
      {
          Console.WriteLine("APDNativeAd DidLoadNativeAds");
          _controller.MyNativeAdDelegateServiceDidLoad(nativeAds[0]);
      }				

}
```

Second step is to create nativeAdLoader and nativeAd in your ViewController class Also you need to create public method to get all native attributes, you can also add here mediaView to display media content from loaded native ad:

```csharp
public partial class ViewController : UIViewController
{
		APDNativeAdLoader nativeAdLoader;
		APDNativeAd nativeAd;
		APDMediaView myMediaView; //media view is used to attach some media content from native ad to your view

    public void MyDelegateServiceDidLoad(APDNativeAd nativeAd)
		{
			this.nativeAd = nativeAd;
			UIView view = new UIView(); //creating a view to attach native ad 
			view.Frame = new System.Drawing.Rectangle(10, 350, 200, 200); //required
			view.BackgroundColor = UIColor.FromRGB(96, 36, 36); //optional
			View.AddSubview(view);
			this.nativeAd.AttachToView(view, UIApplication.SharedApplication.Windows[0].RootViewController); //attaching native ad to created view
			this.myMediaView.SetNativeAd(this.nativeAd, this); //setting media view to loaded native ad
			View.AddSubview(this.myMediaView); 
			Console.WriteLine(this.nativeAd.Title);
			Console.WriteLine(this.nativeAd.Subtitle);
			Console.WriteLine(this.nativeAd.StarRating);
			Console.WriteLine(this.nativeAd.MainImage); //APDImage inheritor
			Console.WriteLine(this.nativeAd.IconImage); //APDImage inheritor
			Console.WriteLine(this.nativeAd.DescriptionText);
			Console.WriteLine(this.nativeAd.ContentRating);
			Console.WriteLine(this.nativeAd.CallToActionText);
			Console.WriteLine(this.nativeAd.AdChoicesView); //UIView inheritor, should be displayed anyway if it's not nil
		}
	...
	}
```

Last step is creating native ad loader in your view controller, delegating it and loading the ad. Also you can create mediaView here with needed frame:

```csharp
public override void ViewDidLoad ()
{
  ...
  this.nativeAdLoader = new APDNativeAdLoader();		
  this.myMediaView = new APDMediaView(new CGRect(10, 350, 200, 200));
  this.nativeAdLoader.Delegate = new MyDelegate(this);
  this.nativeAdLoader.LoadAdWithType(APDNativeAdType.APDNativeAdTypeAuto);
  ...
}
```

### Advanced Features

Enabling test mode

```csharp
Appodeal.SetTestingEnabled(true);
```

Checking if ad is loaded

```csharp
Appodeal.IsReadyForShowWithStyle(showStyle);
```

Manual ad caching

```csharp
Appodeal.CacheAd(adTypes);
```

You should disable automatic caching before SDK initialization using `SetAutoCache(false, adTypes)`.

Enabling or disabling automatic caching

```csharp
Appodeal.SetAutoCache(adTypes, false);
```

Should be used before SDK initialization

Disabling networks

```csharp
Appodeal.DisableNetworkForAdType(adTypes, (String)network);
```

Enable/disable smart banners

```csharp
Appodeal.SetSmartBannersEnabled(true);
```

Enable/disable banner refresh animation

```csharp
Appodeal.SetBannerAnimationEnabled(true);
```

Enable/disable banner background

```csharp
Appodeal.SetBannerBackgroundVisible(true);
```
