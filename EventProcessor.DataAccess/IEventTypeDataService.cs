using EventProcessor.Model;
using System;
using System.Collections.Generic;

namespace EventProcessor.DataAccess
{
    public interface IEventTypeDataService : IDisposable
    {
        EventType GetById(int Id);

        void Save(EventType record);

        void Delete(int id);

        IEnumerable<EventType> GetAll();

    }
}
