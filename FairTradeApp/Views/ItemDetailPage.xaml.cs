using FairTradeApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FairTradeApp.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}