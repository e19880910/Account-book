using AccountBook.Models.ConvertService;
using AccountBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models.DbService
{
	public class AccountBookDbService
	{
		AccountBookEntity _db;

		public AccountBookDbService()
		{
			_db = new AccountBookEntity();
		}

		public List<AccountInputItemViewModels> GetAll()
		{
			var query = _db.AccountBook.Select(s =>
			new AccountInputItemViewModels()
			{
				AccountType = (AccountTypes)s.Categoryyy,
				Amount = s.Amounttt,
				Date = s.Dateee,
				Memo = s.Remarkkk
			});
			
			return query.ToList() ;
		}

		

	}
}