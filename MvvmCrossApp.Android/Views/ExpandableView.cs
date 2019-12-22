using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [Activity(Label = "ExpandableView", ScreenOrientation = ScreenOrientation.Portrait)]
    [MvxActivityPresentation]
    public class ExpandableView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PageExpandableView);
        }
    }
}