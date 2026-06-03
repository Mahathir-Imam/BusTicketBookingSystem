namespace BusTicketBookingSystem.Models;

public class Ticket
{
    public int TicketId { get; set; }
    public int UserId { get; set; }
    public int ScheduleId { get; set; }
    public string SeatNo { get; set; }
    public decimal Fare { get; set; }

    public Ticket(int ticketId, int userId, int scheduleId, string seatNo, decimal fare)
    {
        TicketId = ticketId;
        UserId = userId;
        ScheduleId = scheduleId;
        SeatNo = seatNo;
        Fare = fare;
    }
}