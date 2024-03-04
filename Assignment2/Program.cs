class Program
{
    static void Main()
    {
        MovieBookingSystem movieBooking = new MovieBookingSystem("Inception", "Science Fiction", 200);
        movieBooking.DisplayInfo();

        // Booking seats
        movieBooking.BookSeats(4);
        movieBooking.DisplayInfo();

        SpecialMovieBookingSystem specialMovieBooking = new SpecialMovieBookingSystem("Avatar", "Fantasy", 10);
        specialMovieBooking.DisplayInfo();

        // Booking seats and reserving special seats for the special movie
        specialMovieBooking.BookSeats(5);
        specialMovieBooking.ReserveSpecialSeats(2);
        specialMovieBooking.DisplayInfo();
    }
}
