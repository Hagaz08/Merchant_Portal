namespace Merchant_Portal.Models
{
	public class BaseEntity
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime? createdAt { get; set; }= DateTime.Now;
		public DateTime? updatedAt { get; set; }=DateTime.Now;

		public DateTime? deletedAt { get; set; }
	}
}
