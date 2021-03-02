using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Light
{
    public partial class MainPage : ContentPage
    {
        StackLayout stackLayout = new StackLayout();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Red_Clicked(object sender, EventArgs e)
        {

            Background.BackgroundColor = Color.Red;
        }

        private void Yellow_Clicked(object sender, EventArgs e)
        {
            Background.BackgroundColor = Color.Yellow;
        }
        private void Green_Clicked(object sender, EventArgs e)
        {
            Background.BackgroundColor = Color.Green;
        }
    }
}
