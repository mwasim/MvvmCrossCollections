using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "TipView")]
    public class TipView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.TipView);
        }
    }
}