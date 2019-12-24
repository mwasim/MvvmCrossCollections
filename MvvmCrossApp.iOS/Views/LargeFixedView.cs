using Foundation;
using MvvmCrossApp.iOS.Views.Base;

namespace MvvmCrossApp.iOS.Views
{
    [Register("LargeFixedView")]
    public class LargeFixedView : BaseKittenTableView
    {
        public LargeFixedView()
        {
            Title = "Large Fixed";
        }
    }
}