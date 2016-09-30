using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;

namespace TheWorld.Controllers.Web
{
	public class AppController : Controller
	{
		private IMailService _mailService;

		public AppController(IMailService mailService)
		{
			_mailService = mailService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(ContactViewModel model)
		{
			_mailService.SendMail("shawn@aol.com", model.Email, "From TheWorld", model.Message);

			return View();
		}

		public IActionResult About()
		{
			return View();
		}
	}
}
