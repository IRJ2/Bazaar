using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bazaar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddItemPopup
    {
        public AddItemPopup(Model.ItemClass displayitems)
        {
            InitializeComponent();
            Itemname.Text = displayitems.categoryname;
            ItemAmount.Text = displayitems.itemamount;
            ItemCost.Text = displayitems.itemcost;
        }
        private async void ClossButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}