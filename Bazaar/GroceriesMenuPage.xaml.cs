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
    public partial class GroceriesMenuPage : ContentPage
    {
        ObservableCollection<CategoryClass> Items;
        ObservableCollection<ItemClass> displayitems;
        public GroceriesMenuPage(Model.RestaurantListClass Grocery)
        {
            Items = new ObservableCollection<CategoryClass>();
            displayitems = new ObservableCollection<ItemClass>();
            InitializeComponent();
            displayitems.Add(new ItemClass
            {
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost= "₹ 40",
                itemamount= "1 kg"
            });
            displayitems.Add(new ItemClass
            {
                categoryimage = "potato.png",
                categoryname = "Potato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });
            displayitems.Add(new ItemClass
            {
                categoryimage = "Defaultimage.png",
                categoryname = "Veggy",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });
            displayitems.Add(new ItemClass
            {
                categoryimage = "Defaultimage.png",
                categoryname = "Veggy",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });
            displayitems.Add(new ItemClass
            {
                categoryimage = "Defaultimage.png",
                categoryname = "Veggy",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });

            BindableLayout.SetItemsSource(MainBindableLayout, displayitems);




            Items.Add(new CategoryClass
            {
                categoryimage="veggies.png",
                categoryname= "Fresh\nVegetables"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "Fruits.png",
                categoryname = "Fresh Fruits"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            Items.Add(new CategoryClass
            {
                categoryimage = "DefaultImage.png",
                categoryname = "Category"
            });
            MainCollectionView.ItemsSource = Items;
            HotelImage.Source = Grocery.hotelimage;
            HotelName.Text = Grocery.hotelname;
            HotelPlace.Text = Grocery.hotelplace;
            TimeToReach.Text = Grocery.timetoreach;
            ClockIcon.Source = Grocery.clockimage;
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainCollectionView.SelectedItem != null)
            {
                CategoryClass selecteddata = e.CurrentSelection[0] as CategoryClass;
                await Navigation.PushAsync(new CategoryPage(selecteddata));
            }
        }
    }
}