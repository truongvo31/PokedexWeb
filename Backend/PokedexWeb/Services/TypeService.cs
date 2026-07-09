using Microsoft.EntityFrameworkCore;
using PokedexWeb.Data;

namespace PokedexWeb.Services
{
    public class TypeService
    {
        private readonly AppDbContext _dbContext;

        public TypeService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<string>> GetAllTypesAsStringAsync()
        {
            return await _dbContext.Types.AsNoTracking()
                .Select(x => x.Name)
                .OrderBy(x => x)
                .ToListAsync();
        }
    }
}
