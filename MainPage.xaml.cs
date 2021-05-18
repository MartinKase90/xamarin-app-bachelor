using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace App3
{
    public partial class MainPage : ContentPage
    {

        //private const string Url = "http://192.168.1.20:8000/filter/beef/1/1/1/59.914561/10.442108/0/Moss";
        public string url = "";
        public string MeatContents = "";
        public string PoultryContents = "";
        public string VeganContents;
        public string SeaFoodContents = "";
        public MainPage()
        {
            InitializeComponent();


        }
        async void OnButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Selection());

        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            var sliderRadius = args.NewValue.ToString("F3");

        }
        void OnMeatPickerSelectedIndexChanged(Object sender, EventArgs e)
        {
            //public string MeatContents = "";
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {


                //meatOutLabel.Text = (string)picker.ItemsSource[selectedIndex];
                MeatContents = (string)picker.ItemsSource[selectedIndex];
            }
        }
        void OnPoultryPickerSelectedIndexChanged(Object sender, EventArgs e)
        {

            var picker = (Picker)sender;
            //public string PoultryContents = "";
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {

                //poultryOutLabel.Text = (string)picker.ItemsSource[selectedIndex];
                PoultryContents = (string)picker.ItemsSource[selectedIndex];
            }
        }
        void OnSeafoodPickerSelectedIndexChanged(Object sender, EventArgs e)
        {
            //public string SeaFoodContents = "";
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {

                //seaFoodOutLabel.Text = (string)picker.ItemsSource[selectedIndex];
                SeaFoodContents = (string)picker.ItemsSource[selectedIndex];
            }
        }
        void OnVeganPickerSelectedIndexChanged(Object sender, EventArgs e)
        {
            //public string VeganContents;
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {

                //veganOutLabel.Text = (string)picker.ItemsSource[selectedIndex];
                VeganContents = (string)picker.ItemsSource[selectedIndex];
                //veganOutLabel.Text = VeganContents;
            }
        }
        void FoodOut()
        {
            //url = $"/{MeatContents}/{PoultryContents}/{SeaFoodContents}/{VeganContents}";
            //meatOutLabel.Text = url;
        }


    }//https://joshzeigler.com/technology/web-development/how-big-is-too-big-for-json
     //https://pypi.org/project/geopy/
     //http://json2csharp.com/
     //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/custom-renderer/map/customized-pin
     //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/listview/interactivity
}