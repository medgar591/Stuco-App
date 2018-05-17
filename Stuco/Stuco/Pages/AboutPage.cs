using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    //This page just contains info about the people who have helped with the project. Feel free to add your name.
    class AboutPage : ContentPage
    {
        public AboutPage()
        {
            var layout = new StackLayout();
            Label header = new Label()
            {
                Text = "About the app",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center,
            };
            Label body = new Label()
            {
                Text = "This app was designed and built by the Rockwood Summit Beyond Beta Technology Club (formerly the Coding Club). It was designed and coded by various members of the club. Noteworthy Members include: ",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Margin = new Thickness(10),
            };

            //To add a name, just add it to the array
            String[] people = {
                "Donny Shaw",
                "Jeffery Donner",
                "Marquis Powell",
                "Hannah Juelfs",
                "Matt Edgar",
                "And many more"
            };
            ListView contributers = new ListView()
            {
                ItemsSource = people,
            };

            contributers.ItemSelected += (sender, e) => { //This prevents the user from clicking on anyone in the list
                ((ListView)sender).SelectedItem = null;
            };

            layout.Children.Add(header);
            layout.Children.Add(body);
            layout.Children.Add(contributers);

            this.Content = layout;
        }
    }
}
