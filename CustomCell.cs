using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace App3
{
  //   public class Product
  //   {
  //       public int ID { get; set; }
  //       public string Name { get; set; }
  //       public decimal UnitCost { get; set; }
  //       public string Image { get; set; }
  //   }
	// public class Data
	// {
  //
  //       #region ProductList
  //       public static ObservableCollection<Product> ProductList = new ObservableCollection<Product>
  //       {
  //           new Product {ID = 1, Name ="Widget", UnitCost=19.99m, Image ="icon.png"},
  //           new Product {ID = 2, Name ="sprocket", UnitCost=18.99m, Image ="icon.png"},
  //           new Product {ID = 3, Name ="dingus", UnitCost=17.99m, Image ="icon.png"},
  //           new Product {ID = 4, Name ="aiga", UnitCost=16.99m, Image ="icon.png"},
  //           new Product {ID = 5, Name ="burner", UnitCost=15.99m, Image ="icon.png"},
  //           new Product {ID = 6, Name ="tool", UnitCost=14.99m, Image ="icon.png"},
  //
  //       };
  //       #endregion
  //
  //
  //   }
    /**
    public partial class MyService
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("restaurantName")]
        public string RestaurantName { get; set; }

        [JsonProperty("contents")]
        public List<Content> Contents { get; set; }

        [JsonProperty("location")]
        public List<Location> Location { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("foodName")]
        public string FoodName { get; set; }

        [JsonProperty("priceSegment")]
        public string PriceSegment { get; set; }

        [JsonProperty("allergens")]
        public string Allergens { get; set; }
    }
        */


    public partial class MyService
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("restaurantName")]
        public string RestaurantName { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("foodName")]
        public string FoodName { get; set; }

        [JsonProperty("foodType")]
        public string FoodType { get; set; }

        [JsonProperty("priceSegment")]
        public string PriceSegment { get; set; }

        [JsonProperty("allergens")]
        public string Allergens { get; set; }

        [JsonProperty("location")]
        public List<Location> Location { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }
    }
   /* public partial class Location
    {
        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }
    }

    public partial class MyService
    {
        public static List<MyService> FromJson(string json) => JsonConvert.DeserializeObject<List<MyService>>(json, App3.Converter.Settings);
    }
    */
    public static class Serialize
    {
        public static string ToJson(this List<MyService> self) => JsonConvert.SerializeObject(self, App3.Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }





}
