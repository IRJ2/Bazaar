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
        ObservableCollection<SubcategotyClass> subcategories;

        public HomePage()
        {
            Datas = new ObservableCollection<CarouselClass>();
            categories = new ObservableCollection<CategoryClass>();
            subcategories = new ObservableCollection<SubcategotyClass>();
            InitializeComponent();
            subcategories.Add(new SubcategotyClass
            {
                categoryimage = "Rectangle434.png",
                categoryname = "Medicines"
            });
            subcategories.Add(new SubcategotyClass
            {
                categoryimage = "Rectangle435.png",
                categoryname = "Pet Supplies"
            });
            subcategories.Add(new SubcategotyClass
            {
                categoryimage = "Rectangle437.png",
                categoryname = "Gift and\nLifestyles"
            });
            subcategories.Add(new SubcategotyClass
            {
                categoryimage = "Rectangle448.png",
                categoryname = "Other Store\nin City"
            });
            BindableLayout.SetItemsSource(MainBindableLayout,ItemSource);

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

        public IEnumerable ItemSource { get; }
    }
}