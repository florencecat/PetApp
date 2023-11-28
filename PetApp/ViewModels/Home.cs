
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.ViewModels
{
    internal class Home : INotifyPropertyChanged
    {
        private Models.Event _upcomingEvent;
        public Models.Event UpcomingEvent
        {
            get => _upcomingEvent;
            set
            {
                if (_upcomingEvent != value)
                {
                    _upcomingEvent = value;

                }
            }
        }

        public Home()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
