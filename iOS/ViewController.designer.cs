// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NativeReferenceApp.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NativeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView NativeTextView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NativeButton != null) {
                NativeButton.Dispose ();
                NativeButton = null;
            }

            if (NativeTextView != null) {
                NativeTextView.Dispose ();
                NativeTextView = null;
            }
        }
    }
}