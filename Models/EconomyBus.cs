namespace BusTicketBookingSystem.Models;

public class EconomyBus : Bus
{
    public override int TotalSeats => 40;

    public EconomyBus(int busId, string coachNo)
        : base(busId, coachNo, "Economy")
    {
    }
}