using BusTicketBookingSystem.Models;

namespace BusTicketBookingSystem.Services;

public class ScheduleService
{
    public List<Schedule> Schedules { get; set; } = new();

    private readonly BusService _busService;

    public ScheduleService(BusService busService)
    {
        _busService = busService;
    }

    public void CreateSchedule()
    {
        int scheduleId = Schedules.Count + 1;

        _busService.ShowBuses();

        Console.Write("Enter Bus ID: ");
        int busId = int.Parse(Console.ReadLine()!);

        Bus? bus = _busService.GetBusById(busId);

        if (bus == null)
        {
            Console.WriteLine("Bus not found.");
            return;
        }

        Console.Write("From City: ");
        string fromCity = Console.ReadLine()!;

        Console.Write("To City: ");
        string toCity = Console.ReadLine()!;

        Console.Write("Journey Date and Time (example: 2026-06-03 07:00): ");
        DateTime journeyDateTime = DateTime.Parse(Console.ReadLine()!);

        Console.Write("Fare: ");
        decimal fare = decimal.Parse(Console.ReadLine()!);

        Schedule schedule = new Schedule(scheduleId, bus, fromCity, toCity, journeyDateTime, fare);
        Schedules.Add(schedule);

        Console.WriteLine("Schedule created successfully.");
    }

    public void ShowSchedules()
    {
        Console.WriteLine("\nSchedules:");

        foreach (Schedule schedule in Schedules)
        {
            Console.WriteLine($"{schedule.ScheduleId}. Bus {schedule.Bus.CoachNo} | {schedule.FromCity} -> {schedule.ToCity}");
            Console.WriteLine($"Date: {schedule.JourneyDateTime:yyyy-MM-dd}");
            Console.WriteLine($"Time: {schedule.JourneyDateTime:HH:mm}");
            Console.WriteLine($"Fare: {schedule.Fare}");
            Console.WriteLine("-----------------------------");
        }
    }

    public void ShowScheduleDetails()
    {
        Console.Write("Enter Schedule ID: ");
        int scheduleId = int.Parse(Console.ReadLine()!);

        Schedule? schedule = GetScheduleById(scheduleId);

        if (schedule == null)
        {
            Console.WriteLine("Schedule not found.");
            return;
        }

        Console.WriteLine($"\nBus {schedule.Bus.CoachNo} | {schedule.FromCity} -> {schedule.ToCity}");
        Console.WriteLine($"Date: {schedule.JourneyDateTime:yyyy-MM-dd}");
        Console.WriteLine($"Time: {schedule.JourneyDateTime:HH:mm}");
        Console.WriteLine($"Fare: {schedule.Fare}");
        Console.WriteLine("\nSeat Layout (X = booked)");

        DisplaySeatLayout(schedule);
    }

    public void DisplaySeatLayout(Schedule schedule)
    {
        int totalRows = schedule.Bus.TotalSeats / 4;
        char[] seatLetters = { 'A', 'B', 'C', 'D' };

        for (int row = 1; row <= totalRows; row++)
        {
            foreach (char letter in seatLetters)
            {
                string seatNo = $"{row}{letter}";

                if (schedule.BookedSeats.Contains(seatNo))
                {
                    Console.Write("[ X ] ");
                }
                else
                {
                    Console.Write($"[{seatNo}] ");
                }
            }

            Console.WriteLine();
        }
    }

    public Schedule? GetScheduleById(int scheduleId)
    {
        return Schedules.FirstOrDefault(s => s.ScheduleId == scheduleId);
    }
}