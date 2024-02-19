using AutoMapper;
using Merchant_Portal.Models;
using Merchant_Portal.Models.DTO;

namespace Merchant_Portal.Settings
{
	public class AutoMapperProfile:Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<userToAddDto,AppUser>()
				.ForMember(u=>u.UserName,src=>src.MapFrom(x=>x.Email))
				.ReverseMap();
		}
	}
}
