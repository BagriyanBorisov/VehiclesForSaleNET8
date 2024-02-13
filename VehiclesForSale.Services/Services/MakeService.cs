using Microsoft.EntityFrameworkCore;
using VehiclesForSale.Data;
using VehiclesForSale.Data.Models.Vehicle;
using VehiclesForSale.Services.Interfaces;
using VehiclesForSale.Services.ViewModels.Make;

namespace VehiclesForSale.Services.Services
{
    public class MakeService : IMakeService
    {
        private readonly VehiclesDbContext dbContext;

        public MakeService(VehiclesDbContext context)
        {
            this.dbContext = context;
        }

        public async Task CreateMakeAsync(string makeName)
        {
            if (!string.IsNullOrEmpty(makeName) || !string.IsNullOrWhiteSpace(makeName))
            {
                var makeToAdd = new Make()
                {
                    Name = makeName,
                };

                await dbContext.Makes.AddAsync(makeToAdd);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteMakeAsync(Guid makeId)
        {
            var makeToDel = await dbContext.Makes.Where(m => m.Id == makeId).FirstOrDefaultAsync();
            if (makeToDel == null)
            {
                throw new NullReferenceException("This make does not exist!");
            }
            var modelsToDel = await dbContext.Models.Where(m => m.MakeId == makeId).ToListAsync();

            dbContext.Models.RemoveRange(modelsToDel);
            dbContext.Makes.Remove(makeToDel);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<MakeViewModel>> GetAllMakesAsync()
        {
            return await dbContext.Makes
                .Select(e => new MakeViewModel(){Id = e.Id, Name = e.Name})
                .ToListAsync();
        }

      
    }
}
