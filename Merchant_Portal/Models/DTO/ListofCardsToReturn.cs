using System.Security.Principal;

namespace Merchant_Portal.Models.DTO
{
	public class ListofCardsToReturn
	{
        public string  Name { get; set; }

        public decimal Balance { get; set; }
        public string cardNumber { get; set; }
        public string Accountnumber { get; set; }
        public string expiry { get; set; }


    }
}
