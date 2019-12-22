using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(SmallDynamicViewModel), nameof(SmallDynamicViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class SmallDynamicViewModel : BaseAnimalViewModel
    {
        private ObservableCollection<Kitten> _kittens;

        public SmallDynamicViewModel()
        {
            Kittens = new ObservableCollection<Kitten>();
            foreach (var kitten in CreateKittens(2))
            {
                Kittens.Add(kitten);
            }
        }

        public ObservableCollection<Kitten> Kittens
        {
            get => _kittens;
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
            if (!Kittens.Any())
                return;

            Kittens.RemoveAt(0);
        }
    }
}
