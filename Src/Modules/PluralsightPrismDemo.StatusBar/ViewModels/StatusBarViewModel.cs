using System;
using PluralsightPrismDemo.Infrastructure;
using Microsoft.Practices.Prism.Events;
using PluralsightPrismDemo.Infrastructure.Events;

namespace PluralsightPrismDemo.StatusBar
{
    public class StatusBarViewModel : ViewModelBase, IStatusBarViewModel
    {
        IEventAggregator _eventaggrigator;
        public StatusBarViewModel(IStatusBarView view, IEventAggregator eventaggrigator)
            : base(view)
        {
            _eventaggrigator = eventaggrigator;
            _eventaggrigator.GetEvent<PersonUpdatedEvent>().Subscribe(PersonUpdated);
        }

        private void PersonUpdated(string obj)
        {
            this.Message = string.Format("{0} is updated", obj);  
        }

        private string _message = "Ready";
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }
    }
}
