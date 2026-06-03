using BusTicketBookingSystem.Models;

namespace BusTicketBookingSystem.Services;

public class UserService
{
    public List<User> Users { get; set; } = new();

    public void CreateUser()
    {
        int userId = Users.Count + 1;

        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Mobile: ");
        string mobile = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        string email = Console.ReadLine()!;

        User user = new User(userId, name, mobile, email);
        Users.Add(user);

        Console.WriteLine("User created successfully.");
    }

    public void ShowUsers()
    {
        Console.WriteLine("\nUsers:");

        foreach (User user in Users)
        {
            Console.WriteLine($"{user.UserId}. {user.Name} | {user.Mobile} | {user.Email}");
        }
    }

    public User? GetUserById(int userId)
    {
        return Users.FirstOrDefault(u => u.UserId == userId);
    }
}