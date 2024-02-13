using Microsoft.EntityFrameworkCore;
using VehiclesForSale.Data;
using VehiclesForSale.Data.Models.Vehicle;
using VehiclesForSale.Services.Interfaces;
using VehiclesForSale.Services.ViewModels.Model;

namespace VehiclesForSale.Services.Services
{
    public class ModelService : IModelService
    {
        private readonly VehiclesDbContext context;

        public ModelService(VehiclesDbContext context)
        {
            this.context = context;
        }

        public async Task AddModelAsync(string modelName, Guid makeId)
        {
            var modelToAdd = new Model()
            {
                Name = modelName,
                MakeId = makeId
            };

            await context.Models.AddAsync(modelToAdd);
            await context.SaveChangesAsync();

        }

        public async Task<bool> CheckByNameExist(string modelName, Guid makeId)
        {
            return await context.Models.Where(m => m.MakeId == makeId && m.Name.ToLower() == modelName.ToLower()).AnyAsync();
        }

        public async Task DeleteModelAsync(Guid modelId)
        {
            var modToDel = await context.Models.Where(m => m.Id == modelId).FirstOrDefaultAsync();

            if (modToDel == null)
            {
                throw new NullReferenceException("This model does not exists");
            }

            context.Models.Remove(modToDel);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ModelViewModel>> GetAllAsync(Guid makeId)
        {
            return await context.Models
                .Where(m => m.MakeId == makeId)
                .Select(e => new ModelViewModel(){Id = e.Id, Name = e.Name}).ToListAsync();
        }

        public async Task<IEnumerable<ModelViewModel>> GetForAllMakesAsync()
        {
            return await context.Models
                    .Select(e => new ModelViewModel(){Id = e.Id, Name = e.Name}).ToListAsync();
        }
    }
}
