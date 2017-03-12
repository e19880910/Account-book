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
			var list = new List<AccountInputItemViewModels>();
			foreach(var item in db.AccountBook.ToList())
			{
				list.Add(new AccountInputItemViewModels()
				{
					AccountType = (AccountTypes)item.Categoryyy,
					Amount = item.Amounttt,
					Date = item.Dateee,
					Memo = item.Remarkkk
				});
			} 
			
			return View(list);
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