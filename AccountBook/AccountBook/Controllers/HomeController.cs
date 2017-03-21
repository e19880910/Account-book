using AccountBook.Models.ConvertService;
using AccountBook.Models.DbService;
using AccountBook.Models.ViewModels;
using ServiceLab.Repositories;
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
			var unitOfWork = new EFUnitOfWork();
			var db = new AccountBookDbService(unitOfWork);
			return View(db.GetAll());
		}

		public ActionResult InputItems()
		{
			var input = new AccountInputItemViewModels();
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


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult InputItems(AccountTypes accountType, decimal amount, string date, string memo)
		{
			DateTime d;
			DateTime.TryParse(date, out d);

			var item = new AccountInputItemViewModels();
			item.AccountType = accountType;
			item.Amount = amount;
			item.Date = d;
			item.Memo = memo;

			var unitOfWork = new EFUnitOfWork();
			var db = new AccountBookDbService(unitOfWork);

			db.AddItem(item);
			db.Save();
			
			return PartialView(item);
		}


	}
}