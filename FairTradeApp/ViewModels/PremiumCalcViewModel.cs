using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FairTradeApp.ViewModels
{
	public class PremiumCalcViewModel : BaseViewModel
	{
		public PremiumCalcViewModel()
		{
		}

		public void SetData(int amount, float rate)
		{
			Premium = rate;
			Premium_res = amount * rate;
			Database.Instance().AddPremiumAmountPaid(premium_res);
			Level = "Level: " + Convert.ToInt32(Database.Instance().GetPremiumAmountPaid() / Database.Instance().GetLevelInterval()).ToString();
		}

		float premium;
		public float Premium
		{
			get { return premium; }
			set { SetProperty(ref premium, value); }
		}

		float premium_res;
		public float Premium_res
		{
			get { return premium_res; }
			set { SetProperty(ref premium_res, value); }
		}

		string level;
		public string Level
		{
			get { return level; }
			set { SetProperty(ref level, value); }
		}
	}
}