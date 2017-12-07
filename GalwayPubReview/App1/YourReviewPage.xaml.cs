using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class YourReviewPage : Page
    {
        public YourReviewPage()
        {
            this.InitializeComponent();
        }

        private async void SubmitReview_button_Click(object sender, RoutedEventArgs e)
        {
            var r = new Review()
            {
                Name = NameTb.Text + " Date: " + DateTime.Now.ToString("d/MM/yyyy"),
                Pub = GlobalVars._pub,
                YourReview = ReviewTb.Text,
                BevRating = GlobalVars._bRate,
                AtmosRating = GlobalVars._aRate,
                CraicRating = GlobalVars._cRate
            };

            if (GlobalVars._pub == null)
            {
                WarningTextBlock.Text = "You have not selected a Pub to Review please go back to step 1";
            }
            else if (NameTb.Text == "")
            {
                WarningTextBlock.Text = "You have not entered a Name for your Review. Please enter Name. ";
            }
            else if (r.YourReview == "")
            {
                WarningTextBlock.Text = "You have not entered a Review. Please write a Review. ";
            }
            else
            {
                var reviewJson = JsonConvert.SerializeObject(r);
                var client = new HttpClient();
                var HttpContent = new StringContent(reviewJson);
                HttpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                //await client.PostAsync("http://localhost:63030/api/Reviews", HttpContent);
                await client.PostAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews", HttpContent);
                this.Frame.Navigate(typeof(PubReviewsPage));

                GlobalVars._pub = null;
            }
        }
    }
}
