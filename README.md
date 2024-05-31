# Memory Leak Demonstration

This project has been created to demonstrate memory leaks by implementing the [MemoryToolkit.Maui](https://github.com/AdamEssenmacher/MemoryToolkit.Maui), as well as a memory tracker.
It works by navigating to pages that consist only of an element suspected of leaking, followed by navigating back. These pages also hold a large amount of memory through a byte[].

After navigating back a popup will be shown if it has leaked. The memory tracker would also clearly increase by a large amount, which it will continue to do every navigation back-and-forth.

The SyncFusion license can optionally be added in MauiProgram.cs, but is not necessary to demonstrate these leaks.

Currently demonstrating the following leaks:

- **SfDataGrid** on iOS: [https://www.syncfusion.com/feedback/58293/sfdatagrid-and-sflistview-cause-a-memory-leak-in-maui-ios-and-macos](https://www.syncfusion.com/feedback/58293/sfdatagrid-causes-a-memory-leak-in-maui-ios-and-macos)
- **SfListView** on iOS: [https://www.syncfusion.com/feedback/58309/sflistview-causes-a-memory-leak-in-maui-ios-and-macos](https://www.syncfusion.com/feedback/58309/sflistview-causes-a-memory-leak-in-maui-ios-and-macos)
- **SyncFusion Popup** on iOS and Android: [https://www.syncfusion.com/feedback/58300/sfpopup-causes-a-memory-leak-in-maui-ios-macos-and-android](https://www.syncfusion.com/feedback/58300/sfpopup-causes-a-memory-leak-in-maui-ios-macos-and-android)