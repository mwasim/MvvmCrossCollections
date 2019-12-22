using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.Core.ViewModels;

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

            // Perform any additional setup after loading the view
            var source = new MvxStandardTableViewSource(TableView, "TitleText Name;ImageUrl ImageUrl");
            TableView.Source = source;

            var set = this.CreateBindingSet<SmallFixedView, SmallFixedViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Apply();

            TableView.ReloadData(); //just give a nudge to table to reload the data
        }
    }
}