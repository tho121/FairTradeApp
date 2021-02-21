using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using ZXing;

namespace FairTradeApp.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "Fair Trade App!!";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

			ProductCategories = Database.Instance().GetAllProductCategories();
			ProductTypes = Database.Instance().GetAllProductTypes();

			//OnSelectedChange = new Command( ()=> {

			//	var datas = Database.Instance().GetRowDatas(selectedCategory, null, null, null);

			//	List<string> types = new List<string>();
			//	foreach(var data in datas)
			//	{
			//		types.Add(data.type);
			//	}

			//	ProductTypes = types;

			//	});

		}

		//categories
		List<string> productCategories = new List<string>();
		public List<string> ProductCategories
		{
			get { return productCategories; }
			set { SetProperty(ref productCategories, value); }
		}

		string selectedCategory = null;
		public string SelectedCategory
		{
			get { return selectedCategory; }
			set { SetProperty(ref selectedCategory, value); }
		}

		//types
		List<string> productTypes = new List<string>();
		public List<string> ProductTypes
		{
			get { return productTypes; }
			set { SetProperty(ref productTypes, value); }
		}

		string selectedType = null;
		public string SelectedType
		{
			get { return selectedType; }
			set { SetProperty(ref selectedType, value); }
		}

		public ICommand OpenWebCommand { get; }
		//public ICommand OnSelectedChange { get; }
	}

}