using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
    public class ChargeRate : IChecker
    {
        private const int MinChargeRate = 0;
        private const int MaxChargeRate = 10;
        private int m_ChargeRate;

        public bool Check(float chargeRate)
        {
            if (chargeRate < MinChargeRate || chargeRate > MaxChargeRate)
            {                
                return false;
            }
            return true;
        }

        public void DisplayStatus(float chargeRate)
        {
            if (chargeRate < MinChargeRate)
            {
                Console.WriteLine("Charge rate is below the minimum threshold!");
            }
            else if (chargeRate > MaxChargeRate)
            {
                Console.WriteLine("Charge rate is above the maximum threshold!");
            }
            else
            {
                Console.WriteLine("Charge rate is within the acceptable range.");
            }
        }

        public void Warn()
        {
            Console.WriteLine("Warn");
        }
    }
}
