This project has been created to demonstrate memory leaks by implementing the [MemoryToolkit.Maui](https://github.com/AdamEssenmacher/MemoryToolkit.Maui), as well as a memory tracker.
It works by navigating to pages that consist only of an element suspected of leaking, followed by navigating back. These pages also hold a large amount of memory through a byte[].

After navigating back a popup will be shown if it has leaked. The memory tracker would also clearly increase by a large amount, which it will continue to do every navigation back-and-forth.

Note that for the SyncFusion demonstration to work, a working license key has to be added in MauiProgram.cs (named 'SyncFusionLicenseKey').
