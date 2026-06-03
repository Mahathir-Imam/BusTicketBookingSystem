namespace BusTicketBookingSystem.Models;

public class BusinessBus : Bus
{
    public override int TotalSeats => 20;

    public BusinessBus(int busId, string coachNo)
        : base(busId, coachNo, "Business")
    {
    }
}