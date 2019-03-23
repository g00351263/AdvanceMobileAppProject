using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}

        async protected override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;
            image.Opacity = 0.3;
            await image.FadeTo(1, 4000);

        }
    }
}