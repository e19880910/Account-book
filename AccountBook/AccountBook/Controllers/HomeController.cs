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
			var accountInputItem1 = new AccountInputItemViewModels()
			{
				AccountType = AccountTypes.Expense,
				Date = new DateTime(2016, 1, 1),
				Amount = 300,
				Memo = string.Empty
			};

			var accountInputItem2 = new AccountInputItemViewModels()
			{
				AccountType = AccountTypes.Expense,
				Date = new DateTime(2016, 1, 2),
				Amount = 1600,
				Memo = string.Empty
			};

			var accountInputItem3 = new AccountInputItemViewModels()
			{
				AccountType = AccountTypes.Expense,
				Date = new DateTime(2016, 1, 3),
				Amount = 800,
				Memo = string.Empty
			};

			var list = new List<AccountInputItemViewModels>();
			list.Add(accountInputItem1);
			list.Add(accountInputItem2);
			list.Add(accountInputItem3);
			
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