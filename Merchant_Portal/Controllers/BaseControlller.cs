using Merchant_Portal.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Merchant_Portal.Controllers
{
	public class BaseControlller:ControllerBase
	{
		protected ResponseObject<T> setResponseObject<T>(bool success, T data, List<string> errors)
		{
			var errorObject= new ResponseObject<T>
			{
				Success = success,
				Data = data,
				Errors = errors
			};
			return errorObject;
		}

	}
}
