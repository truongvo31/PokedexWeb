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
    }
}
