using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Stuco
{
    class LoadingPage : ContentPage
    {
        public LoadingPage()
        {
            var layout = new StackLayout();
            View logo = new BoxView { Color = Color.Maroon };//Eventually replace with a Rockwood Logo
            ActivityIndicator loading = new ActivityIndicator { IsRunning = true };

            layout.Children.Add(logo);
            layout.Children.Add(loading);

            this.Content = layout;
        }
    }
}
