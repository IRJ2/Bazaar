using Bazaar.Model;
using System;
using System.Collections;
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
        ObservableCollection<CategoryClass> categories;
        ObservableCollection<ItemClass> subcategories;
        List<string> footertext;
        public HomePage()
        {
            Datas = new ObservableCollection<CarouselClass>();
            categories = new ObservableCollection<CategoryClass>();
            subcategories = new ObservableCollection<ItemClass>();
            InitializeComponent();
            footertext = new List<string>()
            {
                "Get things delivered to your \ndoorstep instantly",
                "Delivery from anywhere in \nthe city",
                "No minimum order value on your\npurchace"
            };
            BindableLayout.SetItemsSource(SecondBindableLayout,footertext);
            subcategories.Add(new ItemClass
            {
                categoryimage = "Rectangle434.png",
                categoryname = "Medicines"
            });
            subcategories.Add(new ItemClass
            {
                categoryimage = "Rectangle435.png",
                categoryname = "Pet Supplies"
            });
            subcategories.Add(new ItemClass
            {
                categoryimage = "Rectangle437.png",
                categoryname = "Gift and\nLifestyles"
            });
            subcategories.Add(new ItemClass
            {
                categoryimage = "Rectangle121.png",
                categoryname = "Other Store\nin City"
            });
            BindableLayout.SetItemsSource(MainBindableLayout, subcategories);

            categories.Add(new CategoryClass
            {
                categoryimage = "Rectangle1439.png" ,
                categoryname = "Groceries &\nEssentials"
            });
            categories.Add(new CategoryClass
            {
                categoryimage = "Rectangle439.png",
                categoryname = "Pickup &\nDrop"
            });
            categories.Add(new CategoryClass
            {
                categoryimage = "Rectangle4392.png",
                categoryname = "Food\nDelivery"
            });
            categories.Add(new CategoryClass
            {
                categoryimage = "Rectangle4393.png",
                categoryname = "Meat &\nFish"
            });
            MainCollectionView.ItemsSource = categories;
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