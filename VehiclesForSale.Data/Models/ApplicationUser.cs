using Microsoft.AspNetCore.Identity;

namespace VehiclesForSale.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            RegistrationDate = DateTime.UtcNow;
        }

        public DateTime RegistrationDate { get; internal set; }
    }
}

