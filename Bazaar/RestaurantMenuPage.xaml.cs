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

        public RestaurantMenuPage(RestaurantListClass hotels)
        {
            
            InitializeComponent();
            HotelImage.Source = hotels.hotelimage;
            HotelName.Text = hotels.hotelname;
            HotelPlace.Text = hotels.hotelplace;
            TimeToReach.Text = hotels.timetoreach;
            ClockIcon.Source = hotels.clockimage;

        }
        
    }
}