using Ideas.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideas.ViewModels
{
	public class LoginViewModel
	{

		private ApiServices _apiServices = new ApiServices();
		public string UserName { get; set; }

		public string Password { get; set; }

		public ICommand LoginCommand
		{
			get
			{
				return new Command(async() =>
				{
					await _apiServices.LoginAsync(UserName, Password);
				});
			}
		}
	}
}
