using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ComponentModel;

namespace App3
{

    public partial class MyService
    {
        public static List<MyService> FromJson(string json) => JsonConvert.DeserializeObject<List<MyService>>(json, App3.Converter.Settings);
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Selection : ContentPage
    {
        //public event PropertyChangedEventHandler PropertyChanged;

        //public List<RootObject> Items { get; set; }


        public Selection()
        {
            InitializeComponent();

            //listView.ItemsSource = Data.ProductList;
            //listView.ItemSource = ObjRestaurantList.RootObjects;
            GetJson();
            
        }
        async void OnButtonClickedPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Destination());
        }

        void ListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //((ListView)sender).SelectedItem = DetailInfo;
            if (e.SelectedItem == null)
            {
                return;
            }
            else
            {
                var item = (MyService)e.SelectedItem;
                //DetailPriceLabel.Text = item.PriceSegment;
                //DetailedPicture.Source = item.Picture;
            }
            //((ListView)sender).SelectedItem = null;
            


        }
        
        public async void GetJson()
        {
            if (NetworkCheck.IsInternet())
            {
                //var client = new System.Net.Http.HttpClient();
               
                // response.EnsureSuccessStatusCode();
                try
                {
                    HttpClient client = new HttpClient();
                    HttpResponseMessage response = await client.GetAsync("http://foodster.world:2125/filter/beef/0/0/0/59.367904/10.442919/0/Horten/NO");
                    var responseBody = await response.Content.ReadAsStringAsync();
                    //Items = new List<RootObject>();
                    //RestList ObjrestList = new RestList();
                    if (response.IsSuccessStatusCode)
                    {
                        //Items = JsonConvert.DeserializeObject<List<RootObject>>(responseBody);
                        //ObjrestList = JsonConvert.DeserializeObject<RestList>(responseBody);
                        var myService = MyService.FromJson(responseBody);
                            listView.ItemsSource = myService;
                    }
                    
                    // listView.ItemsSource = RootObject.;
                    
                    //var myService = MyService.FromJson(jsonString);
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(@" Error {0}", ex.Message);
                }
            }
            else
            {
                await DisplayAlert("json", "No network available.", "ok");
            }
            



        }
        /*
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        */


    }
    
        

}

