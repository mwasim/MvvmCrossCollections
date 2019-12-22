using MvvmCrossApp.Core.Services.Interfaces;

namespace MvvmCrossApp.Core.Services
{
    public class PricingService : IPricingService
    {
        public int CalculateInitialSalesPrice(int purchaseCost)
        {
            var toReturn = purchaseCost * 2;
            // TODO - a real sales model would have a lot of different business rules here..
            return toReturn;
        }
    }
}
