//using System.ComponentModel.DataAnnotations;

//namespace eventBookingSystem.Models
//{
//    public class Event
//    {
//        public int id { get; set; }

//        [Required]
//        [MaxLength(255)]
//        public string name { get; set; }

//        public DateTime date { get; set; }

//        [MaxLength(500)]
//        public string description { get; set; }

//        public int capacity { get; set; }

//        // Navigation properties
//        public int venueId { get; set; }
//        public Venue venue { get; set; }
//    }

//    public class User
//    {
//        public int id { get; set; }

//        [Required]
//        [MaxLength(50)]
//        public string username { get; set; }

//        [EmailAddress]
//        public string email { get; set; }

//    }

//    public class Booking
//    {
//        public int id { get; set; }

//        public int eventId { get; set; }

//        public int userId { get; set; }

//        public int numberOfTickets { get; set; }

//        public BookingStatus status { get; set; }

//        public DateTime bookingDate { get; set; }

//        // Navigation properties
//        public Event @event { get; set; }

//        public User user { get; set; }
//    }

//    public class Venue
//    {
//        public int Id { get; set; }

//        [Required]
//        [MaxLength(255)]
//        public string Name { get; set; }

//    }

//    public enum BookingStatus
//    {
//        Pending,
//        Confirmed,
//        Cancelled
//    }
//}
