using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App3
{
    public class MyServices 
    {
        //static string RestUrl = "http://192.168.1.11:8000/filter/beef/1/1/1/59.914561/10.442108/0/Moss";
        /*
        public async void GetJson()
        {
            
            HttpClient client;
            if (NetworkCheck.IsInternet())
            {
                //client = new System.Net.Http.HttpClient();
                client = new HttpClient();
                var response = await client.GetAsync("http://192.168.1.11:8000/filter/beef/1/1/1/59.914561/10.442108/0/Moss");
                string restaurantJson = await response.Content.ReadAsStringAsync();
                RestaurantList ObjRestaurantList = new RestaurantList();
                if (restaurantJson != "")
                {
                    ObjRestaurantList = JsonConvert.DeserializeObject<RootObject>(rootObjects);
                }
                listView.ItemSource = ObjRestaurantList.rootObjects;
            }
            else
            {
                //var res = await DisplayAlert("json", "No network available.", "ok");
            }
            //ProgressLoader.IsVisible = false;
            
        }
        */
        /*
        HttpClient client = new HttpClient();
        
            public async void GetJson()
        {
            var uri = new Uri(string.Format(RestUrl, string.Empty));

        }
        */

    }
 





}
