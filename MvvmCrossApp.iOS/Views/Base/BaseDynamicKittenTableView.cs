using System;
using UIKit;

namespace MvvmCrossApp.iOS.Views.Base
{
    public abstract class BaseDynamicKittenTableView : BaseKittenTableView
    {
        private UIBarButtonItem _rightButton;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _rightButton = new UIBarButtonItem(UIBarButtonSystemItem.Action);
            _rightButton.Clicked += OnRightButtonClicked;
            NavigationItem.RightBarButtonItem = _rightButton;
        }

        private void OnRightButtonClicked(object sender, EventArgs e)
        {
            var sheet = new UIActionSheet("Actions");
            sheet.AddButton("Add");
            sheet.AddButton("Remove");

            sheet.Clicked += OnActionSheetButtonClicked;

            sheet.ShowFrom(_rightButton, true);
        }

        private void OnActionSheetButtonClicked(object sender, UIButtonEventArgs e)
        {
            switch (e.ButtonIndex)
            {
                case 0:
                    AddKittenPressed();
                    break;
                case 1:
                    RemoveKittenPressed();
                    break;
            }
        }

        protected abstract void RemoveKittenPressed();

        protected abstract void AddKittenPressed();
    }
}