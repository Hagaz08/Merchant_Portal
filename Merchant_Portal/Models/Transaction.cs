using Merchant_Portal.Models.Enums;
using System.Transactions;

namespace Merchant_Portal.Models
{
	public class Transaction:BaseEntity
	{
	   
		public double transAmount { get; set; }
		public string transReferenceNumber { get; set; } = string.Empty;
		public TransTypes transactionType { get; set; } = TransTypes.Income;
		public TransStatus transactionstatus { get; set; } = TransStatus.Failed;

		public string UserId { get; set; } = string.Empty;
		public string cardId { get; set; }= string.Empty;

		public string? Description { get; set; }=string.Empty;

		public Card card { get; set; }

		public AppUser AppUser { get; set; }




	}
}
