using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using vzlet.Models;

namespace vzlet.Services
{
    class DataService
    {
        
        public static async Task<List<RocketLaunchModel>> ReturnRockets()
        {
            string jsonString = "";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = httpClient.GetAsync("https://fdo.rocketlaunch.live/json/launches/next/5").ConfigureAwait(false).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                    jsonString = await response.Content.ReadAsStringAsync();
                else
                    return null;
            }
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
