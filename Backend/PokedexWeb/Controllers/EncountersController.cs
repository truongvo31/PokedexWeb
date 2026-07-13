using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PokedexWeb.Services;

namespace PokedexWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncountersController : ControllerBase
    {
        private readonly EncounterService _encounter;
        private readonly IMemoryCache _cache;

        public EncountersController(EncounterService encounter, IMemoryCache cache)
        {
            _encounter = encounter;
            _cache = cache;
        }

        [HttpGet("{pokemonId}")]
        public async Task<IActionResult> GetEncountersByPokemonId(int pokemonId)
        {
            var cacheKey = $"encounters_{pokemonId}";
            try
            {
                var encounters = await _cache.GetOrCreateAsync(cacheKey, async entry =>
                {
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                    return await _encounter.GetEncountersByPokemonIdAsync(pokemonId);
                });
                return Ok(encounters);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
