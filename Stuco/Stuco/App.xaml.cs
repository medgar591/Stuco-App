using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Stuco
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();
            //Loading page in case any of the other stuff takes too long. 
            MainPage = new Stuco.LoadingPage();

            //Loading Stuff
            //Make sure every Property is initialized here. It will throw errors if there is a null reference in the dictionary
            try
            {
                Application.Current.Properties["LoggedIn"] = Application.Current.Properties["LoggedIn"];
            }
            catch (Exception e)
            {
                Application.Current.Properties["LoggedIn"] = false;
            }
            try
            {
                Application.Current.Properties["OnCampus"] = Application.Current.Properties["OnCampus"];
            }
            catch (Exception e)
            {
                Application.Current.Properties["OnCampus"] = false;
            }
            

            //Run the app normally
            MainPage = new MDpage();
        }

		protected override void OnStart ()
		{
			// TODO
            //Check credentials
            //Check Location
            //Check Calendar
		}

		protected override void OnSleep ()
		{
            //The properties dictionary should be saved normally, but this just makes sure
            Application.Current.SavePropertiesAsync();
            // TODO
            //Halt geo-location services
            //Save credentials and score
        }

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
