using VehiclesForSale.Data.Models.Vehicle.Enums;

namespace VehiclesForSale.Data.Models.Vehicle
{
    public class Extra
    {
        public Extra()
        {
            
        }

        public Guid Id { get; set; }

        public ICollection<SafetyExtra> SafetyExtras { get; set; } = new HashSet<SafetyExtra>();

        public ICollection<ComfortExtra> ComfortExtras { get; set; } = new HashSet<ComfortExtra>();

        public ICollection<ExteriorExtra> ExteriorExtras { get; set; } = new HashSet<ExteriorExtra>();

        public ICollection<InteriorExtra> InteriorExtras { get; set; } = new HashSet<InteriorExtra>();

    }
}
