using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;



namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Destination : ContentPage
    {
        public Destination()
        {
            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(59.914561, 10.442108), Distance.FromKilometers(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var pin = new Pin()
            {
                Position = new Position(59.914561, 10.442108),
                Label = "Your destination"
            };
            map.Pins.Add(pin);
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

        }
    }
}