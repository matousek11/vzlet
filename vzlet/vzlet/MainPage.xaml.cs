using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vzlet.Models;
using vzlet.Services;
using Xamarin.Forms;

namespace vzlet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadRockets();
        }
        private void LoadRockets()
        {
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            List<RocketLaunchModel> data = DataService.ReturnRockets().Result;
            int i = 0;
            foreach (var rocket in data)
            {
                DateTime dateTime = DateTime.Parse(rocket.WinOpen, null, System.Globalization.DateTimeStyles.RoundtripKind);
                data[i].WinOpen = dateTime.ToString("yyyy-MM-dd hh:mm");
                i++;
            }
            rockets.ItemsSource = data;
        }
    }
}
