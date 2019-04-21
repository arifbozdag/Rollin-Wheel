using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Rollin_Wheel.Views
{
    public class MyCarouselPage : CarouselPage
    {
        public MyCarouselPage()
        {
            Children.Add(new MyContentPage());

            Children.Add(new MapPage());

        }
    }
}
