using MvvmCrossApp.Core.Services.Interfaces;

namespace MvvmCrossApp.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * generosity / 100.0;
        }
    }
}
