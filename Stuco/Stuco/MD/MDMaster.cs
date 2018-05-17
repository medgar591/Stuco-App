using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stuco
{
    class MDMaster : ContentPage
    {
        //Public listView is necessary for navigation
        public ListView list = new ListView();


        public MDMaster()
        {
            var layout = new StackLayout();
            var items = new List<MDItem>();

            //All of the items included in the menu
            items.Add(new MDItem() {Page = new HomePage().Content, Title = "Home" });
            items.Add(new MDItem() { Page = new AboutPage().Content, Title = "About" });
            items.Add(new MDItem() { Page = new SettingsPage().Content, Title = "Settings" });

            //Formatting the ListView so that it shows proper options
            list = new ListView()
            {
                ItemsSource = items,
                ItemTemplate = new DataTemplate(() => { //Function which gives a ViewCell for the ListView. May be able to replace with one of the preprogrammed ones. 
                    Title = "Title 10";
                    var lay = new StackLayout() { Padding = new Thickness(10) };

                    var label = new Label();
                    var button = new Button();
                    label.SetBinding(Label.TextProperty, "Title" ); //I believe the context is defaulted to the individual item being processed
                    //Bindings are really annoying. This sets teh Text Property of label to the "Title" property of something else
                    lay.Children.Add(label);

                    return new ViewCell { View = lay };
                })                
            };

            layout.Children.Add(list);
            Icon = "hamburger.png";
            Title = "Title 5";
            Content = layout;
            
        }
    }
}

