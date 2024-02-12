using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VehiclesForSale.Data.Models
{
    public class ImageModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public Guid VehicleId { get; set; }

        [ForeignKey(nameof(VehicleId))]
        public Vehicle.Vehicle Vehicle { get; set; } = null!;
    }
}
