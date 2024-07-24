using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
public class SOC : IChecker
{
    public bool Check(float soc)
    {
        if (soc < 20 || soc > 80)
        {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        }
        return true;

    }

    public void DisplayStatus(float soc)
    {
        Console.WriteLine("State of Charge is: " + soc);
    }
    public void Warn()
    {
        Console.WriteLine("Warn");
    }
}
}
