using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AlertPage : ContentPage
	{
		public AlertPage ()
		{
			InitializeComponent ();
		}
        async void OnAlertSimpleClicked (object sender, EventArgs e)
        {
            var res = await DisplayAlert("Alert", "Radius :   OnSliderValueChanged" , "OK", "Cancel");
            if (res == true)
            {
                await Navigation.PushAsync(new Selection());
            }
            else
            {
                return;

            }
        }
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }
    }
}