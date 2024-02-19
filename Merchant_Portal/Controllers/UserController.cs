using AutoMapper;
using Merchant_Portal.Data;
using Merchant_Portal.Data.Repositories;
using Merchant_Portal.Models;
using Merchant_Portal.Models.DTO;
using Merchant_Portal.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;

namespace Merchant_Portal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize(AuthenticationSchemes="Bearer")]
	public class UserController : BaseControlller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IMapper _mapper;
		private readonly ApplicationDbContext _ctx;
		private readonly IRepository _repository;

		public UserController(UserManager<AppUser> userManager, IMapper mapper, ApplicationDbContext ctx, IRepository repository)
		{
			_userManager = userManager;
			_mapper = mapper;
			_ctx = ctx;
			_repository = repository;
		}
		[HttpPost("create-user")]
		public async Task<IActionResult> Post([FromBody] userToAddDto model)
		{
			var listofErrs= new List<string>();
			if(ModelState.IsValid)
			{
				var userExist = await _userManager.FindByEmailAsync(model.Email);
				if(userExist != null)
				{
					return BadRequest(setResponseObject<string>(false, "", new List<string> { "Email already exist" }));
				}
				var mappedUser= _mapper.Map<AppUser>(model);
				mappedUser.EmailConfirmed = true;
				mappedUser.AccountBalance = 0;
				var addUserResult= await _userManager.CreateAsync(mappedUser,model.Password);
				if (!addUserResult.Succeeded)
				{
					foreach (var err in addUserResult.Errors)
					{
						listofErrs.Add(err.Description);
					}

				}
				else
				{
					await _userManager.AddToRoleAsync(mappedUser, "admin");
					return Ok(setResponseObject(true, mappedUser.Id, new List<string> { }));
				}
			}
			return Ok(setResponseObject(false,"",listofErrs));
		}
		
		[HttpGet("dashboard")]
		public async Task<IActionResult> Get()
		{
			var user = await _userManager.GetUserAsync(User);
			if (user != null)
			{
				var allCards = await _repository.GetAsync<Card>();
				if(allCards != null)
				{
					var activeCards = allCards.Where(x => x.cardstatus == CardStatus.Active);
					var inactiveCards = allCards.Where(x => x.cardstatus == CardStatus.Inactive);
					var expiredCards = allCards.Where(x => x.cardstatus == CardStatus.Expired);

					var result = new DashboardToReturn
					{
						AccountBalance = (decimal)user.AccountBalance,
						Activecards = activeCards.Count(),
						Inactivecards = inactiveCards.Count(),
						Expiredcards = expiredCards.Count(),
						Totalcards = allCards.Count()

					};
					return Ok(result);
				}
				return BadRequest("No Card to Show");
				
			}
			return BadRequest("User not Found");


		}
		[HttpGet("List-of-Cards")]
		public async Task<IActionResult> GetListOfCards()
		{
			var user = await _userManager.GetUserAsync(User);
			if (user != null)
			{
				
				var allCards = await _repository.GetAsync<Card>();
				var result = new List<ListofCardsToReturn>();
				foreach(var card in allCards) 
				{


					var OneCard = new ListofCardsToReturn
					{
						Name = card.cardName,
						Accountnumber = user.AccountNumber,
						Balance = (decimal)card.cardBalance,
						cardNumber = card.cardNumber,
						expiry = card.expiryDate.ToString("yyyy/MM/dd"),
					};
					result.Add(OneCard);
				}

				
				return Ok(result);
			}
			return BadRequest("User not Found");


		}
	}
}

