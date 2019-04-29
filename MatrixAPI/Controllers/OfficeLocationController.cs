using System.Threading.Tasks;
using MatrixAPI.CrossCutting;
using MatrixAPI.Models;
using MatrixAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MatrixAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OfficeLocationController : ControllerBase
    {
        public readonly ILocation _location;
        public OfficeLocationController(ILocation location)
        {
            _location = location;
        }


        [HttpPost]
        public async Task<Response> AddNavigationItem([FromBody] Location location)
        {
            return ResponseUtility.CreateResponse(await _location.AddNavItem(location));
        }

        [HttpGet]
        public async Task<Response> GetNavigationItems()
        {
            return ResponseUtility.CreateResponse(await _location.GetNavigationItems());

        }
    }
}