namespace AccountBook
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class AccountBookEntity : DbContext
	{
		public AccountBookEntity()
			: base("name=AccountBookContext")
		{
		}

		public virtual DbSet<AccountBookData> AccountBook { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
