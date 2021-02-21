using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FairTradeApp.ViewModels
{
	public class ProductViewModel : BaseViewModel
	{
		public ProductViewModel()
		{
			Product = "Banana";
			Title = "Fair Trade App!!";
			Country = "Panama";
			Image = "banana.png";
			Premium = "Premium: 15 %";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
		}

		public ICommand OpenWebCommand { get; }

		string product = string.Empty;
		public string Product
		{
			get { return product; }
			set { SetProperty(ref product, value); }
		}

		string country = string.Empty;
		public string Country
		{
			get { return country; }
			set { SetProperty(ref country, value); }
		}

		string premium = string.Empty;
		public string Premium
		{
			get { return premium; }
			set { SetProperty(ref premium, value); }
		}

		string image = string.Empty;
		public string Image
		{
			get { return image; }
			set { SetProperty(ref image, value); }
		}

	}
}