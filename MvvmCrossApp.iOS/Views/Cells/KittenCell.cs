using System;

using Foundation;
using UIKit;

namespace MvvmCrossApp.iOS.Views.Cells
{
    public partial class KittenCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("KittenCell");
        public static readonly UINib Nib;

        static KittenCell()
        {
            Nib = UINib.FromName("KittenCell", NSBundle.MainBundle);
        }

        protected KittenCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
