// WARNING: This feature is deprecated. Use the "Native References" folder instead.
// Right-click on the "Native References" folder, select "Add Native Reference",
// and then select the static library or framework that you'd like to bind.
//
// Once you've added your static library or framework, right-click the library or
// framework and select "Properties" to change the LinkWith values.

using ObjCRuntime;
using System;

[assembly: LinkWith("Appodeal.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.x86_64 | LinkTarget.ArmV6 | LinkTarget.i386, SmartLink = true, Frameworks = "AdSupport AudioToolbox AVFoundation CFNetwork CoreFoundation CoreGraphics CoreImage CoreLocation CoreMedia CoreMotion CoreTelephony EventKit EventKitUI JavaScriptCore MediaPlayer MessageUI MobileCoreServices QuartzCore SafariServices Security Social StoreKit SystemConfiguration Twitter UIKit WebKit CoreBluetooth GLKit", ForceLoad = true, LinkerFlags = "-lz -lsqlite3 -lxml2.2 -lc++ -ObjC")]