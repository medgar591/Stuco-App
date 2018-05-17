using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    class MDDetail : ContentPage
    {
        //This the default page, and currently what is first shown when the app runs
        public MDDetail()
        {
            this.Content = new LoadingPage().Content;
            this.Title = "Stuco";
        }

        //Just a test constructor, displays a page with the number given on it
        public MDDetail(int n)
        {
            var layout = new StackLayout() { Padding = new Thickness(10) };
            layout.Children.Add(new Label { Text = n.ToString() });
            this.Content = layout;
            this.Title = "Title 2";
        }

        //Actually useful constructor. Shows the content passed in
        public MDDetail (View p)
        {
            this.Content = p;
            this.Title = "Title 3";
        }
    }
}
