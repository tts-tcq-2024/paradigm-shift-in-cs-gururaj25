using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
    public class Temperature : IChecker
    {
        private const int MinTemperature = 0;
        private const int MaxTemperature = 100;

        public bool Check(float temperature)
        {
            if (temperature < MinTemperature || temperature > MaxTemperature)
            {
                return false;
            }
            return true;
        }

        public void DisplayStatus(float temperature)
        {
             if (temperature < MinTemperature)
            {
                Console.WriteLine("Temperature is below the minimum threshold!");
            }
            else if (temperature > MaxTemperature)
            {
                Console.WriteLine("Temperature is above the maximum threshold!");
            }
            else
            {
                Console.WriteLine("Temperature is within the acceptable range.");
            }
        }

        public void Warn()
        {
            Console.WriteLine("Warn");
        }
    }
}
