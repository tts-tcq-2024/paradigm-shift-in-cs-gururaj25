using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
  public class Temperature : IChecker
{
    public bool Check(float temperature)
    {
        if (temperature < 0 || temperature > 45)
        {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
        return true;

    }

    public void DisplayStatus(float temperature)
    {
        Console.WriteLine("Temperature is: " + temperature);
    }

    public void Warn()
    {
        Console.WriteLine("Warn");
    }
}
}
