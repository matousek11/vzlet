using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vzlet.Services;
using Xamarin.Forms;

namespace vzlet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            rockets.ItemsSource = DataService.ReturnRockets().Result;
        }
    }
}
