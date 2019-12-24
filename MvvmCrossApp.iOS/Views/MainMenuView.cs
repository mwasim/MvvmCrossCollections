using System.Collections.Generic;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace MvvmCrossApp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class MainMenuView : MvxTableViewController
    {
        public MainMenuView()
        {
            Title = "Main Menu";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view
            var source = new TableSource(TableView);
            this.AddBindings(new Dictionary<object, string>
            {
                {source, "ItemsSource MenuItems"}
            });

            TableView.Source = source;
            TableView.ReloadData();
        }

        public class TableSource : MvxStandardTableViewSource
        {
            private static readonly NSString Identifier = new NSString("MenuCellIdentifier");
            private const string BindingText = "TitleText Title;SelectedCommand ShowCommand";

            public TableSource(UITableView tableView) : base(tableView, UITableViewCellStyle.Default, Identifier, BindingText)
            {
            }
        }
    }
}