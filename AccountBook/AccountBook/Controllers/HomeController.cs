using AccountBook.Models.ConvertService;
using AccountBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountBook.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{

			AccountBookEntity db = new AccountBookEntity();

			var query = db.AccountBook.Select(s => 
			new AccountInputItemViewModels()
			{
				AccountType = (AccountTypes)s.Categoryyy,
				Amount = s.Amounttt,
				Date = s.Dateee,
				Memo = s.Remarkkk
			});
			
			return View(query.ToList());
		}

		public ActionResult InputItems()
		{
			AccountInputItemViewModels input = new AccountInputItemViewModels();
			return PartialView(input);
		}
		

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}