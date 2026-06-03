using BusTicketBookingSystem.Models;

namespace BusTicketBookingSystem.Services;

public class BusService
{
    public List<Bus> Buses { get; set; } = new();

    public void CreateBus()
    {
        int busId = Buses.Count + 1;

        Console.Write("Enter Coach No: ");
        string coachNo = Console.ReadLine()!;

        Console.Write("Enter Bus Type (Business/Economy): ");
        string type = Console.ReadLine()!;

        Bus bus;

        if (type.Equals("Business", StringComparison.OrdinalIgnoreCase))
        {
            bus = new BusinessBus(busId, coachNo);
        }
        else if (type.Equals("Economy", StringComparison.OrdinalIgnoreCase))
        {
            bus = new EconomyBus(busId, coachNo);
        }
        else
        {
            Console.WriteLine("Invalid bus type.");
            return;
        }

        Buses.Add(bus);
        Console.WriteLine("Bus created successfully.");
    }

    public void ShowBuses()
    {
        Console.WriteLine("\nBuses:");

        foreach (Bus bus in Buses)
        {
            Console.WriteLine($"{bus.BusId}. Bus {bus.CoachNo} | {bus.Type} | Seats: {bus.TotalSeats}");
        }
    }

    public Bus? GetBusById(int busId)
    {
        return Buses.FirstOrDefault(b => b.BusId == busId);
    }
}