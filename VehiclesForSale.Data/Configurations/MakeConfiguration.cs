using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehiclesForSale.Data.Models.Vehicle;

namespace VehiclesForSale.Data.Configurations
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(Seed());
        }

        public IEnumerable<Make> Seed()
        {
            List<Make> makes = new List<Make>
            {
                new Make { Name = "Any" },
                new Make { Name = "Mercedes-Benz"},
                new Make { Name = "BMW"},
                new Make { Name = "Audi"},
                new Make { Name = "Volkswagen"}
            };

            return makes;
        }
    }
}
