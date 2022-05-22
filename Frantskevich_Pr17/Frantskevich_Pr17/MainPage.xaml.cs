using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Frantskevich_Pr17
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonResult_Clicked(object sender, EventArgs e)
        {
            using (WebClient webClient = new WebClient())
            {
                lableResult.TextColor = Color.Black;
                string req = webClient.DownloadString($"http://numbersapi.com/{entryNumber.Text.Replace(".", "")}?notfound=ceil");
                lableResult.Text = req;
            }
        }
    }
}
