using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
