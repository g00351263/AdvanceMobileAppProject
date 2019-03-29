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

        }

        private void Gotto_Clock(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void Gotto_Weather(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }

        private void Pop_page(object sender, EventArgs e)
        {
            Navigation.PopAsync(); // will pop current page
        }

        private void Animation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }

        private void WeatherPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}