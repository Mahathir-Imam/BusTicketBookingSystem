namespace BusTicketBookingSystem.Models;

public class Schedule
{
    public int ScheduleId { get; set; }
    public Bus Bus { get; set; }
    public string FromCity { get; set; }
    public string ToCity { get; set; }
    public DateTime JourneyDateTime { get; set; }
    public decimal Fare { get; set; }

    public List<string> BookedSeats { get; set; } = new();

    public Schedule(int scheduleId, Bus bus, string fromCity, string toCity, DateTime journeyDateTime, decimal fare)
    {
        ScheduleId = scheduleId;
        Bus = bus;
        FromCity = fromCity;
        ToCity = toCity;
        JourneyDateTime = journeyDateTime;
        Fare = fare;
    }
}