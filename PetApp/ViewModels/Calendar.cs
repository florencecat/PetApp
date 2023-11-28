using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using PetApp.Repositories;
using Plugin.Maui.Calendar.Models;

namespace PetApp.ViewModels
{
    public class Calendar : INotifyPropertyChanged
    {
#region Properties
        private string _selectedDate;
        public string SelectedDate 
        {
            get => _selectedDate;
            set
            {
                if (_selectedDate != value)
                {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }
        private ObservableCollection<Models.Event> _foundEvents;
        public ObservableCollection<Models.Event> FoundEvents 
        {
            get => _foundEvents;
            private set
            {
                if (_foundEvents != value)
                {
                    _foundEvents = value;
                    OnPropertyChanged(nameof(FoundEvents));
                }
            }
        }
        private readonly EventRepository eventRepository;
#endregion

        public Calendar()
        {
            PropertyChanged += HandlePropertyChanged;

            eventRepository = new EventRepository();
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedDate))
            {
                FoundEvents = eventRepository.GetEventsByDate(DateTime.Parse(SelectedDate));
            }
        }


    }
}

