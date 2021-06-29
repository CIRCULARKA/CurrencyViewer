using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CryptocurrenciesViewer.Models
{
	public class UsersDbContext : IdentityDbContext<User>
	{
		public UsersDbContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseSqlServer("Server=(local);Database=CryptoUsers;Trusted_Connection=True");
		}
	}
}
