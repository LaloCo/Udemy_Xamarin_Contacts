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
	[Register ("DetailsViewController")]
	partial class DetailsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel detailsEmailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel detailsNameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView detailsPhotoImageView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton emailButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (detailsEmailLabel != null) {
				detailsEmailLabel.Dispose ();
				detailsEmailLabel = null;
			}
			if (detailsNameLabel != null) {
				detailsNameLabel.Dispose ();
				detailsNameLabel = null;
			}
			if (detailsPhotoImageView != null) {
				detailsPhotoImageView.Dispose ();
				detailsPhotoImageView = null;
			}
			if (emailButton != null) {
				emailButton.Dispose ();
				emailButton = null;
			}
		}
	}
}
