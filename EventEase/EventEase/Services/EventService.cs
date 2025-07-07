using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> events = new();

        public IEnumerable<Event> GetEvents() => events;

        public void AddEvent(Event newEvent)
        {
            events.Add(newEvent);
        }
    }
}
