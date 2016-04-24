using Microsoft.AspNet.Mvc;

namespace Templates.ApiApp.Controllers
{
	[Route("api/[controller]")]
	public class magic_controller_name_magicController : Controller
	{
		// GET: api/values
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Greetings.");
		}
	}
}
