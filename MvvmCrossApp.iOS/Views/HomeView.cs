using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace MvvmCrossApp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public class HomeView : MvxViewController
    {
        public HomeView() : base(nameof(HomeView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            
        }
    }
}