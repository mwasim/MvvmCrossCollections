// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MvvmCrossApp.iOS.Views.Cells
{
	[Register ("KittenCell")]
	partial class KittenCell
	{
		[Outlet]
		UIKit.UIImageView MainImage { get; set; }

		[Outlet]
		UIKit.UILabel NameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}

			if (MainImage != null) {
				MainImage.Dispose ();
				MainImage = null;
			}
		}
	}
}
