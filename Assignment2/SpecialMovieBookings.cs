public class SpecialMovieBookingSystem : MovieBookingSystem
{
    // Static Field
    private static int specialSeatsReserved = 10;

    // Constructor for SpecialMovieBookingSystem
    public SpecialMovieBookingSystem(string title, string genre, int maximumSeats) : base(title, genre, maximumSeats)
    {
    }

    // Method specific to SpecialMovieBookingSystem
    public void ReserveSpecialSeats(int seats)
    {
        if (seats > 0 && seats <= MaximumSeats && specialSeatsReserved + seats <= MaximumSeats)
        {
            specialSeatsReserved += seats;
            Console.WriteLine($"Reserved {seats} special seats for {Title} - {Genre}");
        }
        else
        {
            Console.WriteLine($"Failed to reserve {seats} special seats for {Title} - {Genre}. Insufficient seats or invalid quantity.");
        }
    }

    // Overrides the BookSeats method from the base class
    public override bool BookSeats(int seats)
    {
        
        // Calling the base class method for common booking logic
        return base.BookSeats(seats);
    }
}
