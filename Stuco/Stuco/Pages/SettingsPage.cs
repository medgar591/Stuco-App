using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    class SettingsPage : ContentPage
    {
        Label testing = new Label();
        public SettingsPage()
        {
            var layout = new StackLayout();

            //This part creates a single row with 2 items in it, so that the names and switches are lined up
            Label loggedLabel = new Label() { Text = "Logged In (Dev Only)", HorizontalOptions = LayoutOptions.Start };
            Switch loggedSwitch = new Switch() { IsToggled = false, HorizontalOptions = LayoutOptions.End };
            loggedSwitch.Toggled += logged_Toggled;
            var loggedOption = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children = { loggedLabel, loggedSwitch },
                Margin = new Thickness(20),
            };


            layout.Children.Add(loggedOption);
            layout.Children.Add(testing); //Special label to check effectiveness of Settings/options
            this.Content = layout;            
        }
        void logged_Toggled(Object sender, ToggledEventArgs e)
        {
            Application.Current.Properties["OnCampus"] = (Boolean) e.Value;
            Application.Current.Properties["LoggedIn"] = (Boolean) e.Value;
            //testing.Text = e.Value.ToString() + " " + Application.Current.Properties["OnCampus"].ToString();
        }
    }
}
