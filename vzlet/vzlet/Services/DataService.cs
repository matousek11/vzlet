using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using vzlet.Models;

namespace vzlet.Services
{
    class DataService
    {
        
        public static async void ReturnRockets(string url)
        {
            string jsonString = "";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                    jsonString = await response.Content.ReadAsStringAsync();
                else
                    return;
            }
            ParseRockets(jsonString);
        }

        private static List<RocketLaunchModel> ParseRockets(string jsonString)
        {
            List<RocketLaunchModel> rockets = new List<RocketLaunchModel>();
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
            foreach (JsonElement rocket in jsonDocument.RootElement.GetProperty("result").EnumerateArray())
            {
                int id = (int)rocket.GetProperty("id").GetDouble();
                string name = rocket.GetProperty("name").GetString();
                string providerName = rocket.GetProperty("provider").GetProperty("name").GetString();
                string winOpen = rocket.GetProperty("win_open").GetString();
                rockets.Add(new RocketLaunchModel(id, name, providerName, winOpen));
            }
            return rockets;
        }
    }
}
