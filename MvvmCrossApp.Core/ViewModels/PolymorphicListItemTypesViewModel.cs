using System.Collections.Generic;
using MvvmCross.Navigation;
using MvvmCrossApp.Core.Models;
using MvvmCrossApp.Core.ViewModels;
using MvvmCrossApp.Core.ViewModels.Base;

[assembly: MvxNavigation(typeof(PolymorphicListItemTypesViewModel), nameof(PolymorphicListItemTypesViewModel))]
namespace MvvmCrossApp.Core.ViewModels
{
    public class PolymorphicListItemTypesViewModel: BaseAnimalViewModel
    {
        private List<Animal> _animals;

        public PolymorphicListItemTypesViewModel()
        {
            var animals = new List<Animal>();
            for (var i = 0; i < 10; i++)
            {
                animals.Add(i % 2 == 0 ? (Animal)CreateDog() : (Animal)CreateKitten());
            }
            Animals = animals;
        }

        public List<Animal> Animals
        {
            get => _animals;
            set => SetProperty(ref _animals, value);
        }
    }
}
