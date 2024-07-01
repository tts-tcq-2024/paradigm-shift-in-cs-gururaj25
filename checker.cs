using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
{
    static bool IsTemperatureOk(float temperature)
    {
         if(temperature < 0 || temperature > 45) 
         {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
             Console.WriteLine("Temperature is within Range");
            return true;
        
    }

    static bool IssocOk(float soc)
    {
         if(soc < 20 || soc > 80)
         {
            Console.WriteLine("State of Charge is out of range!");
            return false;
         }
       
             Console.WriteLine("State of Charge is within Range");
             return true;
    }

    static bool IsChargeRateOk(float chargeRate)
    {
        if(chargeRate > 0.8) {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }        
            Console.WriteLine("Charge Rate is within Range");
             return true;

    }
    static bool batteryIsOk(float temperature, float soc, float chargeRate) {
         bool tempok =IsTemperatureOk( temperature);
         bool socok =IssocOk( soc);
         bool chargerateok =IsChargeRateOk( chargeRate);        
        return tempok && socok && chargerateok;
    }

    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(batteryIsOk(25, 70, 0.7f));
        ExpectFalse(batteryIsOk(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
    
}
}
