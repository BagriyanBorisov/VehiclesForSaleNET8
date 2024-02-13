using VehiclesForSale.Services.ViewModels.Model;

namespace VehiclesForSale.Services.Interfaces
{
    public interface IModelService
    {
        public Task<IEnumerable<ModelViewModel>> GetAllAsync(Guid makeId);
        public Task<IEnumerable<ModelViewModel>> GetForAllMakesAsync();
        public Task AddModelAsync(string modelName, Guid makeId);
        public Task<bool> CheckByNameExist(string modelName, Guid makeId);
        public Task DeleteModelAsync(Guid modelId);
    }
}
