using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace App5
{
    public partial class MainPage : ContentPage
    {

        public MainPage()

        {
            InitializeComponent();


            // Clock displayed on main page entry under the buttons //
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                dateLabel.Text = DateTime.Now.ToString("D");
                return true;
            });

            
        }


        // button to go weather app//
        private void Gotto_Weather(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        // button to go camera page
        private void Animation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        //button to go news page //
        private void WeatherPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }


        // button to go contact book page //
        private void ContactPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactListPage());
        }
    }
}