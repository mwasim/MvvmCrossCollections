using System;
using UIKit;
using FFImageLoading.Cross;
using MvvmCross.Platforms.Ios.Binding.Views;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCrossApp.Core.Models.Kittens;

namespace MvvmCrossApp.iOS.Views.Cells
{
    public partial class KittenTableViewCell : MvxTableViewCell
    {
        private readonly MvxCachedImageView _imageView;
        private readonly UILabel _nameLabel;

        private bool _constraintsCreated;

        protected KittenTableViewCell(IntPtr handle) : base(handle)
        {
            //Tutorial here https://github.com/luberda-molinet/FFImageLoading/wiki/MvvmCross---Native-controls
            //MvvmCross Sample: https://github.com/luberda-molinet/FFImageLoading/tree/master/samples/ImageLoading.MvvmCross.Sample
            _imageView = new MvxCachedImageView {BackgroundColor = UIColor.Green};
            _nameLabel = new UILabel();

            ContentView.AddSubview(_imageView);
            ContentView.AddSubview(_nameLabel);
            ContentView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            SetNeedsUpdateConstraints();

            this.DelayBind(() =>
            {
                _imageView.LoadingPlaceholderImagePath = "res:place.jpg";
                _imageView.ErrorPlaceholderImagePath = "res:place.jpg";
                _imageView.TransformPlaceholders = true;

                var set = this.CreateBindingSet<KittenTableViewCell, Kitten>();
                //set.Bind(_imageView).For(v=>v.DownsampleHeight).To(vm=>vm.DownsampleHeight);
                //set.Bind(_imageControl).For(v => v.Transformations).To(vm => vm.Transformations);
                set.Bind(_imageView).For(v => v.ImagePath).To(vm => vm.ImageUrl);
                set.Bind(_nameLabel).For(v => v.Text).To(vm => vm.Name);
                set.Apply();
            });
        }

        public override void UpdateConstraints()
        {
            if (_constraintsCreated == false)
            {
                ContentView.AddConstraints(
                    _imageView.WithSameLeft(ContentView),
                    _imageView.WithSameTop(ContentView),
                    _imageView.Width().EqualTo(100f),
                    _imageView.Height().EqualTo(100f),

                    _nameLabel.ToRightOf(_imageView,20f),
                    _nameLabel.WithSameCenterY(_imageView));

                _constraintsCreated = true;
            }

            base.UpdateConstraints();
        }
    }
}
