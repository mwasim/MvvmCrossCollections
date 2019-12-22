using MvvmCrossApp.Core.Models.Dogs;
using MvvmCrossApp.Core.Models.Kittens;

namespace MvvmCrossApp.Core.Services.Interfaces
{
    public interface IAnimalService
    {
        int KittenPrice { get; }
        int DogPrice { get; }

        Kitten BuyKitten();

        Dog BuyDog();
    }
}
