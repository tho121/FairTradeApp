using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FairTradeApp.ViewModels
{
	public class ProductViewModel : BaseViewModel
	{
		private Database.RowData productData;

		public ProductViewModel()
		{
			Product = "Banana";
			Title = "Fair Trade App!!";
			Country = "Panama";
			Image = "banana.png";
			Premium = "Premium: 15 %";
			Amount = 0;

			ConvertCommand = new Command(async () =>
			{
				var calc_page = new Views.PremiumCalcPage();

				var rate = 1.0f;
				if (productData.currencyPerUnit < 0)
				{
					rate = productData.premium;
				}
				else
				{
					rate = productData.currencyPerUnit * productData.premium;
				}

				(calc_page.BindingContext as PremiumCalcViewModel).SetData(Amount, rate);
				await Shell.Current.Navigation.PushModalAsync(calc_page);
				
			});
		}

		public void SetData(Database.RowData data)
		{
			productData = data;

			Country = data.country;
			Product = data.type;

			//TODO: set images here!

			if (data.currencyPerUnit < 0)
				Premium = data.premium.ToString() + " %";
			else
				Premium = (data.currencyPerUnit * data.premium).ToString() + " CAD/Kg";
		}

		public ICommand ConvertCommand { get; }

		string product = string.Empty;
		public string Product
		{
			get { return product; }
			set { SetProperty(ref product, value); }
		}

		//var vm = (BindingContext as ViewModels.ProductViewModel);

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

		int amount = 0;
		public int Amount
		{
			get { return amount; }
			set { SetProperty(ref amount, value); }
		}

	}
}