namespace HairdresserClassLibrary.DTOs;

public class BookingDto
{
    public int Id { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string? Message { get; set; }
}
