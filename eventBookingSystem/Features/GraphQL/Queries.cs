using Cai;

namespace eventBookingSystem.Features.GraphQL;

[Rest<Event[]>("/api/events/get", Verb.Get)]
[Query<Event[]>()]
public record GetAllEvents();

[Rest<User[]>("/api/users/get", Verb.Get)]
[Query<User[]>()]
public record GetAllUsers();

[Rest<Venue[]>("/api/venues/get", Verb.Get)]
[Query<Venue[]>()]
public record GetAllVenues();

[Rest<Booking[]>("/api/bookings/get", Verb.Get)]
[Query<Booking[]>()]
public record GetAllBookings();



public record Event(int Id, string Name, DateTime Date, string Description, int Capacity);
public record User(int Id, string Name, string Email);
public record Venue(int Id, string Name, string Location);
public record Booking(int Id, int EventId, int UserId, DateTime BookingDate, BookingStatus Status);

public enum BookingStatus
{
    Pending,
    Confirmed,
    Cancelled
}
