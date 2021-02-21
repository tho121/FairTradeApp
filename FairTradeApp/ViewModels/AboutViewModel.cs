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
		private List<Database.RowData> currentQuery = new List<Database.RowData>();
		public AboutViewModel()
		{
			Title = "Fair Trade App!!";
			OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

			ProductCategories = Database.Instance().GetAllProductCategories();
			ProductTypes = Database.Instance().GetAllProductTypes();
			ProductForms = Database.Instance().GetAllProductForms();
			ProductCountries = Database.Instance().GetAllProductCountries();

			IsProductCountryEnabled = false;
			IsProductFormEnabled = false;
			IsProductTypeEnabled = false;
		}

		public void UpdateOptions()
		{
			currentQuery = Database.Instance().GetRowDatas(selectedCategory, selectedType, selectedForm, selectedCountry);
			var newLists = Database.Instance().GetSelectionsFromRowDatas(currentQuery);

			IsProductCountryEnabled = false;
			IsProductFormEnabled = false;
			IsProductTypeEnabled = false;

			if (String.IsNullOrEmpty(selectedCategory))
			{
				ProductCategories = newLists[0];
			}
			else
			{
				IsProductTypeEnabled = true;
			}

			if (String.IsNullOrEmpty(selectedType))
			{
				ProductTypes = newLists[1];
			}
			else
			{
				IsProductFormEnabled = true;
			}

			if (String.IsNullOrEmpty(selectedForm))
			{
				ProductForms = newLists[2];
			}
			else
			{
				IsProductCountryEnabled = true;
			}

			if (String.IsNullOrEmpty(selectedCountry))
			{
				ProductCountries = newLists[3];
			}
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
			set {
				ProductTypes.Clear();
				selectedType = "";

				ProductForms.Clear();
				selectedForm = "";

				ProductCountries.Clear();
				selectedCountry = "";
				SetProperty(ref selectedCategory, value);

				UpdateOptions();
			}
		}

		//types

		bool isProductTypeEnabled = false;
		public bool IsProductTypeEnabled
		{
			get { return isProductTypeEnabled; }
			set { SetProperty(ref isProductTypeEnabled, value); }
		}

		List<string> productTypes = new List<string>();
		public List<string> ProductTypes
		{
			get { return productTypes; }
			set {
				SetProperty(ref productTypes, value); 
			}
		}

		string selectedType = null;
		public string SelectedType
		{
			get { return selectedType; }
			set {

				ProductForms.Clear();
				selectedForm = "";

				ProductCountries.Clear();
				selectedCountry = "";

				SetProperty(ref selectedType, value);

				UpdateOptions();
			}
		}

		//forms

		bool isProductFormEnabled = false;
		public bool IsProductFormEnabled
		{
			get { return isProductFormEnabled; }
			set { SetProperty(ref isProductFormEnabled, value); }
		}

		List<string> productForms = new List<string>();
		public List<string> ProductForms
		{
			get { return productForms; }
			set { SetProperty(ref productForms, value); }
		}

		string selectedForm = null;
		public string SelectedForm
		{
			get { return selectedForm; }
			set {

				ProductCountries.Clear();
				selectedCountry = "";

				SetProperty(ref selectedForm, value);

				UpdateOptions();
			}
		}

		//countries

		bool isProductCountryEnabled = false;
		public bool IsProductCountryEnabled
		{
			get { return isProductCountryEnabled; }
			set { SetProperty(ref isProductCountryEnabled, value); }
		}

		List<string> productCountries = new List<string>();
		public List<string> ProductCountries
		{
			get { return productCountries; }
			set { SetProperty(ref productCountries, value); }
		}

		string selectedCountry = null;
		public string SelectedCountry
		{
			get { return selectedCountry; }
			set {

				SetProperty(ref selectedCountry, value);
				UpdateOptions();

				//TODO: currentQuery[0] is the data you want!
				//Navigate.Push(new Page(currentQuery[0])) or something here
			}
		}

		public ICommand OpenWebCommand { get; }
		//public ICommand OnSelectedChange { get; }
	}

}