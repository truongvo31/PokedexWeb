using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokedexWeb.Services;

namespace PokedexWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonService _pokemon;

        public PokemonController(PokemonService pokemon)
        {
            _pokemon = pokemon;
        }

        public async Task<IActionResult> GetPokemonsAsync()
        {
            try
            {
                var res = await _pokemon.GetAllAsync();
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
            try
            {
                var res = await _pokemon.GetPokemonInfoAsync(id);
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
            try
            {
                var res = await _pokemon.GetNextPrevPokemonsAsync(id);
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
            try
            {
                var res = await _pokemon.GetEvolutionChainAsync(id);
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
            try
            {
                var res = await _pokemon.GetTypeEfficaciesAsync(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
