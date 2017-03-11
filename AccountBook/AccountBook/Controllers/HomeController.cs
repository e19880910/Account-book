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
			AccountInputItemViewModels accountInputItem1 = new AccountInputItemViewModels();
			accountInputItem1.AccountType = AccountTypes.Expense;
			accountInputItem1.Date = new DateTime(2016,1,1);
			accountInputItem1.Amount = 300;
			accountInputItem1.Memo = string.Empty;

			AccountInputItemViewModels accountInputItem2 = new AccountInputItemViewModels();
			accountInputItem2.AccountType = AccountTypes.Expense;
			accountInputItem2.Date = new DateTime(2016, 1, 2);
			accountInputItem2.Amount = 1600;
			accountInputItem2.Memo = string.Empty;

			AccountInputItemViewModels accountInputItem3 = new AccountInputItemViewModels();
			accountInputItem3.AccountType = AccountTypes.Expense;
			accountInputItem3.Date = new DateTime(2016, 1, 3);
			accountInputItem3.Amount = 800;
			accountInputItem3.Memo = string.Empty;

			List<AccountInputItemViewModels> list = new List<AccountInputItemViewModels>();
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