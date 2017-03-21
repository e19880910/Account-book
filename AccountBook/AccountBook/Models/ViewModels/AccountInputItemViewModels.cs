using AccountBook.Models.ConvertService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountBook.Models.ViewModels
{
	public class AccountInputItemViewModels
	{
		
		[Required]
		[Display(Name ="類別")]
		public AccountTypes AccountType { get; set; }

		
		
		[DataType(DataType.Currency)]
		[Required(ErrorMessage ="必須輸入金額")]
		[Display(Name ="金額")]
		public decimal Amount { get; set; }


	
		
		[Required(ErrorMessage = "必須輸入日期")]
		[Display(Name="日期")]
		public DateTime Date { get; set; }


		[MaxLength(1000)]
		[Required(ErrorMessage ="必須輸入備註")]
		[Display(Name="備註")]
		public string Memo { get; set; }
	}
	
}