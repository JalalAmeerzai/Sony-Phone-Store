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
    public sealed partial class Brands : Page
    {
        public Brands()
        {
            this.InitializeComponent();
        }

        private void goHome(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void goBrand(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Brands));
        }


        String[] nameData = { 
                            "Sony Xperia C5 Ultra", "Sony Xperia C4 Dual", 
                            "Sony Xperia m5 Dual", "Sony Xperia M4", 
                            "Sony Xperia T3", "Sony Xperia T2", 
                            "Sony Xperia XA", "Sony Xperia X", 
                            "Sony Xperia Z5 Premium", "Sony Xperia Z3" 
                        };

        String[] detailData = { 
                            "The Xperia C5 Ultra Dual brings your best moments to life with breathtaking clarity, using front and back cameras that are equally powerful. Packed full of Sony camera expertise, the Xperia C5 Ultra Dual benefits from Superior Auto, autofocus and PROselfie™, so you can take the sharpest selfies imaginable.",

                            "The Xperia C4 Dual has a big, bright and beautiful 13.97cm Full HD display with enhanced sharpness and contrast. So, whether you’re checking out your friend’s photos, watching that cute puppy video, or catching up with a favourite TV series, every detail will look truly amazing.",

                            "Sometimes you only get one chance to get the perfect shot. That’s why the Xperia M5 Dual is packed full of technology to help you capture the moment as it happens. Shoot like a pro with 0.25-second Hybrid Autofocus, 21.5 megapixels and super-sharp zoom.",

                            "The average mobile phone can get very dirty. Keeping your phone clean keeps it looking good – and it makes good hygienic sense. Don’t you wish you could wash your phone with water? It’s readily available, effective and almost free! But of course water is damaging to electronic devices. That’s why Sony now presents the M4 Aqua – a water-loving phone you can wash anywhere, anytime.", 

                            "Experience a Quad-core smartphone with an elegance you can both see and feel. Impressively thin and light, the Xperia T3 comes wrapped in a stainless steel frame and is available in a range of gorgeous colours. The result is a real eye-catcher with a truly stylish and unique expression.", 

                            "For a phone with a 15.24 cm screen, the Xperia T2 Ultra Dual has a surprisingly sleek look and feel. The lightweight design of this new Android phone makes it easy to stay entertained when you’re on the go.", 

                            "Your smartphone follows you everywhere. That’s why Xperia XA has been designed with a new look and feel to truly harmonise with your life. Bringing together a stunning full-width display, a smooth, curved form and a size that’s not-too-big and not-too-small. It’s just right.", 

                            "Low-light selfies aren’t easy, but Xperia X was built for the challenge. With 13 megapixels and Sony’s renowned low-light sensors, this is the front camera for round-the-clock sharpness.", 

                            "Imagine the best of Sony TV technologies delivered in a smartphone. A super-vivid and sharp display, right in the palm of your hand. Meet Xperia Z5 Premium Dual. With a 4K Ultra HD display, this 13.97 cm (5.5”) smartphone packs in four times the resolution of Full HD for an unrivalled viewing experience.", 

                            "Enjoy top speeds and lag-free performance and transfer files and stream your favourite media quicker and smoother with the Qualcomm® Snapdragon™ 810 processor with integrated LTE and 64-bit Octa-core CPU." 
                          };

        String[] fileNameData = {
                              "b3p3.png", "b8p8.png", "b6p6.png", "b10p10.png", "b11p11.png", 
                              "b4p4.png", "b5p5.png", "b1p1.png", "b7p7.png", "b9p9.png" 
                            };

        String[] priceData = { 
                             "PRICE :: 40,000 PKR", "PRICE :: 70,000 PKR", "PRICE :: 30,000 PKR", "PRICE :: 44,000 PKR", "PRICE :: 66,000 PKR", 
                             "PRICE :: 90,000 PKR", "PRICE :: 75,000 PKR", "PRICE :: 56,000 PKR", "PRICE :: 46,000 PKR", "PRICE :: 88,000 PKR"
                         };

        String[] cameraData = { 
                             "CAMERA :: 16MP", "CAMERA :: 20MP", "CAMERA :: 8MP", "CAMERA :: 12MP", "CAMERA :: 13MP", 
                             "CAMERA :: 16MP", "CAMERA :: 16MP", "CAMERA :: 14MP", "CAMERA :: 5MP", "CAMERA :: 32MP" 
                          };

        String[] simCapabiltyData = {
                                    "SIM CAPABILITY :: Dual sim, micro chip", "SIM CAPABILITY :: Dual sim, micro chip", "SIM CAPABILITY :: Dual sim, micro chip", "SIM CAPABILITY :: Dual sim, micro chip", "SIM CAPABILITY :: Dual sim, micro chip", 
                                    "SIM CAPABILITY :: Single sim, micro chip", "SIM CAPABILITY :: Single sim, micro chip", "SIM CAPABILITY :: Single sim, micro chip", "SIM CAPABILITY :: Single sim, micro chip", "SIM CAPABILITY :: Single sim, micro chip"
                                };

        String[] storageData = { "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal", "STORAGE :: 16gb internal" };

        private async void p1(object sender, TappedRoutedEventArgs e)
        {
            StackPanel panel = sender as StackPanel;
            TextBlock nameText = panel.Children.ElementAt(1) as TextBlock;


            for (int i = 0; i < nameData.Length; i++) {
                if (nameText.Text.Equals(nameData[i])) {


                    

                    Product productDetail = new Product()
                    {
                        name = nameData[i],
                        detail = detailData[i],
                        source = fileNameData[i],
                        price = priceData[i],
                        camera = cameraData[i],
                        sim = simCapabiltyData[i],
                        storage = storageData[i]
                    };

                    this.Frame.Navigate(typeof(ProductPage),productDetail);        
                }
            }
            
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        

    }
}
