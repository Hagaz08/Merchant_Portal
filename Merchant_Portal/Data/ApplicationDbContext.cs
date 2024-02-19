using Merchant_Portal.Models;
using Merchant_Portal.Models.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Merchant_Portal.Data
{
	public class ApplicationDbContext:IdentityDbContext<AppUser>
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<IdentityRole>().HasData(
			   new IdentityRole { Id = "1", Name = "admin", NormalizedName = "ADMIN" },
			new IdentityRole { Id = "2", Name = "regular", NormalizedName = "REGULAR" }
				);

			
			modelBuilder.Entity<Card>().HasData(
			   new Card
			   {
				   Id = "1",
				   UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
				   cardName = "Nosa Bless",
				   cardNumber = "77048390",
				   cardType = CardType.physical.ToString(),
				   expiryDate = DateTime.Now.AddYears(4),
				   cardBalance = 128.45,
				   cardstatus = CardStatus.Active,
				   cardscheme = CardScheme.Verve,
			   },
			   new Card
			   {
				   Id = "2",
				   UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
				   cardName = "Eti Bless",
				   cardNumber = "77048380",
				   cardType = CardType.Virtual.ToString(),
				   expiryDate = DateTime.Now,
				   cardBalance = 456.45,
				   cardstatus = CardStatus.Inactive,
				   cardscheme = CardScheme.MasterCard,
			   },
			   new Card
			   {
				   Id = "3",
				   UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
				   cardName = "Chike Bless",
				   cardNumber = "77048370",
				   cardType = CardType.physical.ToString(),
				   expiryDate = DateTime.Now.AddMonths(-4),
				   cardBalance = 128.45,
				   cardstatus = CardStatus.Expired,
				   cardscheme = CardScheme.Visa,
			   },
			   new Card
			   {
				   Id = "4",
				   UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
				   cardName = "Nosa Bless",
				   cardNumber = "77048360",
				   cardType = CardType.physical.ToString(),
				   expiryDate = DateTime.Now.AddYears(4),
				   cardBalance = 128.45,
				   cardstatus = CardStatus.Active,
				   cardscheme = CardScheme.Verve,
			   }
			   );
			modelBuilder.Entity<Transaction>().HasData(
			   new Transaction
			   {
				   transAmount = 5000.00,
				   transReferenceNumber = "Ref323112",
				   transactionType = TransTypes.Income,
				   transactionstatus = TransStatus.Approved,
				   Description = "My_Funding",
				   UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
				   cardId = "1",

			   },

				new Transaction
				{
					transAmount = 3500.56,
					transReferenceNumber = "Ref323113",
					transactionType = TransTypes.Outcome,
					transactionstatus = TransStatus.Failed,
					Description = "My_Withdrawal",
					UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
					cardId = "1",

				},
				new Transaction
				{
					transAmount = 1500.87,
					transReferenceNumber = "Ref323114",
					transactionType = TransTypes.Income,
					transactionstatus = TransStatus.Approved,
					Description = "My_Funding",
					UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
					cardId = "1",

				},
				new Transaction
				{
					transAmount = 3500.45,
					transReferenceNumber = "Ref323115",
					transactionType = TransTypes.Outcome,
					transactionstatus = TransStatus.Approved,
					Description = "My_Withdrawal",
					UserId = "4c4231f9-ccf8-47c1-9ce3-2da365fa19d7",
					cardId = "2",

				}
			   );
		}   
		public DbSet<Card> Cards { get; set; }	
		public DbSet<Transaction> Transactions { get; set; }	
	}
}
