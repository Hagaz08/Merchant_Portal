using Merchant_Portal.Models.Enums;

namespace Merchant_Portal.Models
{
	public class Card:BaseEntity
	{
		public string cardName { get; set; } = string.Empty;
		public string cardNumber { get; set; } = string.Empty;
		public string cardType { get; set; } = CardType.physical.ToString();
		public DateTime expiryDate { get; set; }
		public double cardBalance { get; set; }
		public CardStatus cardstatus { get; set; } = CardStatus.Active;
		public CardScheme cardscheme { get; set; } = CardScheme.MasterCard;
		public string UserId { get; set; }

		//Navigation Property
		public AppUser appuser { get; set; }
		public ICollection<Transaction> transactions { get; set; } = new List<Transaction>();


    }
}
