using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossApp.Core.Services.Interfaces
{
    public interface IPricingService
    {
        int CalculateInitialSalesPrice(int purchaseCost);
    }
}
