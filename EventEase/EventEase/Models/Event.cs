using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Required(ErrorMessage = "Event name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; } = string.Empty;
    }
}