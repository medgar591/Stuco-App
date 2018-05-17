using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stuco
{
    public class MDpage : MasterDetailPage
    {
        MDMaster mPage;
        MDDetail dPage;
        public MDpage()
        {

            mPage = new MDMaster();
            dPage = new MDDetail();

            Master = mPage;
            Detail = new NavigationPage(dPage); //Needs to be a navigation page for the menu to show up
            Title = "Title 7";

            mPage.list.ItemSelected += ListView_ItemSelected; //Adds the event which is used to redirect the user
        }
        //click on effect
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MDItem; //I believe this is a weird way of castinng?
            if (item == null)
                return; //If the item is blank (the weird casting will return null if e isn't an MDItem), nothing happens
            var page = item.Page; //Because item is an MDItem, it can use the Page property to get the content


            Detail = new NavigationPage(new ContentPage { Content = page, Title = "Stuco" }) { Title = "Title 6" }; //The "Stuco" title is the most primary title I believe
            IsPresented = false; //This says that the menu closes after the redirect

            mPage.list.SelectedItem = null; //Deselects menu item
        }
    }
}


