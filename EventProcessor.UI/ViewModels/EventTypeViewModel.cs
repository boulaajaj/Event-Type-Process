using System.Collections.ObjectModel;
using Prism.Events;
using System.Linq;
using System.Windows.Input;
using EventProcessor.UI.Command;
using EventProcessor.Model;
using EventProcessor.UI.DataProviders;
using System.ComponentModel;
using EventProcessor.UI.Services;
using System.Text;
using System.Collections.Generic;

namespace EventProcessor.UI.ViewModels
{
    class EventTypeViewModel 
    {
        private ObservableCollection<EventType> _eventTypes;
        private ObservableCollection<string> _processedEventRules;
        private readonly IEventTypeDataProvider _eventTypeDataProvider;

        public EventTypeViewModel()
        {
            _eventTypeDataProvider = new EventTypeDataProvider();
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject())) return;

            EventTypes = new ObservableCollection<EventType>(_eventTypeDataProvider.GetAllEventTypes());
            ProcessedEventRules = new ObservableCollection<string>();

            ProcessCommand = new RelayCommand(OnProcess, CanProcess);
            AddCommand = new RelayCommand(OnAdd);
            UpdateCommand = new RelayCommand(OnUpdate, CanUpdate);
            DeleteCommand = new RelayCommand(OnDelete, CanDelete);
        }

        public RelayCommand ProcessCommand { get; private set; }
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand UpdateCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }

        public ObservableCollection<EventType> EventTypes
        {
            get
            {
                return _eventTypes;
            }
            set
            {
                _eventTypes = value;
            }
        }

        public ObservableCollection<string> ProcessedEventRules
        {
            get
            {
                return _processedEventRules;
            }
            set
            {
                _processedEventRules = value;
            }
        }

        private EventType _selectedEventType;
        public EventType SelectedEventType
        {
            get
            {
                return _selectedEventType;
            }
            set
            {
                _selectedEventType = value;
                DeleteCommand.RaiseCanExecuteChanged();
                UpdateCommand.RaiseCanExecuteChanged();
                ProcessCommand.RaiseCanExecuteChanged();
            }
        }

        private void OnDelete()
        {
            EventTypes.Remove(SelectedEventType);
        }

        private bool CanDelete()
        {
            return SelectedEventType != null;
        }

        private void OnAdd()
        {
            if (SelectedEventType.Id > 0)
            {
                int newId = EventTypes.Max(e => e.Id) + 1;
                EventTypes.Add(new EventType
                {
                    Id = newId,
                    Name = "New Event Type",
                    Rules = new List<EventRule> {
                            new EventRule {Id =1, Code=3, Description="Register" },
                            new EventRule {Id =1, Code=5, Description="Patient" },
                        }
                });
            }
            //EventTypes.Remove(SelectedEventType);
        }

        private void OnUpdate()
        {
            _eventTypeDataProvider.SaveEventType(SelectedEventType);
        }

        private bool CanUpdate()
        {
            return SelectedEventType != null;
        }

        private void OnProcess()
        {
            _processedEventRules.Clear();
            Enumerable.Range(1, 100).ToList()
                .ForEach(i=> 
                {
                    _processedEventRules.Add(EventProcessorService.GetResults(i, SelectedEventType));
                });
        }

        private bool CanProcess()
        {
            return SelectedEventType != null;
        }

    }
}
