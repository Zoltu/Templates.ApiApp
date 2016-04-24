using Microsoft.AspNet.Mvc;

namespace magic_github_owner_magic.magic_github_repo_magic.Controllers
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
