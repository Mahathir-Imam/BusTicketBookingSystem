namespace BusTicketBookingSystem.Models;

public class Invoice
{
    public int InvoiceId { get; set; }
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public bool IsPaid { get; set; }

    public Invoice(int invoiceId, int ticketId, int userId, decimal amount)
    {
        InvoiceId = invoiceId;
        TicketId = ticketId;
        UserId = userId;
        Amount = amount;
        Date = DateTime.Now;
        IsPaid = false;
    }
}