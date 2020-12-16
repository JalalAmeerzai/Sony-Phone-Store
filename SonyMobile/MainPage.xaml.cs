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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SonyMobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            listView.SelectedIndex = 0;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,3,0);
            timer.Tick += timer_Tick;
            timer.Start();

        }
        int count = 1;

        void timer_Tick(object sender, object e)
        {
            if (count >= 0 && count < 4)
            {
                listView.SelectedIndex = count;
                count++;
            }
            else {
                count = 0;
            }
        }

        DispatcherTimer timer;

        private async void goHome(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void goBrand(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Brands));
        }

        private void slider(object sender, SelectionChangedEventArgs e)
        {
            flipView.SelectedIndex = listView.SelectedIndex;
            
        }

        private void flipSlider(object sender, SelectionChangedEventArgs e)
        {
            //listView.SelectedIndex = flipView.SelectedIndex;
        }
    }
}
