using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace A6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private readonly IMemoryCache _cache = new MemoryCache(new MemoryCacheOptions() { });
        public void Set<T>(string key, T value, DateTimeOffset absoluteExpiry)
        {
            _cache.Set(key, value, absoluteExpiry);
        }

        public T Get<T>(string key)
        {
            if (_cache.TryGetValue(key, out T value))
                return value;
            else
                return default(T);
        }
        private async void stringButton_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result;
            var url = "https://venus.sod.asu.edu/WSRepository/Services/NumberGuessRest/Service.svc/GetSecretNumber?lower=" + NumEntry.Text + "&upper=" + NumEntry1.Text;
            var idk = _cache.Get(url);
            if (idk == null)
            {
                bool res = int.TryParse(NumEntry.Text, out _);
                bool res2 = int.TryParse(NumEntry1.Text, out _);
                if (res && res2)
                {
                    try
                    {
                        var response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");

                        DateTimeOffset now = DateTimeOffset.Now;
                        _cache.Set(url, result, now.AddSeconds(10));
                    }
                    catch (HttpRequestException ex)
                    {
                        result = ex.ToString();
                    }
                    numString.Text = "Random Number: " + result;
                }
                else
                    numString.Text = "Please Enter Numbers";
            }
            else
                numString.Text = "Result already queried, random number is: " + idk;

        }
        private async void sumButton_Clicked(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string result;
            var url = "https://venus.sod.asu.edu/WSRepository/Services/WcfRestService4/Service1/add2?x=" + Num1.Text + "&y=" + Num2.Text;
            var idk = _cache.Get(url);

            if (idk == null)
            {
                bool res = int.TryParse(Num1.Text, out _);
                bool res2 = int.TryParse(Num2.Text, out _);
                if (res && res2)
                {
                    try
                    {
                        var response = await client.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        result = (await response.Content.ReadAsStringAsync()).Replace(@"""", "");

                        DateTimeOffset now = DateTimeOffset.Now;
                        _cache.Set(url, result, now.AddSeconds(10));
                    }
                    catch (HttpRequestException ex)
                    {
                        result = ex.ToString();
                    }
                    sumString.Text = "Sum = " + result;
                }
                else
                    sumString.Text = "Please Enter Numbers";
            }
            else
                sumString.Text = "Sum already queried, answer is: " + idk;
           
                
        }

        
    }
}
