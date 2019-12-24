using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.iOS.Views.Cells;
using UIKit;

namespace MvvmCrossApp.iOS.Views.Base
{
    public class BaseKittenTableView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new KittenTableSource(TableView)
            {
                UseAnimations = true,
                AddAnimation = UITableViewRowAnimation.Left,
                RemoveAnimation = UITableViewRowAnimation.Right
            };

            this.AddBindings(new Dictionary<object, string>
            {
                {source,"ItemsSource Kittens" }
            });

            TableView.Source = source;
            TableView.RowHeight = 100f;
            TableView.ReloadData();
        }

        public class KittenTableSource : MvxSimpleTableViewSource
        {
            public KittenTableSource(UITableView tableView) : base(tableView, typeof(KittenTableViewCell), nameof(KittenTableViewCell))
            {
                tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            }
        }
    }
}