using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiclesForSale.Data.Models.Vehicle
{
    public class Model
    {
        public Model()
        {

        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Make))]
        public Guid MakeId { get; set; }

        public Make Make { get; set; } = null!;
    }
}
