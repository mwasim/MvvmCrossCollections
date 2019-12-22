using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.iOS.Views.Cells;

namespace MvvmCrossApp.iOS.Views
{
    [Register("SmallFixedView")]
    public class SmallFixedView : MvxTableViewController
    {
        public SmallFixedView()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //MvxImageViewLoader 

            // Perform any additional setup after loading the view
            
            //This is built-in standard mvx table view source
            //var source = new MvxStandardTableViewSource(TableView, "TitleText Name;ImageUrl ImageUrl");

            //This is simple tableview source, here we can pass in custom tableview cell
            var source = new MvxSimpleTableViewSource(TableView, typeof(KittenTableViewCell), nameof(KittenTableViewCell));
            TableView.Source = source;
            TableView.RowHeight = 100f;

            var set = this.CreateBindingSet<SmallFixedView, SmallFixedViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Apply();

            TableView.ReloadData(); //just give a nudge to table to reload the data
        }
    }
}