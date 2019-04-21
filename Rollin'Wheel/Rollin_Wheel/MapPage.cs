using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Rollin_Wheel
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            var map = new Map(
                MapSpan.FromCenterAndRadius(
                        new Position(39.8711568, 32.7432087), Distance.FromMiles(0.4)))
            {
                IsShowingUser = true,
                HeightRequest = 300,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.Start
            };
            var stack = new StackLayout { Spacing = 0 };

            var rangedata = new Label
            {
                Text = "152.651 metres",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var battery = new Image
            {
                Source = "battery.jpg",
            };
            /*
            var slider = new Slider
            {
                Maximum = 360,
            };*/

            stack.Children.Add(map);
            stack.Children.Add(rangedata);
            stack.Children.Add(battery);
            //stack.Children.Add(slider);

            Content = stack;
        }
    }
}