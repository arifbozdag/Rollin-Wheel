using Rollin_Wheel.MasterSayfalar;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Rollin_Wheel.Views
{
    public class MyMasterPage : MasterDetailPage
    {
        public MyMasterPage()
        {
            Master = new MyMenu();
            Detail = new MyCarouselPage();

        }
    }
}
