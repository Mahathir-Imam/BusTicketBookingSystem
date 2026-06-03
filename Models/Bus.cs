namespace BusTicketBookingSystem.Models;

public abstract class Bus
{
    public int BusId { get; set; }
    public string CoachNo { get; set; }
    public string Type { get; set; }
    public abstract int TotalSeats { get; }

    protected Bus(int busId, string coachNo, string type)
    {
        BusId = busId;
        CoachNo = coachNo;
        Type = type;
    }
}