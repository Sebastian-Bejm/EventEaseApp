// Services/AttendanceService.cs
using EventEase.Models;

namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly List<Attendance> attendances = new();

        public void RegisterAttendance(string eventName, User user)
        {
            if (!attendances.Any(a => a.EventName == eventName && a.UserEmail == user.Email))
            {
                attendances.Add(new Attendance
                {
                    EventName = eventName,
                    UserEmail = user.Email,
                    UserName = user.Name
                });
            }
        }

        public IEnumerable<Attendance> GetAttendees(string eventName) =>
            attendances.Where(a => a.EventName == eventName);
    }
}
