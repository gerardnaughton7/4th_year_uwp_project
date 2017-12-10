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

        // review submission
        private async void SubmitReview_button_Click(object sender, RoutedEventArgs e)
        {
            // create review
            var r = new Review()
            {
                Name = NameTb.Text + " Date: " + DateTime.Now.ToString("d/MM/yyyy"),
                Pub = GlobalVars._pub,
                YourReview = ReviewTb.Text,
                BevRating = GlobalVars._bRate,
                AtmosRating = GlobalVars._aRate,
                CraicRating = GlobalVars._cRate
            };

            if (GlobalVars._pub == null)// if pub is not selected output warning asking user to choose a pub 
            {
                WarningTextBlock.Text = "You have not selected a Pub to Review please go back to step 1";
            }
            else if (NameTb.Text == "")// if Name is blank output warning asking user to fill in
            {
                WarningTextBlock.Text = "You have not entered a Name for your Review. Please enter Name. ";
            }
            else if (r.YourReview == "")// if YourReview is blank output warning asking user to fill in
            {
                WarningTextBlock.Text = "You have not entered a Review. Please write a Review. ";
            }
            else // add review to database and navigate to reviews page
            {
                var reviewJson = JsonConvert.SerializeObject(r);
                var client = new HttpClient();
                var HttpContent = new StringContent(reviewJson);
                HttpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                await client.PostAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews", HttpContent);
                this.Frame.Navigate(typeof(PubReviewsPage));

                // reset values
                GlobalVars._pub = null;
                GlobalVars._bRate = 0;
                GlobalVars._aRate = 0;
                GlobalVars._cRate = 0;

            }
        }
    }
}
