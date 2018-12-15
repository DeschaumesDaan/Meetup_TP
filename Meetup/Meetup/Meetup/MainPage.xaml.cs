using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meetup.Model;
using Xamarin.Forms;

namespace Meetup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            showLocations();

        }

       async void showLocations()
        {
            try
            {
                lvwLocations.ItemsSource = await MeetManager.GetLocations();
            }
            catch 
            {
                Debug.WriteLine("Deze locaties konden niet worden gevonden" + MeetManager.GetLocations());
            }
        }


        private void LvwLocations_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
