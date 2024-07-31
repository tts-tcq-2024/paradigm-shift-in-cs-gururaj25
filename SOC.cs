using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
    public class SOC : IChecker
    {
        private const int MinSOC = 20;
        private const int MaxSOC = 80;

        public bool Check(float soc)
        {
            if (soc < MinSOC || soc > MaxSOC)
            {
                
                return false;
            }
            return true;
        }

        public void DisplayStatus(float soc)
        {
            
            if (soc < MinSOC)
            {
                Console.WriteLine("State of Charge is below the minimum threshold!");
            }
            else if (soc > MaxSOC)
            {
                Console.WriteLine("State of Charge is above the maximum threshold!");
            }
            else
            {
                Console.WriteLine("State of Charge is within the acceptable range.");
            }
        }

        public void Warn()
        {
            Console.WriteLine("Warn");
        }
    }

    

   
}
