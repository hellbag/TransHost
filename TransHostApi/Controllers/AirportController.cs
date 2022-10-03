using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransHostApi.Contracts;
using TransHostApi.Services;

namespace TransHostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _airport;

        // GET api/values
        public AirportController(IAirportService airport)
        {
            _airport = airport;
        }

        /// <summary>
        /// Расчет расстояния между аэропортами
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        [HttpGet("distance")]
        [ProducesResponseType(typeof(OkResponse<double>), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 200)]
        public async Task<ActionResult<ApiResponse>> Distance(
            string src, string dest)
        {
            return new OkResponse<double>() { success = true, data = await _airport.GetDistance(src, dest) };
        }
    }
}