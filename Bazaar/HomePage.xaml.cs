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

        public HomePage()
        {
            Datas = new ObservableCollection<CarouselClass>();
            InitializeComponent();
            Datas.Add(new CarouselClass
            {
                viewtext = "Hello",
                viewimage = "Rectangle.png"
            });

            Datas.Add(new CarouselClass
            {
                viewtext = "Hello",
                viewimage = "Rectangle.png"
            });

            Datas.Add(new CarouselClass
            {
                viewtext = "Hello",
                viewimage = "Rectangle.png"
            });
            MainCarouselView.ItemsSource = Datas;
        }
    }
}