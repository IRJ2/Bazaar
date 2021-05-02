using Bazaar.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bazaar.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllView : ContentView
    {
        ObservableCollection<ItemClass> displayitems;
        
        public AllView()
        {
            displayitems = new ObservableCollection<ItemClass>();
            InitializeComponent();
            displayitems.Add(new ItemClass
            {
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
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
                categoryimage = "tomato.png",
                categoryname = "Tomato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });
            displayitems.Add(new ItemClass
            {
                categoryimage = "potato.png",
                categoryname = "Potato",
                itemcost = "₹ 40",
                itemamount = "1 kg"
            });
            MainCollectionView.ItemsSource = displayitems;
        }
    }
}