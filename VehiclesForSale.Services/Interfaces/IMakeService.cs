using VehiclesForSale.Services.ViewModels.Make;

namespace VehiclesForSale.Services.Interfaces
{
    public interface IMakeService
    {
        Task<IEnumerable<MakeViewModel>> GetAllMakesAsync();

        Task CreateMakeAsync(string name);

        Task DeleteMakeAsync(Guid id);
    }
}
