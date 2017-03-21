using System.ComponentModel.DataAnnotations;

namespace AccountBook.Models.ConvertService
{
	public class AccountTypeConverter
	{
		public static string ToString(AccountTypes accountType)
		{
			return accountType == AccountTypes.Expense ? "支出" : "收入";
		}
	}

	/// <summary>
	/// 帳單類別
	/// </summary>
	public enum AccountTypes
	{
		[Display(Name = "收入")]
		/// <summary>
		/// 收入
		/// </summary>
		Income,

		[Display(Name ="支出")]
		/// <summary>
		/// 支出
		/// </summary>
		Expense
	}


}