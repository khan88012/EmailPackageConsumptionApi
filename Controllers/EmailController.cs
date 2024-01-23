using CustomEmailKit.Models;
using CustomEmailKit.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailPackageConsumptionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailservice;

        public EmailController(IEmailService emailservice)
        {
            _emailservice = emailservice;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            if (request != null)
            {
                _emailservice.SendEmail(request);
                return Ok();
            }
            return BadRequest();
        }
    }
}
