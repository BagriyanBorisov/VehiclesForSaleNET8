using System.ComponentModel.DataAnnotations;

namespace VehiclesForSale.Services.ViewModels.Model
{
    public class ModelViewModel
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public Guid Id { get; set; }
    }
}
