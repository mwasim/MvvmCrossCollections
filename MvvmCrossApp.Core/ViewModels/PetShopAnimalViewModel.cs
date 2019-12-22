using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmCrossApp.Core.Models;

namespace MvvmCrossApp.Core.ViewModels
{
    public class PetShopAnimalViewModel : MvxViewModel
    {
        public ICommand SellCommand { get; set; }

        public ICommand IncreasePrice
        {
            get { return new MvxCommand(() => Price = Price + 1); }
        }

        public ICommand DecreasePrice
        {
            get { return new MvxCommand(() => Price = Price - 1); }
        }


        private Animal _animal;

        public Animal Animal
        {
            get => _animal;
            set => SetProperty(ref _animal, value);
        }

        private int _price;

        public int Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
        }
    }
}
