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
        void SetIsEnabledButtonState(bool startButtonState, bool cancelButtonState)
        {
            startButton.IsEnabled = startButtonState;
            cancelButton.IsEnabled = cancelButtonState;
        }

        async void OnStartAnimationButtonClicked(object sender, EventArgs e)
        {
            SetIsEnabledButtonState(false, true);

            image.Opacity =0.3;
            await image.FadeTo(1, 4000);

            SetIsEnabledButtonState(true, false);
        }

        void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            ViewExtensions.CancelAnimations(image);
            SetIsEnabledButtonState(true, false);
        }

    }
}