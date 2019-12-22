using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Binding.Views;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;
using MvvmCrossApp.Core.Models.Dogs;
using MvvmCrossApp.Core.Models.Kittens;

namespace MvvmCrossApp.Android.Views
{
    [MvxActivityPresentation]
    [Activity(Label = "PolymorphicListItemTypesView", ScreenOrientation = ScreenOrientation.Portrait)]
    public class PolymorphicListItemTypesView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PagePolymorphicView);

            var list = FindViewById<MvxListView>(Resource.Id.TheListView);
            list.Adapter = new CustomAdapter(this, (IMvxAndroidBindingContext) BindingContext);
        }

        public class CustomAdapter : MvxAdapter
        {
            public CustomAdapter(Context context) : base(context)
            {
            }

            public CustomAdapter(Context context, IMvxAndroidBindingContext bindingContext) : base(context, bindingContext)
            {
            }

            protected CustomAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
            {
            }

            public override int GetItemViewType(int position)
            {
                var item = GetRawItem(position);
                
                return item is Kitten ? 0 : 1;
            }

            protected override View GetBindableView(View convertView, object dataContext, ViewGroup parent, int templateId)
            {
                if (dataContext is Kitten)
                    templateId = Resource.Layout.listitem_kitten;
                else if (dataContext is Dog)
                    templateId = Resource.Layout.listitem_dog;

                return base.GetBindableView(convertView, dataContext, parent, templateId);
            }

            public override int ViewTypeCount => 2;
        }
    }
}