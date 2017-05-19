using EventProcessor.DataAccess;
using System;
using EventProcessor.Model;
using System.Collections.Generic;

namespace EventProcessor.UI.DataProviders
{
    class EventTypeDataProvider : IEventTypeDataProvider
    {
        private readonly IEventTypeDataService _eventTypeDataServiceCreator;

        public EventTypeDataProvider()
        {
            _eventTypeDataServiceCreator = new EventTypeDataService();
        }

        public EventType GetEventTypeById(int id)
        {
            return _eventTypeDataServiceCreator.GetById(id);
        }

        public IEnumerable<EventType> GetAllEventTypes()
        {
            return _eventTypeDataServiceCreator.GetAll();
        }

        public void DeleteEventType(int id)
        {
            _eventTypeDataServiceCreator.Delete(id);
        }
        
        public void SaveEventType(EventType eventType)
        {
            _eventTypeDataServiceCreator.Save(eventType);
        }

        
    }
}
