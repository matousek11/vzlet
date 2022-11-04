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
                    return null;
            }
            ParseRockets(jsonString);
        }

        private static void ParseRockets(string jsonString)
        {
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
            new MissionModel();
        }
    }
}
