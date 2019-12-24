using Foundation;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.iOS.Views.Base;

namespace MvvmCrossApp.iOS.Views
{
    [Register("SmallDynamicView")]
    public class SmallDynamicView : BaseDynamicKittenTableView
    {
        public SmallDynamicView()
        {
            Title = "Small Dynamic";
        }

        protected override void RemoveKittenPressed()
        {
            DynamicViewModel.KillKittensCommand.Execute(null);
        }

        protected override void AddKittenPressed()
        {
            DynamicViewModel.AddKittenCommand.Execute(null);
        }

        public SmallDynamicViewModel DynamicViewModel => base.ViewModel as SmallDynamicViewModel;
    }
}