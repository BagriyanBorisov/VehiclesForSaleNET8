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

        public DateTime CreatedPublicationOn { get; set; }

        public DateTime YearMade { get; set; }

        public long Mileage { get; set; }

        public int HorsePower { get; set; }

        public decimal Price { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }
        public string? Location { get; set; }

        public ICollection<string> Images { get; set; } = new HashSet<string>();

        public Fuel Fuel { get; set; }
        public Color Color { get; set; }

        public Transmission Transmission { get; set; }

        [ForeignKey(nameof(Make))]
        public Guid MakeId { get; set; }

        public Make Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        [ForeignKey(nameof(Extra))]
        public Guid ExtraId { get; set; }

        public Extra Extra { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;
    }
}
