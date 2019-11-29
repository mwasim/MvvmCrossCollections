using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCrossApp.Core.Services.Interfaces;

namespace MvvmCrossApp.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;

        public TipViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalcuate();
        }

        private void Recalcuate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }

        private double _tip;

        public double Tip
        {
            get => _tip;
            set => SetProperty(ref _tip, value);
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                SetProperty(ref _subTotal, value);

                Recalcuate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                SetProperty(ref _generosity, value);

                Recalcuate();
            }
        }

    }
}
