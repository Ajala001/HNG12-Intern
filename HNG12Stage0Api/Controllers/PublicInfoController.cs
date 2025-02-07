using Microsoft.AspNetCore.Mvc;

namespace HNG12Stage0Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class PublicInfoController : Controller
    {

        [HttpGet("info")]
        public IActionResult GetPublicInfo()
        {
            var response = new
            {
                email = "ajala.ba2014@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/Ajala001/HNG12-Intern.git" 
            };

            return Ok(response);
        }
    }
}
