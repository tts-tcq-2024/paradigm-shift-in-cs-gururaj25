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
        static void Main(string[] args)
        {
            BatteryCheckerTests.ExpectTrue(batteryIsOk(25, 70, 0.7f));
            BatteryCheckerTests.ExpectFalse(batteryIsOk(50, 85, 0.0f));
            BatteryCheckerTests.ExpectFalse(batteryIsOk(50, 85, 0.9f));
            Console.WriteLine("All ok");
            Console.ReadLine();
            //return 0;
        }

        public static bool batteryIsOk(float temperature, float soc, float chargeRateValue)
        {
            return tempobj.Check(temperature) && socobj.Check(soc) && chargeRateobj.Check(chargeRateValue);
        }
    }
}
