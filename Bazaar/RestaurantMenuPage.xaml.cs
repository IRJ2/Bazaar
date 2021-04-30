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
    public partial class RestaurantMenuPage : ContentPage
    {
        ObservableCollection<FoodListClass> Food;

        public RestaurantMenuPage(RestaurantListClass hotels)
        {
            Food = new ObservableCollection<FoodListClass>();

            InitializeComponent();
            Food.Add(new FoodListClass
            {
                foodname="Biriyani\n",
                foodcost= "₹ 140",
                foodimage="food1.png"
            });
            Food.Add(new FoodListClass
            {
                foodname = "Biriyani\n",
                foodcost = "₹ 140",
                foodimage = "food2.png"
            });
            Food.Add(new FoodListClass
            {
                foodname = "Biriyani\n",
                foodcost = "₹ 140",
                foodimage = "food1.png"
            });
            Food.Add(new FoodListClass
            {
                foodname = "Biriyani\n",
                foodcost = "₹ 140",
                foodimage = "food2.png"
            });
            Food.Add(new FoodListClass
            {
                foodname = "Biriyani\n",
                foodcost = "₹ 140",
                foodimage = "food1.png"
            });
            MainCollectionView.ItemsSource = Food;

            HotelImage.Source = hotels.hotelimage;
            HotelName.Text = hotels.hotelname;
            HotelPlace.Text = hotels.hotelplace;
            TimeToReach.Text = hotels.timetoreach;
            ClockIcon.Source = hotels.clockimage;

        }
        
    }
}