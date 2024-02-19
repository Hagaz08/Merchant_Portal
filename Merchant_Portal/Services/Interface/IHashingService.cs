using Merchant_Portal.Models;

namespace Merchant_Portal.Services.Interface
{
	public interface IHashingService
	{
		public string GenerateJWT(AppUser user, List<String> roles);
	}
}
