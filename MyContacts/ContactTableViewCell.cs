using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyContacts
{
	partial class ContactTableViewCell : UITableViewCell
	{
		public ContactTableViewCell (IntPtr handle) : base (handle)
		{
            
		}

		public void SetValues(Contact contact)
		{
			contactListNameLabel.Text = contact.FullName;
			contactListEmailLabel.Text = contact.Email;
			contactListImageView.Image = contact.Photo;
		}
	}
}
