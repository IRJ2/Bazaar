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
    public partial class RestaurantList : ContentPage
    {
        ObservableCollection<RestaurantListClass> hotels;
        public RestaurantList()
        {
            hotels = new ObservableCollection<RestaurantListClass>();
            InitializeComponent();
            hotels.Add(new RestaurantListClass
            {
                hotelimage="Rectangle446.png",
                hotelname= "Paragon Restaurant",
                clockimage="ClockIcon.png",
                timetoreach= "Within 25 mins",
                hotelplace= "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle447.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle448.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle446.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle447.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle448.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle446.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle447.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            hotels.Add(new RestaurantListClass
            {
                hotelimage = "Rectangle448.png",
                hotelname = "Paragon Restaurant",
                clockimage = "ClockIcon.png",
                timetoreach = "Within 25 mins",
                hotelplace = "Mananchira"
            });
            MainCollectionView.ItemsSource = hotels;
        }
        private async void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainCollectionView.SelectedItem != null)
            {
                RestaurantListClass selecteddata = e.CurrentSelection[0] as RestaurantListClass;
                await Navigation.PushAsync(new RestaurantMenuPage(selecteddata));
            }
        }
    }
}