namespace Merchant_Portal.Models.DTO
{
	public class ResponseObject<T>
	{
		public bool Success { get; set; }
		public List<string> Errors { get; set; }
		public T Data { get; set; }
	}
}
