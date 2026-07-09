using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PokedexWeb.Services;

namespace PokedexWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        private readonly TypeService _type;

        public TypesController(IMemoryCache cache, TypeService type)
        {
            _cache = cache;
            _type = type;
        }

        [HttpGet("strings")]
        public async Task<IActionResult> GetAllTypesStrings()
        {
            var cacheKey = "all_types_strings";
            var types = await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                return await _type.GetAllTypesAsStringAsync();
            });
            return Ok(types);
        }
    }
}
