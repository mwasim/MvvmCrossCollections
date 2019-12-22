using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(LargeFixedViewModel), nameof(LargeFixedViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class LargeFixedViewModel: BaseAnimalViewModel
    {
        private MyCustomList _kittens;

        public LargeFixedViewModel()
        {
            Kittens = new MyCustomList();
        }

        public MyCustomList Kittens
        {
            get { return _kittens; }
            set
            {
                _kittens = value;
                RaisePropertyChanged(() => Kittens);
            }
        }
    }
}
