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
    public partial class ProfilePage : ContentPage
    {
        ObservableCollection<ProfileClass> options;
        public ProfilePage()
        {
            options = new ObservableCollection<ProfileClass>();
            InitializeComponent();
            options.Add(new ProfileClass
            {
                option= "Orders",
                optionimage="option5.png"
            });
            options.Add(new ProfileClass
            {
                option = "Saved Addresses",
                optionimage = "option4.png"
            });
            options.Add(new ProfileClass
            {
                option = "Notifications",
                optionimage = "option3.png"
            });
            options.Add(new ProfileClass
            {
                option = "Help & Support",
                optionimage = "option2.png"
            });
            options.Add(new ProfileClass
            {
                option = "About Us",
                optionimage = "option1.png"
            });
        }
    }
}