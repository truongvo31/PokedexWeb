using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using PokedexWeb.Services;

namespace PokedexWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonService _pokemon;
        private readonly IMemoryCache _cache;

        public PokemonController(PokemonService pokemon, IMemoryCache cache)
        {
            _pokemon = pokemon;
            _cache = cache;
        }

        public async Task<IActionResult> GetPokemonsAsync()
        {
            var cacheKey = "all_pokemons";
            try
            {
                var res = await _cache.GetOrCreateAsync(cacheKey, async entry =>
                {
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                    return await _pokemon.GetAllAsync();
                });
                if (res is null)
                {
                    return NotFound("No Pokemons found.");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPokemonAsync(int id)
        {
            var cacheKey = $"pokemon_{id}";
            try
            {
                var res = await _cache.GetOrCreateAsync(cacheKey, async entry =>
                {
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1);
                    return await _pokemon.GetPokemonInfoAsync(id);
                });
                if (res is null)
                {
                    return NotFound($"Pokemon with ID {id} not found.");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}/next_prev")]
        public async Task<IActionResult> GetNextPrevPokemonAsync(int id)
        {
            var cacheKey = $"next_prev_{id}";
            try
            {
                var res = await _cache.GetOrCreateAsync(cacheKey, async entry => { 
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1); 
                    return await _pokemon.GetNextPrevPokemonsAsync(id); 
                });
                if (res is null)
                {
                    return NotFound($"Next and previous Pokemon for ID {id} not found.");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}/evolution_chain")]
        public async Task<IActionResult> GetEvolutionChainAsync(int id)
        {
            var cacheKey = $"evolution_chain_{id}";
            try
            {
                var res = await _cache.GetOrCreateAsync(cacheKey, async entry => { 
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1); 
                    return await _pokemon.GetEvolutionChainAsync(id); 
                });
                if (res is null)
                {
                    return NotFound($"Evolution chain for Pokemon with ID {id} not found.");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}/type_efficacies")]
        public async Task<IActionResult> GetTypeEfficaciesAsync(int id)
        {
            var cacheKey = $"type_efficacies_{id}";
            try
            {
                var res = await _cache.GetOrCreateAsync(cacheKey, async entry => { 
                    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1); 
                    return await _pokemon.GetTypeEfficaciesAsync(id); 
                });
                if (res is null)
                {
                    return NotFound($"Type efficacies for Pokemon with ID {id} not found.");
                }
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
