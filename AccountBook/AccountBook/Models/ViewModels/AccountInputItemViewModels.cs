﻿using System;
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


	/// <summary>
	/// 帳單類別
	/// </summary>
	public enum AccountTypes
	{
		
		/// <summary>
		/// 收入
		/// </summary>
		Income,

		/// <summary>
		/// 支出
		/// </summary>
		Expense
	}


	public class AccountTypeConverter
	{
		public static string ToString(AccountTypes accountType)
		{
			return accountType == AccountTypes.Expense ? "支出" : "收入";
		}
	}

}