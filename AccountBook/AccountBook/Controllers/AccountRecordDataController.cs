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
        public ActionResult AccountRecordData()
        {
			//AccountRecordDataViewModels accountRecordData = new AccountRecordDataViewModels()
			//{
			//	AccountRecordData = new List<AccountInputItemViewModels>()
			//	{
			//		new AccountInputItemViewModels()
			//		{
			//			AccountType = AccountTypes.Expense,
			//			Date = new DateTime(2016,1,1),
			//			Amount = 300,
			//			Memo = string.Empty
			//		},

			//		new AccountInputItemViewModels()
			//		{
			//			AccountType = AccountTypes.Expense,
			//			Date = new DateTime(2016,1,2),
			//			Amount = 1600,
			//			Memo = string.Empty
			//		},

			//		new AccountInputItemViewModels()
			//		{
			//			AccountType = AccountTypes.Expense,
			//			Date = new DateTime(2016,1,3),
			//			Amount = 800,
			//			Memo = string.Empty
			//		}


			//	}
			//};

			
			return PartialView();
        }



    }
}