using System.Threading.Tasks;
using MatrixAPI.CrossCutting;
using MatrixAPI.Models;
using Microsoft.AspNetCore.Mvc;
using MatrixAPI.Services.Contracts;

namespace MatrixAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        [Route("SendEmail")]
        public async Task<Response> SendEmailToSaaramsha([FromBody] Email mail)
        {
            return ResponseUtility.CreateResponse(await _emailService.SendEmail(mail));
        }

    
    }


   
}