using SonyMobile.Common;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace SonyMobile
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class ProductPage : Page
    {
        
        public ProductPage()
        {
            this.InitializeComponent();



            

        }

        
        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        

        

        #endregion


        Product product;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            product = e.Parameter as Product;

            productTitle.Text = product.name;
            productDetail.Text = product.detail;
            productPrice.Text = product.price;
            productCamera.Text = product.camera;
            productSim.Text = product.sim;
            productStorage.Text = product.storage;

            productImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/" + product.source, UriKind.Absolute));
            
        }



        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Brands));
        }

        private void goBrand(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Brands));
        }

        private void goHome(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
