using Cai;

namespace eventBookingSystem.Features.GraphQL;
    
[Mutation<string>()]
[Rest<Event[]>("/api/events/add", Verb.Post)]
public record AddEvent(string name, DateTime date, string description, int capacity);

[Mutation<string>("updateEvent")]
[Rest<Event>("/api/events/update", Verb.Put)]
public record UpdateEvent(int id, string name, DateTime date, string description, int capacity);

[Mutation<string>("editEvent")]
[Rest<Event>("/api/events/edit", Verb.Patch)]
public record EditEvent(int id, string name, DateTime date, string description, int capacity);

[Mutation<string>("deleteEvent")]
[Rest<Event>("/api/events/delete", Verb.Delete)]
public record DeleteEvent(int id);



[Rest<User[]>("/api/users/add", Verb.Post)]
[Query<User[]>()]
public record AddUser(string name, string email);

[Rest<Venue[]>("/api/venues/add", Verb.Post)]
[Query<Venue[]>()]
public record AddVenue(string name, string location);

[Rest<Booking[]>("/api/bookings/add", Verb.Post)]
[Query<Booking[]>()]
public record AddBooking(int eventId, int userId, DateTime bookingDate, BookingStatus status);

[Mutation<string>("updateBookingStatus")]
[Rest<Booking>("/api/bookings/updateStatus", Verb.Put)]
public record UpdateBookingStatus(int bookingId, BookingStatus status);