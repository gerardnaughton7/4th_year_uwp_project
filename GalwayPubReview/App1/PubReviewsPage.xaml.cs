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

        // when navigated to this page take in reviews from database and output in listbox
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            HttpClient client = new HttpClient();
            var JsonResponse = await client.GetStringAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews");
            var reviewResult = JsonConvert.DeserializeObject<List<Review>>(JsonResponse);
            reviewResult.Reverse();
            reviewList.ItemsSource = reviewResult;
        }

        // observe if query is submitted from search box
        private void SearchBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SearchQuery(args.QueryText);
        }

        // Search query method
        private async void SearchQuery(string queryText)
        {
            // search database for pub that was entered
            HttpClient client = new HttpClient();
            var JsonResponse = await client.GetStringAsync("http://reviewwebapp20171205092533.azurewebsites.net/api/Reviews");
            var reviewResult = JsonConvert.DeserializeObject<List<Review>>(JsonResponse);
            bool match = false;
            List<Review> searchResult = new List<Review>();
            //loop through reviews to see if there is a match for that pub and add it to a list of matched reviews
            foreach (var r in reviewResult)
            {
                if(r.Pub.ToLower() == queryText.ToLower())
                {
                    searchResult.Add(r);
                    match = true;
                }
            }

            // if match is equal to true show the seach results
            if(match == true)
            {
                searchList.Visibility = Visibility.Visible;
                reviewList.Visibility = Visibility.Collapsed;
                searchList.ItemsSource = searchResult;
            }
            else// if no match found show error message
            {
                errorMessage.Visibility = Visibility.Visible;
            }

        }

        // if search query box is empty cancel search and show list of reviews
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
