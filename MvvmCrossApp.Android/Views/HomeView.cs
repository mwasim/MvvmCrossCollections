﻿using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossApp.Android.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "View for HomeViewModel")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }
    }
}