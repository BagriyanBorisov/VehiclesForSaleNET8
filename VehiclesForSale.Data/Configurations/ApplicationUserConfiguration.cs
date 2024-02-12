using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehiclesForSale.Data.Models;

namespace VehiclesForSale.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(Seed());
        }

        public IEnumerable<ApplicationUser> Seed()
        {
            List<ApplicationUser> users = new List<ApplicationUser>();

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seeding the User to AspNetUsers table
            ApplicationUser admin = new ApplicationUser()
            {
                Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                Email = "Pesho.peshev@abv.bg",
                NormalizedEmail = "PESHO.PESHEV@ABV.bg",
                UserName = "Pesho",
                NormalizedUserName = "pesho",
                PhoneNumber = "+359222222222",
            };
            admin.PasswordHash = hasher.HashPassword(admin, "admin1234");

            ApplicationUser user = new ApplicationUser()
            {
                Id = "a123as23-a24d-4543-a6c6-9443d048cdb9", // primary key
                Email = "Gosho.goshev@abv.bg",
                NormalizedEmail = "GOSHO.GOSHEV@ABV.BG",
                UserName = "Gosho",
                NormalizedUserName = "gosho",
                PhoneNumber = "+359111111111",
            };
            user.PasswordHash = hasher.HashPassword(user, "user1234");

            users.Add(admin);
            users.Add(user);

            return users;
        }
    }
}
