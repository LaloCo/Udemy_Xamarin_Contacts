using System;

using UIKit;

namespace MyContacts
{
	public partial class ViewController : UIViewController
	{
		UIImagePickerController imagePickerController;
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			imageButton.TouchUpInside += ImageButton_TouchUpInside;
			saveButton.Clicked += SaveButton_Clicked;
		}

		void SaveButton_Clicked (object sender, EventArgs e)
		{
			var contact = new Contact () {
				FullName = fullNameTextField.Text,
				Email = emailTextField.Text,
				Photo = photoImageView.Image
			};

			var del = UIApplication.SharedApplication.Delegate as AppDelegate;
			del.contactList.Add (contact);

			NavigationController.PopViewController (true);
		}

		void ImageButton_TouchUpInside (object sender, EventArgs e)
		{
			imagePickerController = new UIImagePickerController ();
			imagePickerController.SourceType = UIImagePickerControllerSourceType.PhotoLibrary;
			imagePickerController.MediaTypes = UIImagePickerController.AvailableMediaTypes (UIImagePickerControllerSourceType.PhotoLibrary);

			imagePickerController.Canceled += ImagePickerController_Canceled;
			imagePickerController.FinishedPickingMedia += ImagePickerController_FinishedPickingMedia;

			NavigationController.PresentModalViewController (imagePickerController, true);
		}

		void ImagePickerController_FinishedPickingMedia (object sender, UIImagePickerMediaPickedEventArgs e)
		{
			photoImageView.Image = e.Info [UIImagePickerController.OriginalImage] as UIImage;

			imagePickerController.DismissModalViewController (true);
		}

		void ImagePickerController_Canceled (object sender, EventArgs e)
		{
			imagePickerController.DismissModalViewController (true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

