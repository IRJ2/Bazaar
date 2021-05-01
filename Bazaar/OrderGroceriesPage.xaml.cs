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
    public partial class OrderGroceriesPage : ContentPage
    {
        ObservableCollection<RestaurantListClass> Grocery;
        public OrderGroceriesPage()
        {
            Grocery = new ObservableCollection<RestaurantListClass>();
            InitializeComponent();
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            Grocery.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle121.png",
                hotelname = "Reliance Fresh",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            MainCollectionView.ItemsSource = Grocery;

        }
        private async void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainCollectionView.SelectedItem != null)
            {
                RestaurantListClass selecteddata = e.CurrentSelection[0] as RestaurantListClass;
                await Navigation.PushAsync(new GroceriesMenuPage(selecteddata));
            }
        }
    }
}