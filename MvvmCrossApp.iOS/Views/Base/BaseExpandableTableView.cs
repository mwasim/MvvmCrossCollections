using System;
using Foundation;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.iOS.Views.Cells;
using UIKit;

namespace MvvmCrossApp.iOS.Views.Base
{
    public class BaseExpandableTableView : MvxTableViewController
    {
        protected ExpandableTableSource TheExpandableTableSource;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TheExpandableTableSource = new ExpandableTableSource(TableView)
            {
                UseAnimations = true,
                AddAnimation = UITableViewRowAnimation.Left,
                RemoveAnimation = UITableViewRowAnimation.Right
            };

            TableView.Source = TheExpandableTableSource;
            TableView.RowHeight = 100f;
        }

        public class ExpandableTableSource : MvxExpandableTableViewSource
        {
            public ExpandableTableSource(UITableView tableView) : base(tableView)
            {
                tableView.RegisterClassForCellReuse(typeof(KittenTableViewCell), nameof(KittenTableViewCell));
                tableView.RegisterClassForCellReuse(typeof(HeaderTableViewCell), nameof(HeaderTableViewCell));
            }

            protected override UITableViewCell GetOrCreateHeaderCellFor(UITableView tableView, nint section)
            {
                return tableView.DequeueReusableCell(nameof(HeaderTableViewCell));
            }

            protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
            {
                return tableView.DequeueReusableCell(nameof(KittenTableViewCell));
            }
        }
    }
}