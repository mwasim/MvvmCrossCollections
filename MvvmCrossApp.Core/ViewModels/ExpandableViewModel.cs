using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(ExpandableViewModel), nameof(ExpandableViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class ExpandableViewModel : BaseAnimalViewModel
    {
        private List<KittenGroup> _kittenGroups;

        public ExpandableViewModel()
        {
            KittenGroups = CreateKittenGroups(10).ToList();
        }

        public List<KittenGroup> KittenGroups
        {
            get => _kittenGroups;
            set => SetProperty(ref _kittenGroups, value);
        }
    }
}
