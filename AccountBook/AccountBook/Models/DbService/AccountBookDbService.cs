using AccountBook.Models.ConvertService;
using AccountBook.Models.ViewModels;
using ServiceLab.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountBook.Models.DbService
{
	public class AccountBookDbService
	{
		AccountBookEntity _db;
		IUnitOfWork _unitOfWork;


		public AccountBookDbService(IUnitOfWork unitOfWork)
		{
			_db = new AccountBookEntity();
			_unitOfWork = unitOfWork;
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

			return query.ToList();
		}

		public void AddItem(AccountInputItemViewModels item)
		{
			AccountBookData data = new AccountBookData();
			data.Amounttt = Convert.ToInt32(item.Amount);
			data.Categoryyy = (int)item.AccountType;
			data.Dateee = item.Date;
			data.Remarkkk = item.Memo;
			data.Id = Guid.NewGuid();

			_db.AccountBook.Add(data);
			_db.SaveChanges();
		}


		public void Save()
		{
			_unitOfWork.Save();
		}

	}
}