using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    public class HomePage : ContentPage
    {
        //All of the views are kept outside of the constructor, just in case they are needed
        Button checkIn;
        Label name;
        View pic;
        View calendar;

        public HomePage()
        {
            /*This is the grid for the app. It creates a 5 X 3 grid
             * Looks sort of like: 
             * Pic & User
             * Button
             * Calendar
             * */
            var layout = new Grid { Margin = new Thickness (10) };

            //5 rows, 1 user, 1 button, 3 for the calendar
            layout.RowDefinitions.Add(new RowDefinition()); //0
            layout.RowDefinitions.Add(new RowDefinition()); //1
            layout.RowDefinitions.Add(new RowDefinition()); //2
            layout.RowDefinitions.Add(new RowDefinition()); //3
            layout.RowDefinitions.Add(new RowDefinition()); //4

            //3 columns, 
            layout.ColumnDefinitions.Add(new ColumnDefinition()); //0
            layout.ColumnDefinitions.Add(new ColumnDefinition()); //1
            layout.ColumnDefinitions.Add(new ColumnDefinition()); //2

            //Views
            name = GetUsername();
            pic = GetProfile();
            calendar = GetCalendar();
            checkIn = new Button
            {
                Text = "I am here",
                IsEnabled = (Boolean)Application.Current.Properties["OnCampus"], //Pulls from the OnCampus property when creating the button *NOTE* This does not mean the button will update
            };

            
            layout.Children.Add(pic, 0, 1, 0, 1);
            layout.Children.Add(name, 1, 3, 0, 1);
            layout.Children.Add(checkIn, 0, 3, 1 , 2);
            layout.Children.Add(calendar, 0, 3, 2, 5);

            this.Content = layout;
            this.Title = "Stuco";

        }

        //Method to find the user, if they are logged in, and create a label showing their name
        public static Label GetUsername ()
        {
            return new Label { Text = "Freddie Falcon - 200 pts", VerticalTextAlignment = TextAlignment.End, HorizontalTextAlignment = TextAlignment.Start };
        }

        //Finds and returns an appropriate profile pic, based on if they are logged in, points, etc. 
        public static View GetProfile()
        {
            return new BoxView { Color = Color.Aqua };
        }

        //Tries to retrieve the activities calendar. In case of an error, presents blank gray box.
        public static View GetCalendar()
        {
            var canGetCalendar = false;
            View calendar = new BoxView { Color = Color.LightGray }; ;

            if (canGetCalendar)
            {

            }
            return calendar;
        }
    }
}
