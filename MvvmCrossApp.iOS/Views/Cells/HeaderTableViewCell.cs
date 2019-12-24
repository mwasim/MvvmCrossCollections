using System;
using Cirrious.FluentLayouts.Touch;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCrossApp.Core.Models.Kittens;
using UIKit;

namespace MvvmCrossApp.iOS.Views.Cells
{
    public class HeaderTableViewCell : MvxTableViewCell
    {
        private readonly UILabel _titleLabel;
        private bool _constraintsCreated;

        public HeaderTableViewCell(IntPtr handle) : base(handle)
        {
            _titleLabel = new UILabel();

            ContentView.AddSubview(_titleLabel);

            //https://github.com/FluentLayout/Cirrious.FluentLayout
            ContentView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            SetNeedsUpdateConstraints();

            this.DelayBind((() =>
            {
                var set = this.CreateBindingSet<HeaderTableViewCell, KittenGroup>();
                set.Bind(_titleLabel).For(v => v.Text).To(vm => vm.Title);
                set.Apply();
            }));
        }

        public override void UpdateConstraints()
        {
            if (_constraintsCreated == false)
            {
                //https://github.com/FluentLayout/Cirrious.FluentLayout
                ContentView.AddConstraints(
                    _titleLabel.WithSameCenterX(ContentView),
                    _titleLabel.WithSameCenterY(ContentView));

                _constraintsCreated = true;
            }

            base.UpdateConstraints();
        }
    }
}