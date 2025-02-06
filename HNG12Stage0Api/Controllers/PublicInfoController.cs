using Microsoft.AspNetCore.Mvc;

namespace HNG12Stage0Api.Controllers
{
    [ApiController]
    public class PublicInfoController : Controller
    {

        [HttpGet("public-info")]
        public IActionResult GetPublicInfo()
        {
            var response = new
            {
                email = "ajala.ba2014@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/yourusername/your-repo" // Replace with your GitHub repo URL
            };

            return Ok(response);
        }
    }
}
