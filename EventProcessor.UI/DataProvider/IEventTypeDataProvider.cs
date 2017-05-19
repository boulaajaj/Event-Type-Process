using EventProcessor.Model;
using System.Collections.Generic;

namespace EventProcessor.UI.DataProviders
{
    internal interface IEventTypeDataProvider
    {
        EventType GetEventTypeById(int id);

        IEnumerable<EventType> GetAllEventTypes();

        void SaveEventType(EventType eventType);

        void DeleteEventType(int id);
    }
}