using System;
using System.Drawing;
using Cirrious.FluentLayouts.Touch;
using CoreFoundation;
using FFImageLoading.Cross;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.Core.ViewModels;

namespace MvvmCrossApp.iOS.Views
{
    [Register("SpecificPositionsView")]
    public class SpecificPositionsView : MvxViewController
    {
        private MvxCachedImageView _imageView1, _imageView2;
        private UILabel _labelName1, _labelName2;

        public SpecificPositionsView()
        {
            Title = "Specific Positions";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            _imageView1 = new MvxCachedImageView { BackgroundColor = UIColor.Green };
            _imageView2 = new MvxCachedImageView { BackgroundColor = UIColor.Blue };
            _labelName1 = new UILabel();
            _labelName2 = new UILabel();

            Add(_imageView1);
            Add(_labelName1);
            Add(_imageView2);
            Add(_labelName2);

            _imageView1.LoadingPlaceholderImagePath = "res:place.jpg";
            _imageView1.ErrorPlaceholderImagePath = "res:place.jpg";
            _imageView1.TransformPlaceholders = true;

            _imageView2.LoadingPlaceholderImagePath = "res:place.jpg";
            _imageView2.ErrorPlaceholderImagePath = "res:place.jpg";
            _imageView2.TransformPlaceholders = true;

            var set = this.CreateBindingSet<SpecificPositionsView, SpecificPositionsViewModel>();
            set.Bind(_imageView1).For(v => v.ImagePath).To(vm => vm.Kittens[2].ImageUrl);
            set.Bind(_labelName1).For(v => v.Text).To(vm => vm.Kittens[2].Name);

            set.Bind(_imageView2).For(v => v.ImagePath).To(vm => vm.Lookup["Felix"].ImageUrl);
            set.Bind(_labelName2).For(v => v.Text).To(vm => vm.Lookup["Felix"].Name);
            set.Apply();

            //https://github.com/FluentLayout/Cirrious.FluentLayout
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            var hMargin = 20;
            var vMargin = 20;

            //var guide = View.SafeAreaLayoutGuide;

            //https://github.com/FluentLayout/Cirrious.FluentLayout
            View.AddConstraints(
                _imageView1.AtTopOfSafeArea(View, vMargin),
                _imageView1.AtLeftOfSafeArea(View, hMargin),
                _imageView1.ToLeftOf(_labelName1, hMargin),
                _imageView1.Width().EqualTo(200),
                _imageView1.Height().EqualTo(200),

                _labelName1.WithSameTop(_imageView1),
                _labelName1.AtRightOf(View, hMargin),

                _imageView2.WithSameLeft(_imageView1),
                _imageView2.ToLeftOf(_labelName2, hMargin),
                _imageView2.Below(_imageView1, vMargin),
                _imageView2.WithSameWidth(_imageView1),
                _imageView2.WithSameHeight(_imageView1),

                _labelName2.WithSameTop(_imageView2),
                _labelName2.AtRightOf(View, hMargin)
            );
        }

    }
}