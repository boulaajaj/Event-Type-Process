using EventProcessor.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProcessor.UI
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            CurrentViewModel = new EventTypeViewModel();
        }
        public object CurrentViewModel { get; set; }
    }
}
