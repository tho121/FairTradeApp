using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FairTradeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PremiumCalcPage : ContentPage
    {
        public PremiumCalcPage()
        {
            InitializeComponent();
        }

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var levelInterval = Database.Instance().GetLevelInterval();
			var value = (Database.Instance().GetPremiumAmountPaid() % levelInterval) / levelInterval;

			PremiumProgress.ProgressTo(value, 1000, Easing.Linear);
		}
	}
}