using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCrossApp.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainMenuViewModel()
        {
            _navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();

            MenuItems = new List<MenuItem>
            {
                new MenuItem("Small Fixed Collection", this, nameof(SmallFixedViewModel)),
                new MenuItem("Small Dynamic Collection", this, nameof(SmallDynamicViewModel)),
                new MenuItem("Large Fixed Collection", this, nameof(LargeFixedViewModel)),
                new MenuItem("Large Dynamic Collection", this, nameof(LargeDynamicViewModel)),
                new MenuItem("Polymorphic Collection", this, nameof(PolymorphicListItemTypesViewModel)),
                new MenuItem("Specific Positions Collection", this, nameof(SpecificPositionsViewModel)),
                new MenuItem("Expandable Collection", this, nameof(ExpandableViewModel)),
            };
        }

        public List<MenuItem> MenuItems { get; private set; }

        public class MenuItem
        {
            public MenuItem(string title, MainMenuViewModel parent, string viewModelUrl)
            {
                Title = title;
                // Will change to navigate to type once https://github.com/MvvmCross/MvvmCross/pull/2148 is in.
                ShowCommand = new MvxCommand(() => parent._navigationService.Navigate(viewModelUrl));
            }

            public string Title { get; private set; }
            public ICommand ShowCommand { get; private set; }
        }
    }
}
