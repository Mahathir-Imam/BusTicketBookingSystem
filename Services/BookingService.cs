using BusTicketBookingSystem.Models;

namespace BusTicketBookingSystem.Services;

public class BookingService
{
    private readonly UserService _userService;
    private readonly ScheduleService _scheduleService;

    private int _ticketCounter = 1;
    private int _invoiceCounter = 1;

    public BookingService(UserService userService, ScheduleService scheduleService)
    {
        _userService = userService;
        _scheduleService = scheduleService;
    }

    public void BookTicket()
    {
        _userService.ShowUsers();

        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine()!);

        User? user = _userService.GetUserById(userId);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        _scheduleService.ShowSchedules();

        Console.Write("Enter Schedule ID: ");
        int scheduleId = int.Parse(Console.ReadLine()!);

        Schedule? schedule = _scheduleService.GetScheduleById(scheduleId);

        if (schedule == null)
        {
            Console.WriteLine("Schedule not found.");
            return;
        }

        _scheduleService.DisplaySeatLayout(schedule);

        Console.Write("Enter Seat No: ");
        string seatNo = Console.ReadLine()!.ToUpper();

        if (!IsValidSeat(seatNo, schedule.Bus.TotalSeats))
        {
            Console.WriteLine("Invalid seat number.");
            return;
        }

        if (schedule.BookedSeats.Contains(seatNo))
        {
            Console.WriteLine($"Seat {seatNo} is already booked. Please choose another seat.");
            return;
        }

        Ticket ticket = new Ticket(_ticketCounter++, user.UserId, schedule.ScheduleId, seatNo, schedule.Fare);
        user.Tickets.Add(ticket);

        schedule.BookedSeats.Add(seatNo);

        Invoice invoice = new Invoice(_invoiceCounter++, ticket.TicketId, user.UserId, schedule.Fare);
        user.Invoices.Add(invoice);

        Console.WriteLine("\nTicket booked successfully.");
        Console.WriteLine($"Ticket ID: {ticket.TicketId}");
        Console.WriteLine($"Coach No: {schedule.Bus.CoachNo}");
        Console.WriteLine($"Journey: {schedule.JourneyDateTime:yyyy-MM-dd}");
        Console.WriteLine($"Seat: {ticket.SeatNo}");

        Console.WriteLine("\nInvoice generated.");
        Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
        Console.WriteLine($"Amount: {invoice.Amount}");
        Console.WriteLine("Paid: No");
    }

    private bool IsValidSeat(string seatNo, int totalSeats)
    {
        if (seatNo.Length < 2)
        {
            return false;
        }

        char letter = seatNo[^1];

        if (letter != 'A' && letter != 'B' && letter != 'C' && letter != 'D')
        {
            return false;
        }

        string rowPart = seatNo[..^1];

        if (!int.TryParse(rowPart, out int row))
        {
            return false;
        }

        int seatNumber = ((row - 1) * 4) + (letter - 'A' + 1);

        return seatNumber >= 1 && seatNumber <= totalSeats;
    }

    public void ShowUserTickets()
    {
        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine()!);

        User? user = _userService.GetUserById(userId);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine("\nTickets:");

        foreach (Ticket ticket in user.Tickets)
        {
            Console.WriteLine($"Ticket ID: {ticket.TicketId}");
            Console.WriteLine($"Schedule ID: {ticket.ScheduleId}");
            Console.WriteLine($"Seat: {ticket.SeatNo}");
            Console.WriteLine($"Fare: {ticket.Fare}");
            Console.WriteLine("-----------------------------");
        }
    }
}