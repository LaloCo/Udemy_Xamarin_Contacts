using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using MessageUI;

namespace MyContacts
{
	partial class DetailsViewController : UIViewController
	{
		public Contact selectedContact;

		public DetailsViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			emailButton.TouchUpInside += EmailButton_TouchUpInside;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			detailsPhotoImageView.Image = selectedContact.Photo;
			detailsNameLabel.Text = selectedContact.FullName;
			detailsEmailLabel.Text = selectedContact.Email;
		}

		void EmailButton_TouchUpInside (object sender, EventArgs e)
		{
            if (MFMailComposeViewController.CanSendMail)
            {
                var emailController = new MFMailComposeViewController();
                emailController.SetToRecipients(new string[]{ detailsEmailLabel.Text });

                emailController.Finished += EmailController_Finished;

                PresentViewController(emailController, true, null);
            }
		}

        void EmailController_Finished (object sender, MFComposeResultEventArgs e)
        {
            e.Controller.DismissViewController(true, null);
        }
	}
}
