﻿using System;
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
			vm.Premium = (data.premium.ToString());
		}
	
	}
}