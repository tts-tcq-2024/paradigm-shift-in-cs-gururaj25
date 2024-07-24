using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
  public class ChargeRate : IChecker
  {
    public bool Check(float chargeRate)
    {
        if (chargeRate > 0.8)
        {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;

    }

    public void DisplayStatus(float chargeRate)
    {
        Console.WriteLine("Charge Rate is: " + chargeRate);
    }
    public void Warn()
    {
        Console.WriteLine("Warn");
    }
  }
}
