using Ideas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ideas
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class MainPage : ContentPage
	{
       // public IList<MoreData> MoreDatas { get; private set; }
		public List<MoreData> MoreData { get; }

		public MainPage()
		{
			InitializeComponent();
            MoreData = new List<MoreData>();
            MoreData.Add(new MoreData
            {
                Name = "Environment",
                Location = "Africa & Asia",
             
            });

            MoreData.Add(new MoreData
            {
                Name = "Safety Management",
                Location = "Nigeria",
              
            });

            MoreData.Add(new MoreData
            {
                Name = "Bespoke Software",
                Location = "Borneo",
               
            });

            MoreData.Add(new MoreData
            {
                Name = "Documents & Forms",
                Location = "Vietnam",
               
            });

            MoreData.Add(new MoreData
            {
                Name = "Risk Assessment",
                Location = "Nigeria",
               
            });

            MoreData.Add(new MoreData
            {
                Name = "Rest Hour",
                Location = "UK",
               
            });

            MoreData.Add(new MoreData
            {
                Name = "Marine Accounting ",
                Location = "Vietnam",
           
            });

            MoreData.Add(new MoreData
            {
                Name = "Crew",
                Location = "Indonesia",
              
            });

            MoreData.Add(new MoreData
            {
                Name = "Procurement",
                Location = "Indonesia",
              
            });

            MoreData.Add(new MoreData
            {
                Name = "PMS",
                Location = "Greece",
               
            });

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MoreData selectedItem = e.SelectedItem as MoreData;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            MoreData tappedItem = e.Item as MoreData;
        }
    }
}











