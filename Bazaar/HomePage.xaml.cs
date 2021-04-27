using Bazaar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bazaar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        ObservableCollection<CarouselClass> Datas;
        List<string> HomepageImages;
        public HomePage()
        {
            Datas = new ObservableCollection<CarouselClass>();
            InitializeComponent();
            HomepageImages = new List<string>()
            {
                "Group47750.png",
                "Group47751.png",
                "Group47752.png",
                "Group47753.png"
            };
            MainCollectionView.ItemsSource = HomepageImages;
            Datas.Add(new CarouselClass
            {
                viewtext = "Get 10% off on your \nfirst food Delivery",
                viewimage = "Rectangle.png"
            });

            Datas.Add(new CarouselClass
            {
                viewtext = "Get 10% off on your \nfirst food Delivery",
                viewimage = "Rectangle.png"
            });

            Datas.Add(new CarouselClass
            {
                viewtext = "Get 10% off on your \nfirst food Delivery",
                viewimage = "Rectangle.png"
            });
            MainCarouselView.ItemsSource = Datas;
            
        }
    }
}