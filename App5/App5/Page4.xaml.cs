
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static App5.Model.Article;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
        public Page4 ()
		{
            
            InitializeComponent ();
            GetJSON();
   
        }
        public async void GetJSON() // getting the api connected and object of json converted
        {
            var client = new System.Net.Http.HttpClient();
            var response = await client.GetAsync("https://newsapi.org/v2/top-headlines?sources=the-irish-times&apiKey=2a75bd92c42a4a7a922d6bf591e75b0d");
            string contactsJson = await response.Content.ReadAsStringAsync();
            ArticlesResult ObjContactList = new ArticlesResult();
            if (contactsJson != "")
            {
                //Converting JSON Array Objects into generic list  
                ObjContactList = JsonConvert.DeserializeObject<ArticlesResult>(contactsJson);
            }
            listviewConacts.ItemsSource = ObjContactList.Articles;
        }

        private void BackToMainPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage()); // bringin to main page once clicked

        }
    }
}