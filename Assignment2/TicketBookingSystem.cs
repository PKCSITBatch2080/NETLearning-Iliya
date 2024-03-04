using System;
public abstract class TicketBookingSystem
{
    // Property 1: Title
    public string Title { get; set; }

    // Property 2: ReadOnly 
    public abstract int MaximumSeats { get; }

    // Field
    protected int bookedSeats;

    // Constructor
    public TicketBookingSystem(string title)
    {
        Title = title;
        bookedSeats = 0; 
    }

    // Method to display information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ticket Booking System for: {Title}");
        Console.WriteLine($"Maximum Seats: {MaximumSeats}");
        Console.WriteLine($"Booked Seats: {bookedSeats}");
    }

    // Abstract method for booking tickets
    public abstract bool BookSeats(int seats);
}
