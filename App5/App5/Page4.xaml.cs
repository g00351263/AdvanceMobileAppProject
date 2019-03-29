using App5.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
        public string api = "https://newsapi.org/v2/top-headlines?sources=the-irish-times&apiKey=2a75bd92c42a4a7a922d6bf591e75b0d";
        public Page4 ()
		{
			InitializeComponent ();
            string json = new WebClient().DownloadString(api);
            //view.Text = json.ToString();

            GetNews machine = JsonConvert.DeserializeObject<GetNews>(json);
            //view.Text = machine.articles[2].Title.ToString();

            foreach (var data in machine.articles)
            {
               view.Text = data.Title;
            }

        
        }
        }
}