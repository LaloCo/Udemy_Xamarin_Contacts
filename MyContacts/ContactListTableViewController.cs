using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyContacts
{
	partial class ContactListTableViewController : UITableViewController
	{
		public ContactListTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			TableView.ReloadData ();
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return (UIApplication.SharedApplication.Delegate as AppDelegate).contactList.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("contactCell") as ContactTableViewCell;

			var contact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList [indexPath.Row];
			cell.SetValues (contact);

			return cell;
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if (segue.Identifier == "detailsSegue")
			{
				var detailsViewController = segue.DestinationViewController as DetailsViewController;
				detailsViewController.selectedContact = (UIApplication.SharedApplication.Delegate as AppDelegate).contactList [TableView.IndexPathForSelectedRow.Row];
			}
		}

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 100;
        }
	}
}
