using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [Activity(Label = "MainMenuView", ScreenOrientation = ScreenOrientation.Portrait)]
    [MvxActivityPresentation]
    public class MainMenuView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PageMainMenuView);
        }
    }
}