using Ideas.Models;
using Ideas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ideas.ViewModels
{
	public class IdeasViewModel : INotifyPropertyChanged
	{

		ApiServices _apiServices = new ApiServices();
		private List<Idea> ideas;

		public string AccessToken { get; set; }

		public List<Idea> Ideas 
		{
			get => ideas;
			set
			{
				ideas = value;
				onPropertyChanged();
			} 
		}

		public ICommand GetIdeas
		{
			get
			{
				return new Command(async () =>
				{
					Ideas = await _apiServices.GetIdeasAsync(AccessToken);
				});
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void onPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
