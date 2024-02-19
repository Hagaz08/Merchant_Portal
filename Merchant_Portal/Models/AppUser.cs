using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.Xml;

namespace Merchant_Portal.Models
{
	public class AppUser:IdentityUser
	{
		public string Name { get; set; } = string.Empty;
		public double AccountBalance { get; set; }
		public string AccountNumber { get; set; } = string.Empty;
        public string TerminalId { get; set; }= Guid.NewGuid().ToString();
		public DateTime createdOn { get; set; }= DateTime.Now;
		public DateTime updatedOn { get; set; } = DateTime.Now;

		//Navigation Property
		ICollection<Card> cards { get; set; }=new List<Card>();
		ICollection<Transaction> transactions { get; set; }	= new List<Transaction>();
       

    }
}
