using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "LargeDynamicView", ScreenOrientation = ScreenOrientation.Portrait)]
    public class LargeDynamicView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PageDynamicView);
        }
    }
}