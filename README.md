# Memory Leak Demonstration

This project has been created to demonstrate memory leaks by implementing the [MemoryToolkit.Maui](https://github.com/AdamEssenmacher/MemoryToolkit.Maui), as well as a memory tracker.

It works by navigating to pages that consist only of an element suspected of leaking, followed by navigating back. These pages also hold a large amount of memory through a byte[].

After navigating back a popup will be shown if it has leaked. The memory tracker will also clearly increase by a large amount if the entire page is leaked, seen while navigating back-and-forth.

The SyncFusion license can optionally be added in MauiProgram.cs, but is not necessary to demonstrate these leaks.

This project uses the [MAUI nightly](https://dev.azure.com/xamarin/public/_artifacts/feed/maui-nightly/NuGet/Microsoft.Maui.Controls/versions/8.0.60-ci.net8.24304.1) to avoid any already pending fixes. Currently using version: **8.0.60-ci.net8.24304.1**.

Currently demonstrating the following leaks:

- **CollectionView** on iOS: Leaks any content set in the Header or Footer.
- **SfDataGrid** on iOS: [SyncFusion Bug Report #58293](https://www.syncfusion.com/feedback/58293/sfdatagrid-causes-a-memory-leak-in-maui-ios-and-macos)
- **SfListView** on iOS: [SyncFusion Bug Report #58309](https://www.syncfusion.com/feedback/58309/sflistview-causes-a-memory-leak-in-maui-ios-and-macos)
- **SyncFusion Popup** on iOS and Android: [SyncFusion Bug Report #58300](https://www.syncfusion.com/feedback/58300/sfpopup-causes-a-memory-leak-in-maui-ios-macos-and-android)

![afbeelding](https://github.com/EGoverde/MemoryLeaks/assets/3169710/4a8cdd6a-72be-4643-8514-d973db396e55)