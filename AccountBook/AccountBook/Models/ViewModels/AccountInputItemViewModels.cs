using AccountBook.Models.ConvertService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountBook.Models.ViewModels
{
	public class AccountInputItemViewModels
	{

		[DisplayName("類別")]
		/// <summary>
		/// 帳單類別
		/// </summary>
		public AccountTypes AccountType { get; set; }


		[DisplayName("金額")]
		/// <summary>
		/// 帳單金額
		/// </summary>
		public decimal Amount { get; set; }

	
		[DisplayName("日期")]
		/// <summary>
		/// 帳單日期
		/// </summary>
		public DateTime Date { get; set; }


		[DisplayName("備註")]
		/// <summary>
		/// 帳單備註
		/// </summary>
		public string Memo { get; set; }
	}
	
}