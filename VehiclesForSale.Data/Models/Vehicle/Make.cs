using System.ComponentModel.DataAnnotations;

namespace VehiclesForSale.Data.Models.Vehicle
{
    public class Make
    {
        public Make()
        {
            Models = new HashSet<Model>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public ICollection<Model> Models { get; set; }
    }
}
