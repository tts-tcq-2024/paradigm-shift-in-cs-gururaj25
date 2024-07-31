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
            public CHECKERSTATUS GetSocStatus(float soc)
    {
        var socStatusRanges = new List<(float Min, float Max, CHECKERSTATUS Status)>
            {
                (0, 20, CHECKERSTATUS.LOW_BREACH),
                (21, 24, CHECKERSTATUS.LOW_WARNING),
                (24, 75, CHECKERSTATUS.NORMAL),
                (76, 80, CHECKERSTATUS.HIGH_WARNING),
                (81, 100, CHECKERSTATUS.HIGH_BREACH)
            };

        foreach (var range in socStatusRanges)
        {
            if (soc >= range.Min && soc <= range.Max)
            {
                return range.Status;
            }
        }

        throw new ArgumentOutOfRangeException("SOC value is out of the defined ranges.");
    }

    public void DisplayMessage(CHECKERSTATUS status, string languageCode)
    {
        var localizedMessages = new Dictionary<string, Dictionary<CHECKERSTATUS, string>>
        {
            { "en", new Dictionary<CHECKERSTATUS, string>
                {
                    { CHECKERSTATUS.LOW_BREACH, "LOW BREACH" },
                    { CHECKERSTATUS.LOW_WARNING, "LOW WARNING" },
                    { CHECKERSTATUS.NORMAL, "NORMAL" },
                    { CHECKERSTATUS.HIGH_WARNING, "HIGH WARNING" },
                    { CHECKERSTATUS.HIGH_BREACH, "HIGH BREACH" }
                }
            },
            {
                "de",new Dictionary<CHECKERSTATUS, string>
                {
                    
                       { CHECKERSTATUS.LOW_BREACH,"NIEDRIGER DURCHBRUCH" },
                       { CHECKERSTATUS.LOW_WARNING,"NIEDRIGE WARNUNG" },
                        { CHECKERSTATUS.NORMAL,"NORMAL" },
                        { CHECKERSTATUS.HIGH_WARNING,"WARNUNG HOCH" },
                        { CHECKERSTATUS.HIGH_BREACH,"HOHER BRUCH" }
                }
                    
                }
            
            
        };

        if (localizedMessages.TryGetValue(languageCode, out var messages) && messages.TryGetValue(status, out var message))
        {
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Message not found for the selected language and status.");
        }
    }
}
    }

    

   
}
