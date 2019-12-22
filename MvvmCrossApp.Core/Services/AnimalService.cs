using MvvmCrossApp.Core.Models.Dogs;
using MvvmCrossApp.Core.Models.Kittens;
using MvvmCrossApp.Core.Services.Interfaces;

namespace MvvmCrossApp.Core.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly KittenGenerator _kittenGenerator = new KittenGenerator();
        private readonly DogGenerator _dogGenerator = new DogGenerator();

        public int KittenPrice => 10;

        public int DogPrice => 50;

        public Kitten BuyKitten()
        {
            return _kittenGenerator.CreateNewKitten();
        }

        public Dog BuyDog()
        {
            return _dogGenerator.CreateNewDog();
        }
    }
}
