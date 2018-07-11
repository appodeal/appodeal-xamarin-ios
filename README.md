# Appodeal iOS SDK Xamarin Bindings

## Download



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
        
        // +(BOOL)isInitalized;
        [Static]
        [Export("isInitalized")]
        [Verify(MethodToProperty)]
        bool IsInitalized { get; }

  * Should look like:
        
        // +(BOOL)isInitalized;
        [Static]
        [Export("isInitalized")]
        bool IsInitalized { get; }

+ The namespace 'AppodealBinding' already contains a definition for 'APDUserInfo'
 * Remove one copy of APDUserInfo interface

+ Type 'APDRewardedVideoDelegate' already defines a member called 'RewardedVideo' with the same parameter types (CS0111) | Type 'APDSkippableVideoDelegate' already defines a member called 'SkippableVideo' with the same parameter types | Type 'APDBannerViewRequestDelegate' already defines a member called 'BannerView' with the same parameter types | Type 'APDInterstitalAdRequestDelegate' already defines a member called 'Interstitial' with the same parameter types
 * Copy name for method from [Export()] line and paste to void. Example:
 
        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToPresentWithError:(NSError *)error;
        [Export("rewardedVideo:didFailToPresentWithError:")]
        void RewardedVideo(APDRewardedVideo rewardedVideo, NSError error);

 should become 
 
        // @optional -(void)rewardedVideo:(APDRewardedVideo *)rewardedVideo didFailToPresentWithError:(NSError *)error;
        [Export("rewardedVideo:didFailToPresentWithError:")]
        void RewardedVideoDidFailToPresentWithError(APDRewardedVideo rewardedVideo, NSError error);

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

11. Select `Release` on the top and press `Build`. `AppodealBindings.dll` should appear in `bin/Release` folder.
