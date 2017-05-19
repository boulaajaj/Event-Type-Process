using System.Collections.ObjectModel;
using EventProcessor.Model;
using EventProcessor.UI.Command;

namespace EventProcessor.UI.ViewModels
{
    interface IEventTypeViewModel
    {
        RelayCommand AddCommand { get; }
        RelayCommand DeleteCommand { get; }
        ObservableCollection<EventType> EventTypes { get; set; }
        RelayCommand ProcessCommand { get; }
        ObservableCollection<string> ProcessedEventRules { get; set; }
        EventType SelectedEventType { get; set; }
        RelayCommand UpdateCommand { get; }
    }
}