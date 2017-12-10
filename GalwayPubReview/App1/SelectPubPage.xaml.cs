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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SelectPubPage : Page
    {

        public SelectPubPage()
        {
            this.InitializeComponent();
        }

        //Select pub from list of menu flyout item
        private void Pub_Click(object sender, RoutedEventArgs e)
        {

            var selected = (MenuFlyoutItem)sender;
            GlobalVars._pub = selected.Text;
            displayResult();
        }

        // function if nothing is selected display no pub selected if a pub is selected show chosen pub
        private void displayResult()
        {   
            if(string.IsNullOrEmpty(GlobalVars._pub))
            {
                ResultTextBlock.Text = "No Pub Selected";
                return;
            }
            ResultTextBlock.Text = GlobalVars._pub;
        }

        // navigate to next step pub rating
        private void Step1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RatingPage));
        }
    }
}
