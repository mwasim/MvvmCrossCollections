using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.iOS.Views.Base;

namespace MvvmCrossApp.iOS.Views
{
    [Register("ExpandableView")]
    public class ExpandableView : BaseExpandableTableView
    {
        public ExpandableView()
        {
            Title = "Expandable";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<ExpandableView, ExpandableViewModel>();
            set.Bind(TheExpandableTableSource).For(s => s.ItemsSource).To(vm => vm.KittenGroups);
            set.Apply();

            TableView.ReloadData();
        }
    }
}