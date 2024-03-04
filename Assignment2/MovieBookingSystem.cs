public class MovieBookingSystem : TicketBookingSystem, TicketInfo
{
    // Property1 for MovieBookingSystem
    public string Genre { get; set; }

    // Constructor for MovieBookingSystem
    public MovieBookingSystem(string title, string genre, int maximumSeats) : base(title)
    {
        Genre = genre;
        MaximumSeats = maximumSeats;
    }

    // Overrides ReadOnlyProperty from the base class
    public override int MaximumSeats { get; }

    // Overrides DisplayInfo method from the base class
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Genre: {Genre}");
    }

    // Overrides BookSeats method from the base class
    public override bool BookSeats(int seats)
    {
        if (seats > 0 && bookedSeats + seats <= MaximumSeats)
        {
            bookedSeats += seats;
            Console.WriteLine($"Successfully booked {seats} seats for {Title} - {Genre}");
            return true;
        }
        else
        {
            Console.WriteLine($"Failed to book {seats} seats for {Title} - {Genre}. Insufficient seats or invalid quantity.");
            return false;
        }
    }
    public void DisplayTicketInfo()
    {
        Console.WriteLine($"Ticket Information for {Title} - {Genre}");
        Console.WriteLine($"Maximum Seats: {MaximumSeats}");
        Console.WriteLine($"Booked Seats: {bookedSeats}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
