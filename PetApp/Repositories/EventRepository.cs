using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp.Repositories
{
    class EventRepository
    {
        private readonly ObservableCollection<Models.Event> _events;
        public EventRepository() 
        {
            _events = new ObservableCollection<Models.Event>()
            {
                new Models.Event() { Name = "Прививка #1", Description = "Тестовая прививка #1", Time = DateTime.Parse("22.11.2023 12:00:00")},
                new Models.Event() { Name = "Прием таблеток", Description = "Тестовый прием таблеток", Time = DateTime.Parse("22.11.2023 19:00:00")},
                new Models.Event() { Name = "Прививка #2", Description = "Тестовая прививка #2", Time = DateTime.Parse("27.11.2023 11:00:00")}
            };
        }

        public ObservableCollection<Models.Event> GetEventsByDate(DateTime date)
        {
            ObservableCollection<Models.Event> result = new();
            if (!date.Equals(DateTime.MinValue))
            {
                List<Models.Event> events = _events.Where(e => e.Time.ToShortDateString() == date.ToShortDateString()).ToList();
                if (events.Count > 0)
                {
                    foreach (Models.Event e in events)
                        result.Add(e);
                }
            }

            return result;
        }
    }
}
