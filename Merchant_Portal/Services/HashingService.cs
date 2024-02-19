using Merchant_Portal.Models;
using Merchant_Portal.Services.Interface;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Merchant_Portal.Services
{
	public class HashingService:IHashingService
	{
		private readonly IConfiguration _config;
		public HashingService(IConfiguration config)
		{
			_config = config;
		}

		public string GenerateJWT(AppUser user, List<string> roles)
		{
			var claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id));
			claims.Add(new Claim(ClaimTypes.Name, user.UserName));
			claims.Add(new Claim(ClaimTypes.Email, user.Email));
			roles.ForEach(x => claims.Add(new Claim(ClaimTypes.Role, x)));

			var key = Encoding.UTF8.GetBytes(_config.GetSection("JWTSettings:Key").Value);
			var lifespan= Convert.ToInt32(_config.GetSection("JWTSettings:LifeSpan").Value);

			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var signInCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
			var securityToken = new JwtSecurityToken(
				claims: claims,
				expires: DateTime.UtcNow.AddDays(lifespan),
				signingCredentials: signInCredentials
				);

			var token = jwtSecurityTokenHandler.WriteToken(securityToken);
			return token;

		}
	}
}
