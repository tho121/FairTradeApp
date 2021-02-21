using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FairTradeApp.Views
{
	public partial class ProductPage : ContentPage
	{
		public ProductPage()
		{
			InitializeComponent();
		}

		public void Init(Database.RowData data)
		{
			var vm = (BindingContext as ViewModels.ProductViewModel);
			vm.Country = data.country;
			vm.Product = data.type;
			if (data.currencyPerUnit < 0)
				vm.Premium = data.premium.ToString() + " %";
			else
				vm.Premium = (data.currencyPerUnit * data.premium).ToString() + " CAD/Kg";

			
			//if(data.type == "Cane sugar")
			//	vm.Image = "sugar.png";
			//else if (data.type == "Amaranth")
			//	vm.Image = "amaranth.png";
			//else if (data.type == "Rice")
			//	vm.Image = "rice.png";
			//else if (data.type == "Cocoa")
			//	vm.Image = "cocoa.png";
			//else if (data.type == "Seed cotton")
			//	vm.Image = "cotton.png";
			//else if (data.type == "Apple")
			//	vm.Image = "apple.png";
			//else if (data.type == "Avacado")
			//	vm.Image = "avacado.png";
			//else if (data.type == "Apple")
			//	vm.Image = "apple.png";
			//else if (data.type == "Banana" || data.type == "Baby Banana - coastal" || data.type == "Baby Banana - mountain")
			//	vm.Image = "banana.png";
			//else if (data.type == "Blueberry")
			//	vm.Image = "blueberry.png";
			//else if (data.type == "Cherry")
			//	vm.Image = "cherry.png";
			//else if (data.type == "Blueberry")
			//	vm.Image = "blueberry.png";
			//else if (data.type == "Grapefruit  (Citrus x paradis)")
			//	vm.Image = "grpefruit.png";
			//else if (data.type == "Lemon")
			//	vm.Image = "lemon.png";
			//else if (data.type == "Lime")
			//	vm.Image = "lime.png";
			//else if (data.type == "Mango")
			//	vm.Image = "mango.png";
			//else if (data.type == "Pineapple")
			//	vm.Image = "pineapple.png";
			//else if (data.type == "Table Grape" || data.type == "Wine grape")
			//	vm.Image = "grape.png";
			//else if (data.type == "Cashew nut" || data.type == "Cashew nut; raw")
			//	vm.Image = "cashew.png";
			//else if (data.type == "Camellia")
			//	vm.Image = "camellia.png";
			//else if (data.type == "Acai")
			//	vm.Image = "acai.png";

		}
	
	}
}