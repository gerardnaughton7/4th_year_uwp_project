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


namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(PubReviewsPage));
        }

        // Navigate to pubReview page
        private void PubReviewsButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(PubReviewsPage));
        }

        // navigate to select pub page
        private void SelectPubButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(SelectPubPage));
        }

        //navigate to ratings page
        private void RatingButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(RatingPage));
        }

        //navigate to your review page
        private void YourReviewButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(YourReviewPage));
        }

        private void MyFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
