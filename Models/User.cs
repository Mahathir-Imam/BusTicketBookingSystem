namespace BusTicketBookingSystem.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }

    public List<Ticket> Tickets { get; set; } = new();
    public List<Invoice> Invoices { get; set; } = new();

    public User(int userId, string name, string mobile, string email)
    {
        UserId = userId;
        Name = name;
        Mobile = mobile;
        Email = email;
    }
}