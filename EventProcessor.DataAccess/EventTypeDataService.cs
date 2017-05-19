using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using EventProcessor.Model;

namespace EventProcessor.DataAccess
{
    public class EventTypeDataService : IEventTypeDataService
    {
        private const string StorageFile = "EventTypes.json";

        public EventType GetById(int Id)
        {
            return ReadFromFile().FirstOrDefault(f => f.Id == Id);
        }

        public void Save(EventType record)
        {
            if (record.Id <= 0)
            {
                Insert(record);
            }
            else
            {
                Update(record);
            }
        }

        public void Delete(int id)
        {
            var records = ReadFromFile();
            var existingRecord = records.Single(f => f.Id == id);
            if (existingRecord == null)
                return;
            records.Remove(existingRecord);
            SaveToFile(records);
        }

        public IEnumerable<EventType> GetAll()
        {
            return ReadFromFile();
        }

        #region "Helpers"

        private void Update(EventType record)
        {
            var records = ReadFromFile();
            var existingRecord = GetById(record.Id);
            if (existingRecord == null)
                return;
            var indexOfExistingRecord = records.IndexOf(existingRecord);
            records.Insert(indexOfExistingRecord, record);
            records.Remove(existingRecord);
            SaveToFile(records);
        }

        private void Insert(EventType newRecord)
        {
            var eventTypes = ReadFromFile();
            var maxevEntTypeId = eventTypes.Count == 0 ? 0 : eventTypes.Max(f => f.Id);
            newRecord.Id = maxevEntTypeId + 1;
            eventTypes.Add(newRecord);
            SaveToFile(eventTypes);
        }

        private void SaveToFile(List<EventType> records)
        {
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(StorageFile, json);
        }

        private List<EventType> ReadFromFile()
        {
            if (!File.Exists(StorageFile))
            {
                FillFile();
            }

            string json = File.ReadAllText(StorageFile);
            return JsonConvert.DeserializeObject<List<EventType>>(json);
        }

        private void FillFile()
        {
            SaveToFile(
                new List<EventType> {
                    new EventType{Id=1, Name="Register",
                        Rules = new List<EventRule> {
                            new EventRule {Id =1, Code=3, Description="Register" },
                            new EventRule {Id =1, Code=5, Description="Patient" },
                        }
                    },
                    new EventType{Id=2, Name="Diagnose",
                        Rules = new List<EventRule> {
                            new EventRule {Id =1, Code=2, Description="Diagnose" },
                            new EventRule {Id =1, Code=7, Description="Patient" },
                        }
                    }
                }
            );
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}