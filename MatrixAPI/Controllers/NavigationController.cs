using System.Threading.Tasks;
using MatrixAPI.CrossCutting;
using MatrixAPI.Models;
using MatrixAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc;


namespace MatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavigationController : ControllerBase
    {
        private readonly INavigation _navigation;

        public NavigationController(INavigation navigation)
        {
            _navigation = navigation;
        }

        [HttpPost]
        public async Task<Response> AddNavigationItem([FromBody] Navigation navitem)
        {
            return ResponseUtility.CreateResponse(await _navigation.AddNavItem(navitem));
        }

        [HttpGet]
        public async Task<Response> GetNavigationItems()
        {
            return ResponseUtility.CreateResponse(await _navigation.GetNavigationItems());

        }
    }
}