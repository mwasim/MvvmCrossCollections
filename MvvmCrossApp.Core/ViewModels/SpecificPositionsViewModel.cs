using System.Collections.Generic;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(SpecificPositionsViewModel), nameof(SpecificPositionsViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class SpecificPositionsViewModel: BaseAnimalViewModel
    {
        private List<Kitten> _kittens;

        private Dictionary<string, Kitten> _lookup;

        public SpecificPositionsViewModel()
        {
            var list = new List<Kitten>();
            for (var i = 0; i < 10; i++)
            {
                var kitten = CreateKittenNamed("Kitten " + i);
                list.Add(kitten);
            }

            Kittens = list;
            Lookup = new Dictionary<string, Kitten>
            {
                {"Kitty", CreateKittenNamed("Kitty")},
                {"Tom", CreateKittenNamed("Tom")},
                {"Felix", CreateKittenNamed("Felix")},
                {"Tiger", CreateKittenNamed("Tiger")},
                {"Lion", CreateKittenNamed("Lion")},
                {"Simba", CreateKittenNamed("Simba")},
            };
        }

        public List<Kitten> Kittens
        {
            get => _kittens;
            set => SetProperty(ref _kittens, value);
        }

        public Dictionary<string, Kitten> Lookup
        {
            get => _lookup;
            set => SetProperty(ref _lookup, value);
        }
    }
}
