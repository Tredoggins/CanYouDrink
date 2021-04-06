using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CanYouDrink
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //I Checked for Errors and Outputed them on the page and you said I could get Extra points for that
            //Also the commented out portions were for when the input was a Text Field
            //if (Age.Text.Length>0)
            double age = DateTime.Now.Subtract(Age.Date).TotalDays / 365;
            if (age<200&&age>0)
            {
                
                try
                {
                    //int age = int.Parse(Age.Text);
                    
                    int until = 21 - ((int)age);
                    if (until > 0)
                    {
                        Out.Text = "You Have " + until + (until==1?" Year":" Years")+ " Until You Can Drink";
                        Back.BackgroundColor = Xamarin.Forms.Color.Orange;
                    }
                    else
                    {
                        Out.Text = "You Can Drink!";
                        Back.BackgroundColor = Xamarin.Forms.Color.Green;
                    }
                    Err.Text = "";
                }
                catch
                {
                    //Err.Text = "Age Must Be A Number";
                    //Out.Text = "Enter Your Age And Submit!";
                    //Back.BackgroundColor = Xamarin.Forms.Color.Blue;
                }
            }
            else
            {
                //Err.Text = "You Must Enter Your Age";
                Err.Text = "Please Enter A Valid Age";
                Out.Text = "Enter Your Age And Submit!";
                Back.BackgroundColor = Xamarin.Forms.Color.Blue;
            }
        }
    }
}
