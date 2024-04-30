// Example of GDPR compliance
using ZiggyRafiq.CodeExample05.Models;

namespace ZiggyRafiq.CodeExample05.Services;

public class UserService
{
    // Delete user data in compliance with GDPR
    public void DeleteUser(User user)
    {
        // Check if user data contains sensitive information
        if (user.ContainsSensitiveInformation)
        {
            // Anonymize or pseudonymize sensitive data
            user.AnonymizeSensitiveInformation();
        }

        // Delete user account
        user.DeleteAccount();
    }
}
