
using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [Activity(Label = "SpecificPositionsView", ScreenOrientation = ScreenOrientation.Portrait)]
    [MvxActivityPresentation]
    public class SpecificPositionsView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();

            SetContentView(Resource.Layout.PageSpecificPositions);
        }
    }
}