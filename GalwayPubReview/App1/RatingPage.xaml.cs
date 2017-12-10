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
    public sealed partial class RatingPage : Page
    {
        public RatingPage()
        {
            this.InitializeComponent();
        }

        // set bev rating
        private void Bev_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            GlobalVars._bRate = (int)Bev.Value;
        }

        // set atmosphere rating
        private void Atmos_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            GlobalVars._aRate = (int)Atmos.Value;
        }

        // set craic rating
        private void Craic_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            GlobalVars._cRate = (int)Craic.Value;
        }

        // of clicked navigate to next step yourReview
        private void Step2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(YourReviewPage));
        }
    }
}
