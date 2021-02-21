using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FairTradeApp.ViewModels
{
	public class Premium_calc : BaseViewModel
	{
		int weight;
		public Premium_calc()
		{
			Weight = 0;

			TextChange = new Command(() =>
				{
					//do calculation
					
				}
			);
		}

		
		public int Weight
		{
			get { return weight; }
			set { SetProperty(ref weight, value); }
		}

		int premium_res;
		public int Premium_res
		{
			get { return premium_res; }
			set { SetProperty(ref premium_res, value); }
		}

		//public void TextChange(object sender, TextChangedEventArgs e)
		//{
		//	this.textChangedLabel.Text = $"Text changed from {e.OldTextValue} to {e.NewTextValue}";
		//}

		public ICommand TextChange { get; }
	}
}