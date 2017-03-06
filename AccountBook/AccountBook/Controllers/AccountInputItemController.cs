using AccountBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountBook.Controllers
{
    public class AccountInputItemController : Controller
    {
        // GET: AccountInputItem
        public ActionResult AccountInputItem()
        {
            return View();
        }


		[HttpPost]
		public ActionResult Submit(AccountInputItemViewModels inputData)
		{
			return View(inputData);
		}


	}
}