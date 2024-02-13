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
                new Make { Name = "Any", Id = Guid.Parse("D22DD65D-DB45-4590-8011-7F1C58CC9045")},
                new Make { Name = "Mercedes-Benz", Id = Guid.Parse("D33DD65D-DB45-4590-8011-7F1C58CC9045")},
                new Make { Name = "BMW", Id = Guid.Parse("D44DD65D-DB45-4590-8011-7F1C58CC9045")},
                new Make { Name = "Audi", Id = Guid.Parse("D55DD65D-DB45-4590-8011-7F1C58CC9045")},
                new Make { Name = "Volkswagen", Id = Guid.Parse("D66DD65D-DB45-4590-8011-7F1C58CC9045")}
            };

            return makes;
        }
    }
}
