using System;

public interface IEmailService
{
    void SendEmail(string message);
}

public class EmailService : IEmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}

public class UserService
{
    private readonly IEmailService _emailService;

    // Injecting dependency via constructor
    public UserService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void RegisterUser(string name)
    {
        Console.WriteLine($"User {name} registered successfully.");
        _emailService.SendEmail($"Welcome {name}!");
    }
}

class Program
{
    static void Main()
    {
        IEmailService emailService = new EmailService();
        UserService userService = new UserService(emailService);
        userService.RegisterUser("John Doe");
    }
}


// .Net core
var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<UserService>();

var app = builder.Build();

// Resolve dependencies
var userService = app.Services.GetRequiredService<UserService>();
userService.RegisterUser("John Doe");

app.Run();