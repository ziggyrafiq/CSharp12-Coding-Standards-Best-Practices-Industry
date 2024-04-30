// Example of GDPR compliance
namespace ZiggyRafiq.CodeExample05.Models;

public class User
{
    // Properties
    public Guid Id { get; set; }
    public string Username { get; set; }=string.Empty;
    public string Email { get; set; }= string.Empty;
    public bool ContainsSensitiveInformation { get; set; }

    // Methods
    public void AnonymizeSensitiveInformation()
    {
        // Code to anonymize sensitive information
        if (ContainsSensitiveInformation)
        {
            // Anonymize sensitive data
            Username = "JackUser"; // Example: JackUser
            Email = "jackuser@nodomain.com";
            ContainsSensitiveInformation = false;
        }
    }

    // Delete user data in compliance with GDPR
    public void DeleteAccount()
    {
        // Code to delete user account
        if (Id != Guid.Empty)
        {
            // Perform account deletion process
            Id = Guid.Empty;
            Username = "JackUser";
            Email = "jackuser@nodomain.com";
            ContainsSensitiveInformation = false;
        }
    }
}
