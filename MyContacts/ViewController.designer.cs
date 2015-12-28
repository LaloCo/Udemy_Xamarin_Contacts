// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyContacts
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField emailTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField fullNameTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton imageButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView photoImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem saveButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (emailTextField != null) {
				emailTextField.Dispose ();
				emailTextField = null;
			}
			if (fullNameTextField != null) {
				fullNameTextField.Dispose ();
				fullNameTextField = null;
			}
			if (imageButton != null) {
				imageButton.Dispose ();
				imageButton = null;
			}
			if (photoImageView != null) {
				photoImageView.Dispose ();
				photoImageView = null;
			}
			if (saveButton != null) {
				saveButton.Dispose ();
				saveButton = null;
			}
		}
	}
}
