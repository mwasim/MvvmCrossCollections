using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCrossApp.Core.ViewModels;

namespace MvvmCrossApp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class TipView : MvxViewController
    {
        public TipView() : base(nameof(TipView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<TipView, TipViewModel>();

            set.Bind(SubTotalEditText).To(vm => vm.SubTotal);
            set.Bind(GenerositySlider).For(slider => slider.Value).To(vm => vm.Generosity);
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

