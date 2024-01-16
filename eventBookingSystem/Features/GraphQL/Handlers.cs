using Cai;

namespace eventBookingSystem.Features.GraphQL
{
    public class Handler
    {
        private static readonly List<Event> Events = new List<Event>();
        private static readonly List<User> Users = new List<User>();
        private static readonly List<Venue> Venues = new List<Venue>();
        private static readonly List<Booking> Bookings = new List<Booking>();


        public static async Task<Event[]> Handle(GetAllEvents input)
        {
            try
            {
                return Events.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        public static async Task<string> Handle(AddEvent input)
        {
            try
            {
                int nextId = Events.Count + 1;
                // adding a new event.
                var newEvent = new Event(nextId, input.name, input.date, input.description, input.capacity);
                Events.Add(newEvent);
                return "Event added successfully.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        public static async Task<string> Handle(UpdateEvent input)
        {
            try
            {
                // updating an existing event.
                var existingEvent = Events.FirstOrDefault(e => e.Id == input.id);
                if (existingEvent != null)
                {
                    // Use the 'with' expression to create a new instance with the updated properties.
                    var updatedEvent = existingEvent with
                    {
                        Name = input.name,
                        Date = input.date,
                        Description = input.description,
                        Capacity = input.capacity
                    };

                    // Replace the existing event with the updated event.
                    var index = Events.IndexOf(existingEvent);
                    Events[index] = updatedEvent;

                    return "Event updated successfully.";
                }
                else
                {
                    return "Event not found.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        public static async Task<string> Handle(EditEvent input)
        {
            // EditEvent mutation would be similar to UpdateEvent.
            // reuse the same logic.
            return await Handle(new UpdateEvent(input.id, input.name, input.date, input.description, input.capacity));
        }

        public static async Task<string> Handle(DeleteEvent input)
        {
            try
            {
                // deleting an existing event.
                var existingEvent = Events.FirstOrDefault(e => e.Id == input.id);
                if (existingEvent != null)
                {
                    Events.Remove(existingEvent);
                    return "Event deleted successfully.";
                }
                else
                {
                    return "Event not found.";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }




        public static async Task<User[]> Handle(GetAllUsers input)
        {
            try
            {
                return Users.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        public static async Task<string> Handle(AddUser input)
        {
            try
            {
                int nextUserId = Users.Count + 1;
                var newUser = new User(nextUserId, input.name, input.email);
                Users.Add(newUser);
                return "User added successfully.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }


        public static async Task<Venue[]> Handle(GetAllVenues input)
        {
            try
            {
                return Venues.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        public static async Task<string> Handle(AddVenue input)
        {
            try
            {
                int nextVenueId = Venues.Count + 1;
                var newVenue = new Venue(nextVenueId, input.name, input.location);
                Venues.Add(newVenue);
                return "Venue added successfully.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }

        


        public static async Task<Booking[]> Handle(GetAllBookings input)
        {
            try
            {
                return Bookings.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }


        public static async Task<string> Handle(AddBooking input)
        {
            try
            {
                int nextBookingId = Bookings.Count + 1;
                var newBooking = new Booking(nextBookingId, input.eventId, input.userId, input.bookingDate, input.status);
                Bookings.Add(newBooking);
                return "Booking added successfully.";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
        }



    }
}
