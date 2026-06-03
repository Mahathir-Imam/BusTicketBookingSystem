using BusTicketBookingSystem.Services;

UserService userService = new();
BusService busService = new();
ScheduleService scheduleService = new(busService);
BookingService bookingService = new(userService, scheduleService);
PaymentService paymentService = new(userService);

while (true)
{
    Console.WriteLine("\n===== Bus Ticket Booking System =====");
    Console.WriteLine("1. Create User");
    Console.WriteLine("2. Show Users");
    Console.WriteLine("3. Create Bus");
    Console.WriteLine("4. Show Buses");
    Console.WriteLine("5. Create Schedule");
    Console.WriteLine("6. Show Schedules");
    Console.WriteLine("7. Show Schedule Details");
    Console.WriteLine("8. Book Ticket");
    Console.WriteLine("9. Show Invoices of a User");
    Console.WriteLine("10. Pay Invoice");
    Console.WriteLine("11. Show Tickets of a User");
    Console.WriteLine("12. Exit");

    Console.Write("Choose option: ");
    int choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            userService.CreateUser();
            break;

        case 2:
            userService.ShowUsers();
            break;

        case 3:
            busService.CreateBus();
            break;

        case 4:
            busService.ShowBuses();
            break;

        case 5:
            scheduleService.CreateSchedule();
            break;

        case 6:
            scheduleService.ShowSchedules();
            break;

        case 7:
            scheduleService.ShowScheduleDetails();
            break;

        case 8:
            bookingService.BookTicket();
            break;

        case 9:
            paymentService.ShowUserInvoices();
            break;

        case 10:
            paymentService.PayInvoice();
            break;

        case 11:
            bookingService.ShowUserTickets();
            break;

        case 12:
            Console.WriteLine("Thank you. Program closed.");
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}