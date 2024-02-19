using Merchant_Portal.Models;
using Merchant_Portal.Models.DTO;
using Merchant_Portal.Services.Interface;
using Merchant_Portal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Merchant_Portal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : BaseControlller
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;
		private readonly IHashingService _HashingService;
		public AuthController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IHashingService HashingService)
		{
			_signInManager = signInManager;
			_userManager = userManager;
			_HashingService = HashingService;

		}
		[HttpPost("Login")]
		public async Task<IActionResult> Login([FromBody] LoginDto model)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(model.Email);
				if (user == null)
				{
					return BadRequest(setResponseObject(false, "", new List<string> { "Invalid Credentials" }));
				}
				if(! await _userManager.IsEmailConfirmedAsync(user))
				{
					return BadRequest(setResponseObject(false, "", new List<string> { "Email not yet Confirmed" }));
				}

				var loginResult = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);
				if (loginResult.Succeeded)
				{
					var userRoles= await _userManager.GetRolesAsync(user);
					return Ok(setResponseObject(true, _HashingService.GenerateJWT(user, userRoles.ToList()), new List<string> { }));
				}

			}
			return BadRequest(setResponseObject(false, "", new List<string> { "Invalid Credentials" }));
		}
	}
}
