using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatrixAPI.CrossCutting;
using MatrixAPI.Models;
using MatrixAPI.Services.Contracts;
using Microsoft.AspNetCore.Http;
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
        [Route("AddNavigationItem")]
        public async Task<Response> AddNavigationItem([FromBody] Navigation navitem)
        {
            //var result = await _navigation.AddNavItem(navitem);
            return ResponseUtility.CreateResponse(await _navigation.AddNavItem(navitem));
        }

        [HttpGet]
        [Route("GetNavigationItems")]
        public async Task<Response> GetNavigationItems()
        {
            //var result = await _navigation.GetNavigationItems();
            return ResponseUtility.CreateResponse(await _navigation.GetNavigationItems());

        }
    }
}