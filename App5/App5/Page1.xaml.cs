using App5.Models;
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
using Xamarin.Forms.Xaml;
using System.Net;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    { 

        public Page1()
        {
            InitializeComponent();
        
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });

        }

        private void BackToMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

                 
    }
}