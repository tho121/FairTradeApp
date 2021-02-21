using System;
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
		}

		public ICommand OpenWebCommand { get; }
	}

}