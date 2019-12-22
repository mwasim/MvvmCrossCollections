using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(LargeDynamicViewModel), nameof(LargeDynamicViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class LargeDynamicViewModel: BaseAnimalViewModel
    {
        private MyCustomList _kittens;

        public LargeDynamicViewModel()
        {
            Kittens = new MyCustomList();
        }

        public MyCustomList Kittens
        {
            get=>_kittens;
            set => SetProperty(ref _kittens, value);
        }

        public ICommand AddKittenCommand => new MvxCommand(DoAddKitten);
        public ICommand KillKittensCommand => new MvxCommand(DoKillKittens);

        private void DoAddKitten()
        {
            var kitten = CreateKitten();
            Kittens.Add(kitten);
        }

        private void DoKillKittens()
        {
            var toKillCount = Math.Min(10, Kittens.Count);
            for (var i = 0; i < toKillCount; i++)
            {
                Kittens.RemoveAt(0);
            }
        }
    }
}
