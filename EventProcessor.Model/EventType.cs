using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProcessor.Model
{
    public class EventType
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IEnumerable<EventRule> Rules { get; set; }
    }
}
