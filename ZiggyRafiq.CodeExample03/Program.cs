using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Web;
using ZiggyRafiq.CodeExample03;
using ZiggyRafiq.CodeExample03.Inheritance;

Console.WriteLine("Hello, from Ziggy Rafiq!");

//Inheritance Code Example
Dog dog = new Dog();
dog.Eat();  // Inherited method from Animal class
dog.Bark(); // Method specific to Dog class



//Try-Catch Blocks Code Example One
try
{
    // Code that may throw an exception
    int x = 10;
    int y = 0;
    int result = x / y; // Division by zero will throw an exception
    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{
    // Handle exception
    Console.WriteLine($"An error occurred: {ex.Message}");
}

//Try-Catch Blocks Code Example Two
try
{
    // Code that may throw an exception
    int age = -5;
    if (age < 0)
    {
        throw new CustomException("Age cannot be negative.");
    }
    Console.WriteLine($"Age: {age}");
}
catch (CustomException ex)
{
    // Handle custom exception
    Console.WriteLine($"Custom Exception: {ex.Message}");
}
catch (Exception ex)
{
    // Handle other exceptions
    Console.WriteLine($"An error occurred: {ex.Message}");
}

//Garbage Collection Code Example

// Allocate memory for a large object
byte[] largeObject = new byte[1000000];

// Indicate to the garbage collector that now would be a good time to collect garbage.
GC.Collect();

// Display total memory allocated for the program
long memoryAllocated = GC.GetTotalMemory(true);
Console.WriteLine($"Total memory allocated: {memoryAllocated} bytes");


//Performance Profiling Code Example
// Create a Stopwatch instance
Stopwatch stopwatch = new Stopwatch();

// Start the stopwatch
stopwatch.Start();

// Code section to be profiled
for (int i = 0; i < 1000000; i++)
{
    // Simulate some operation
    double result = Math.Sqrt(i);
}

// Stop the stopwatch
stopwatch.Stop();

// Display elapsed time
Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} milliseconds");


//Input Validation Code Example
// Simulated user input
string userInput = "<script>alert('XSS attack');</script>";

// Validate input to prevent XSS
string sanitizedInput = HttpUtility.HtmlEncode(userInput);

// Simulated SQL query
string sqlQuery = "SELECT * FROM Users WHERE Username = @Username";

// Create SQL connection and command
using (SqlConnection connection = new SqlConnection("connectionString"))
{
    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
    {
        // Validate input to prevent SQL injection
        command.Parameters.AddWithValue("@Username", sanitizedInput);

        // Execute SQL command
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            // Process data
        }
    }
}


//Authentication and Authorization Code Example
// Simulated user credentials
string username = "user123";
string password = "password123";

// Simulated user input
string userInputUsername = Console.ReadLine();
string userInputPassword = Console.ReadLine();

// Simulated user roles
string[] userRoles = { "Admin", "User" };

// Perform authentication
bool isAuthenticated = AuthenticateUser(username, password, userInputUsername, userInputPassword);

if (isAuthenticated)
{
    // Perform authorization
    bool isAuthorized = AuthorizeUser(userRoles, "Admin");

    if (isAuthorized)
    {
        // Access granted to sensitive resource
        Console.WriteLine("Access granted to sensitive resource.");
    }
    else
    {
        // User is not authorized
        Console.WriteLine("Access denied: User is not authorized to access this resource.");
    }
}
else
{
    // Authentication failed
    Console.WriteLine("Authentication failed: Invalid username or password.");
}
    

static bool AuthenticateUser(string expectedUsername, string expectedPassword, string userInputUsername, string userInputPassword)
{
    return expectedUsername == userInputUsername && expectedPassword == userInputPassword;
}

static bool AuthorizeUser(string[] userRoles, string requiredRole)
{
    return Array.Exists(userRoles, role => role == requiredRole);
}

