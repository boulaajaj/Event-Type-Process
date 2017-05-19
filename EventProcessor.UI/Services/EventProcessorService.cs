using EventProcessor.Model;
using System.Collections.Generic;
using System.Linq;

namespace EventProcessor.UI.Services
{
    public static class EventProcessorService
    {
        public static string GetResults(int index, EventType eventType)
        {
            if (eventType.Rules == null)
                return null;

            List<string> metRules = eventType.Rules.Where(r => (index % r.Code) == 0).Select(r => r.Description).ToList();
            if (metRules.Count() > 0)
            {
                return string.Join(" ", metRules.ToArray());
            }
            else
            {
                return index.ToString();
            }
        }

    }
}
