using System.Collections.Generic;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(SmallFixedViewModel), nameof(SmallFixedViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class SmallFixedViewModel : BaseAnimalViewModel
    {
        private List<Kitten> _kittens;

        public SmallFixedViewModel()
        {
            Kittens = new List<Kitten>(CreateKittens(10));
        }

        public List<Kitten> Kittens
        {
            get => _kittens;
            set
            {
                _kittens = value;
                RaisePropertyChanged(() => Kittens);
            }
        }
    }
}
