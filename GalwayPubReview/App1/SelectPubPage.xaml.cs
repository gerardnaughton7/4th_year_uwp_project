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
        private String _pub;

        public SelectPubPage()
        {
            this.InitializeComponent();
        }

        //Use f12 to create click stub
        private void Pub_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _pub = selected.Text;
            displayResult();
        }

        private void displayResult()
        {   
            if(string.IsNullOrEmpty(_pub))
            {
                ResultTextBlock.Text = "No Pub Selected";
                return;
            }
            ResultTextBlock.Text = _pub;
        }
    }
}
