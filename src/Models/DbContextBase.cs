using Microsoft.EntityFrameworkCore;

namespace CryptocurrenciesViewer.Models
{
	public class DbContextBase : DbContext
	{
		public DbSet<CryptoCurrency> Currencies { get; set; }

		protected override void OnModelCreating(ModelBuilder bulider)
		{
			bulider.Entity<CryptoCurrency>().HasKey(cc => cc.ID);
		}
	}
}