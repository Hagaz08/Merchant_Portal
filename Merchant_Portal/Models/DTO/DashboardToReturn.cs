namespace Merchant_Portal.Models.DTO
{
	public class DashboardToReturn
	{
		public decimal AccountBalance { get; set; }
		public int Totalcards { get; set; }
		public int Activecards { get; set; }
		public int Inactivecards { get; set; }

		public int Expiredcards { get; set; }
	}
}
