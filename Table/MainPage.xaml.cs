using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Table
{
    
    public partial class MainPage : ContentPage
    {
        public int italy_count = 0;
        public int germany_count = 0;
        public int temp = 0;
        public MainPage()
        {
            InitializeComponent();
          
           
        }

        private void Italy_Clicked(object sender, EventArgs e)
        {
            italy_count++;
            ita_count.Text = italy_count.ToString();
        }

        private void Germany_Clicked(object sender, EventArgs e)
        {
            germany_count++;
            ger_count.Text = germany_count.ToString();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            italy_count = 0;
            ita_count.Text = italy_count.ToString();
            germany_count = 0;
            ger_count.Text = germany_count.ToString();
        }

        

        private void Switcher_Clicked(object sender,EventArgs e)
        {
            temp++;
            if (temp % 2 != 0)
            {
                Title = "Футбольный матч";
                Italy.Text = "Италия";
                Germany.Text = "Германия";
                Reset.Text = "Сброс";
                Switcher.Text = "Переключить язык";
            }
            else
            {

                Title = "Football cup";
                Italy.Text = "Italy";
                Germany.Text = "Germany";
                Reset.Text = "Reset";
                Switcher.Text = "Switch language";
            }
           
             
            
        }
        private double width = 0;
        private double height = 0;
      
        protected override void OnSizeAllocated(double width, double height)
        {
          

            
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                    if (width > height)
                    {
                        outerStack.Orientation = StackOrientation.Horizontal;
                        Main.Spacing = 100;
                        img_ger.WidthRequest = 150;
                        img_ger.HeightRequest = 100;
                        img_ita.WidthRequest = 150;
                        img_ita.HeightRequest = 100;
                        buttons.Spacing = 110;



                    }
                    else
                    {
                        outerStack.Orientation = StackOrientation.Vertical;
                        Main.Spacing = 10;
                        img_ger.WidthRequest = 120;
                        img_ger.HeightRequest = 80;
                        img_ita.WidthRequest = 120;
                        img_ita.HeightRequest = 80;
                        buttons.Spacing = 70;
                        Germany.WidthRequest = 120;
                        Italy.WidthRequest = 120;
                        Reset.WidthRequest = 150;
                        
                    }        


                
            }
        }
    }
}
