using AccountBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountBook.Controllers
{
    public class AccountRecordDataController : Controller
    {
        // GET: AccountRecordData
        public ActionResult ShowData(AccountRecordDataViewModels accountRecordData)
        {
			accountRecordData = new AccountRecordDataViewModels()
			{
				AccountRecordData = new List<AccountInputItemViewModels>()
				{
					new AccountInputItemViewModels()
					{
						AccountType = AccountTypes.Expense,
						Date = new DateTime(2016,1,1),
						Amount = 300,
						Memo = ""

					}

				}
			};

			return View();
        }



    }
}