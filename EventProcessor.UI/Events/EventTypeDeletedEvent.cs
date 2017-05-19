using EventProcessor.Model;
using Prism.Events;

namespace EventProcessor.UI.Events
{
    public class EventTypeDeletedEvent : PubSubEvent<EventType>
    {
    }
}
