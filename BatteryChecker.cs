using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{

    public class BatteryChecker
    {
        private IChecker check;

        public BatteryChecker(IChecker check)
        {
            this.check = check;
        }
        public bool IsBatteryOk(float temperature, float soc, float chargeRate)
        {
            IChecker checkTemp = new Temperature();
            IChecker checksoc = new SOC();
            IChecker checkChargeRate = new ChargeRate();
            var tempResult = checkTemp.Check(GetValueForCheck(checkTemp, temperature, soc, chargeRate));
            var socResult = checksoc.Check(GetValueForCheck(checksoc, temperature, soc, chargeRate));
            var chargeRateResult = checkChargeRate.Check(GetValueForCheck(checkChargeRate, temperature, soc, chargeRate));

                    return tempResult && socResult && chargeRateResult;

        }

        private float GetValueForCheck(IChecker check, float temperature, float soc, float chargeRate)
        {
            return 0;            
        }
    }
}
