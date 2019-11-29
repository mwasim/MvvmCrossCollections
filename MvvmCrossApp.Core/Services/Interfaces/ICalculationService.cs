namespace MvvmCrossApp.Core.Services.Interfaces
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}
