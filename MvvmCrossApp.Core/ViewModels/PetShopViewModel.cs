using System.Collections.ObjectModel;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmCrossApp.Core.Models;
using MvvmCrossApp.Core.Services.Interfaces;

namespace MvvmCrossApp.Core.ViewModels
{
    public class PetShopViewModel : MvxViewModel
    {
        private readonly IAnimalService _animalSupplier;
        private readonly IPricingService _pricingModel;

        public ICommand AddKittenCommand => new MvxCommand(DoAddKitten);

        public ICommand AddDogCommand => new MvxCommand(DoAddDog);


        public PetShopViewModel(IAnimalService animalSupplier, IPricingService pricingModel)
        {
            _animalSupplier = animalSupplier;
            _pricingModel = pricingModel;

            Stock = new ObservableCollection<PetShopAnimalViewModel>();

            for (int i = 0; i < 10; i++)
            {
                DoAddKitten();
            }
        }

        private void DoAddKitten()
        {
            var kitten = _animalSupplier.BuyKitten();
            var cost = _animalSupplier.KittenPrice;
            DoBuyAnimal(kitten, cost);
        }

        private void DoAddDog()
        {
            var dog = _animalSupplier.BuyDog();
            var cost = _animalSupplier.DogPrice;
            DoBuyAnimal(dog, cost);
        }

        private void DoBuyAnimal(Animal animal, int cost)
        {
            var newStock = new PetShopAnimalViewModel
            {
                Animal = animal, 
                Price = _pricingModel.CalculateInitialSalesPrice(cost)
            };
            newStock.SellCommand = new MvxCommand(() => DoSale(newStock));

            BankBalance = BankBalance - cost;
            Stock.Add(newStock);
        }

        private void DoSale(PetShopAnimalViewModel toSell)
        {
            Stock.Remove(toSell);
            Sales = Sales + 1;
            Revenue = Revenue + toSell.Price;
            BankBalance = BankBalance + toSell.Price;
        }


        private ObservableCollection<PetShopAnimalViewModel> _stock;

        public ObservableCollection<PetShopAnimalViewModel> Stock
        {
            get => _stock;
            set => SetProperty(ref _stock, value);
        }

        private int _sales;

        public int Sales
        {
            get => _sales;
            set => SetProperty(ref _sales, value);
        }

        private int _revenue;

        public int Revenue
        {
            get => _revenue;
            set => SetProperty(ref _revenue, value);
        }

        private int _bankBalance;

        public int BankBalance
        {
            get => _bankBalance;
            set => SetProperty(ref _bankBalance, value);
        }
    }
}
