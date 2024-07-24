using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
   
  public class BatteryChecker
{
    private  IChecker check;
     
    public BatteryChecker(IChecker check)
    {
     this.check =check;
    }
    public bool IsBatteryOk(float temperature, float soc, float chargeRate)
    {
      IChecker  checkTemp =  new TemperatureCheck();
      IChecker  checksoc   =new SocCheck();
      IChecker  checkChargeRate  =new ChargeRateCheck() ;
        return true;
    }

    private float GetValueForCheck(IChecker check, float temperature, float soc, float chargeRate)
    {
        if (check is TemperatureCheck) return temperature;
        if (check is SocCheck) return soc;
        if (check is ChargeRateCheck) return chargeRate;
        
    }
  }
}
