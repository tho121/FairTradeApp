﻿using FairTradeApp.Services;
using FairTradeApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FairTradeApp
{
	public partial class App : Application
	{


		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
			var data = Database.Instance().GetRowData(0);
			Console.WriteLine(data[0]);
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}