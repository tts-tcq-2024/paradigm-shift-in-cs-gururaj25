using paradigm_shift_csharp;
using System;
using System.Collections.Generic;
namespace paradigm_shift_csharp
{
    public class SOC : IChecker
    {
        private const int MinSOC = 20;
        private const int MaxSOC = 80;

        public bool Check(float soc)
        {
            var socStatus = GetSocStatus(soc);
            if (socStatus == CHECKERSTATUS.LOW_BREACH || socStatus == CHECKERSTATUS.HIGH_BREACH)
            {
                DisplayMessage(socStatus, "en");
                return false;
            }
            return true;
        }

        public void DisplayStatus(float soc)
        {
            if (soc < MinSOC)
                Console.WriteLine("SOC is below the minimum limit!");
            else if (soc > MaxSOC)
                Console.WriteLine("SOC is above the maximum limit!");
            else
                Console.WriteLine("State of Charge is within the acceptable range.");
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
                    return range.Status;
            }

            throw new ArgumentOutOfRangeException("SOC value is out of the defined ranges.");
        }

        public void DisplayMessage(CHECKERSTATUS status, string languageCode)
        {
            var localizedMessages = new Dictionary<string, Dictionary<CHECKERSTATUS, string>>
                {
                    {
                        "en", new Dictionary<CHECKERSTATUS, string>
                        {
                            { CHECKERSTATUS.LOW_BREACH, "LOW BREACH" },
                            { CHECKERSTATUS.LOW_WARNING, "LOW WARNING" },
                            { CHECKERSTATUS.NORMAL, "NORMAL" },
                            { CHECKERSTATUS.HIGH_WARNING, "HIGH WARNING" },
                            { CHECKERSTATUS.HIGH_BREACH, "HIGH BREACH" }
                        }
                    },
                    {
                        "de", new Dictionary<CHECKERSTATUS, string>
                        {
                            { CHECKERSTATUS.LOW_BREACH, "NIEDRIGER DURCHBRUCH" },
                            { CHECKERSTATUS.LOW_WARNING, "NIEDRIGE WARNUNG" },
                            { CHECKERSTATUS.NORMAL, "NORMAL" },
                            { CHECKERSTATUS.HIGH_WARNING, "WARNUNG HOCH" },
                            { CHECKERSTATUS.HIGH_BREACH, "HOHER BRUCH" }
                        }
                    }
                };

            if (localizedMessages.TryGetValue(languageCode, out var messages) && messages.TryGetValue(status, out var message))
                Console.WriteLine(message);
            else
                Console.WriteLine("Message not found for the selected language and status.");
        }

        public void Warn()
        {
            Console.WriteLine("Warn");
        }
    }
}
