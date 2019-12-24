using Foundation;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.iOS.Views.Base;

namespace MvvmCrossApp.iOS.Views
{
    [Register("LargeDynamicView")]
    public class LargeDynamicView : BaseDynamicKittenTableView
    {
        public LargeDynamicView()
        {
            Title = "Large Dynamic";
        }

        protected override void RemoveKittenPressed()
        {
            DynamicViewModel.KillKittensCommand.Execute(null);
        }

        protected override void AddKittenPressed()
        {
            DynamicViewModel.AddKittenCommand.Execute(null);
        }

        public LargeDynamicViewModel DynamicViewModel => base.ViewModel as LargeDynamicViewModel;
    }
}