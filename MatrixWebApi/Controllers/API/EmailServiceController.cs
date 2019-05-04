using System.Threading.Tasks;
using System.Web.Http;
using MatrixWebApi.Contracts;
using MatrixWebApi.CrossCutting;
using MatrixWebApi.Models;

namespace MatrixWebApi.Controllers.API
{
    [RoutePrefix("api/email")]
    public class EmailServiceController : ApiController
    {
        private readonly IEmail _emailService;
        public EmailServiceController(IEmail emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        [Route("SendEmail")]
        public async Task<Response> SendEmail([FromBody] Email mail)
        {
            return ResponseUtility.CreateResponse(await _emailService.SendEmail(mail));
        }

    }
}
