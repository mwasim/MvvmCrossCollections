using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace MvvmCrossApp.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController
    {
        public HomeView() : base(nameof(HomeView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var set = this.CreateBindingSet<HomeView, MvvmCrossApp.Core.ViewModels.HomeViewModel>();
            set.Bind(TextInput).To(vm => vm.Text);
            set.Bind(OutputLabel).For(l => l.Text).To(vm => vm.Text);
            set.Bind(ResetButton).To(vm => vm.ResetTextCommand);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

