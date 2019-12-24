using Foundation;
using MvvmCrossApp.iOS.Views.Base;

namespace MvvmCrossApp.iOS.Views
{
    [Register("SmallFixedView")]
    public class SmallFixedView : BaseKittenTableView
    {
        public SmallFixedView()
        {
            Title = "Small Fixed";
        }

        //The below work is now being done in the base class
        /*
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //MvxImageViewLoader 

            // Perform any additional setup after loading the view

            //This is built-in standard mvx table view source
            //var source = new MvxStandardTableViewSource(TableView, "TitleText Name;ImageUrl ImageUrl");

            //This is simple tableview source, here we can pass in custom tableview cell
            //The below work is now being done in the base class
            
            var source = new MvxSimpleTableViewSource(TableView, typeof(KittenTableViewCell), nameof(KittenTableViewCell));
            TableView.Source = source;
            TableView.RowHeight = 100f;

            var set = this.CreateBindingSet<SmallFixedView, SmallFixedViewModel>();
            set.Bind(source).To(vm => vm.Kittens);
            set.Apply();

            TableView.ReloadData(); //just give a nudge to table to reload the data
            
        }*/
    }
}