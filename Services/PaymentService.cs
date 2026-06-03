using BusTicketBookingSystem.Models;

namespace BusTicketBookingSystem.Services;

public class PaymentService
{
    private readonly UserService _userService;

    public PaymentService(UserService userService)
    {
        _userService = userService;
    }

    public void ShowUserInvoices()
    {
        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine()!);

        User? user = _userService.GetUserById(userId);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine("\nInvoices:");

        foreach (Invoice invoice in user.Invoices)
        {
            Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
            Console.WriteLine($"Ticket ID: {invoice.TicketId}");
            Console.WriteLine($"Amount: {invoice.Amount}");
            Console.WriteLine($"Date: {invoice.Date:yyyy-MM-dd}");
            Console.WriteLine($"Paid: {(invoice.IsPaid ? "Yes" : "No")}");
            Console.WriteLine("-----------------------------");
        }
    }

    public void PayInvoice()
    {
        Console.Write("Enter User ID: ");
        int userId = int.Parse(Console.ReadLine()!);

        User? user = _userService.GetUserById(userId);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        ShowUserInvoicesByUser(user);

        Console.Write("Enter Invoice ID: ");
        int invoiceId = int.Parse(Console.ReadLine()!);

        Invoice? invoice = user.Invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);

        if (invoice == null)
        {
            Console.WriteLine("Invoice not found.");
            return;
        }

        if (invoice.IsPaid)
        {
            Console.WriteLine("Invoice already paid.");
            return;
        }

        invoice.IsPaid = true;

        Console.WriteLine("Payment successful.");
    }

    private void ShowUserInvoicesByUser(User user)
    {
        Console.WriteLine("\nInvoices:");

        foreach (Invoice invoice in user.Invoices)
        {
            Console.WriteLine($"Invoice ID: {invoice.InvoiceId}");
            Console.WriteLine($"Ticket ID: {invoice.TicketId}");
            Console.WriteLine($"Amount: {invoice.Amount}");
            Console.WriteLine($"Paid: {(invoice.IsPaid ? "Yes" : "No")}");
            Console.WriteLine("-----------------------------");
        }
    }
}