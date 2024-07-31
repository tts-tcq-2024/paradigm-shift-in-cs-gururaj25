using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paradigm_shift_csharp
{
    public class Program
    {
        static ChargeRate chargeRateobj = new ChargeRate();
        static Temperature tempobj = new Temperature();
        static SOC socobj = new SOC();
        static BatteryChecker batteryChecker = new BatteryChecker();
        static void Main(string[] args)
        {
            BatteryCheckerTests.ExpectTrue(batteryChecker.IsBatteryOk(25, 70, 0.7f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(40, 19, 0.0f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(35, 85, 0.0f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(50, 25, 0.0f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(-1, 85, 0.0f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(40, 25, 0.9f));
            BatteryCheckerTests.ExpectFalse(batteryChecker.IsBatteryOk(50, 85, 0.9f));
            Console.WriteLine("All ok");
            Console.ReadLine();
            //return 0;
        }
       
    }
}
