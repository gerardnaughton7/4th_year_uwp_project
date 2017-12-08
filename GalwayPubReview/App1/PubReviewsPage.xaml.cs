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
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PubReviewsPage : Page
    {
        public PubReviewsPage()
        {
            this.InitializeComponent();

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();
            var JsonResponse = await client.GetStringAsync("http://localhost:63030/api/Reviews");
            //var JsonResponse = await client.GetStringAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews");
            var reviewResult = JsonConvert.DeserializeObject<List<Review>>(JsonResponse);
            reviewResult.Reverse();
            reviewList.ItemsSource = reviewResult;
        }

        private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SearchQuery(args.QueryText);
        }

        private async void SearchQuery(string queryText)
        {
            Debug.WriteLine(queryText);
            HttpClient client = new HttpClient();
            var JsonResponse = await client.GetStringAsync("http://localhost:63030/api/Reviews");
            //var JsonResponse = await client.GetStringAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews");
            var reviewResult = JsonConvert.DeserializeObject<List<Review>>(JsonResponse);
            bool match = false;
            List<Review> searchResult = new List<Review>();
            foreach (var r in reviewResult)
            {
                if(r.Pub.ToLower() == queryText.ToLower())
                {
                    searchResult.Add(r);
                    match = true;
                }
            }

            if(match == true)
            {
                searchList.Visibility = Visibility.Visible;
                reviewList.Visibility = Visibility.Collapsed;
                searchList.ItemsSource = searchResult;
            }
            else
            {
                errorMessage.Visibility = Visibility.Visible;
            }

        }

        private void SearchBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                if (sender.Text.Length < 1)
                {
                    //load_data();
                    searchList.Visibility = Visibility.Collapsed;
                    reviewList.Visibility = Visibility.Visible;
                    errorMessage.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
