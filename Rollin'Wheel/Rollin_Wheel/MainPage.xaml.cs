using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rollin_Wheel
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Views.MyMasterPage());
            };

            Content = button;
        }
    }
}
