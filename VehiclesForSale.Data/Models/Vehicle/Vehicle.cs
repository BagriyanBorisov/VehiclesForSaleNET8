using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VehiclesForSale.Data.Models.Vehicle.Enums;

namespace VehiclesForSale.Data.Models.Vehicle
{
    public class Vehicle
    {
        public Vehicle()
        {
            
        }

        [Key]
        public Guid Id { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public int HorsePower { get; set; }

        public int EngineDisplacement { get; set; }

        public int Price { get; set; }

        public string Color { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Fuel Fuel { get; set; }

        public Transmission Transmission { get; set; }

        [ForeignKey(nameof(Extra))]
        public Guid ExtraId { get; set; }

        public Extra Extra { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
