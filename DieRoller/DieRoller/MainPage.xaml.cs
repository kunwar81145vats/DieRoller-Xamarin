using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DieRoller
{
    public partial class MainPage : ContentPage
    {
        DieClass die = new DieClass();
        public string ResultValue { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if(die.getCurrentSide() > die.getTotalSides())
            {
                 App.Current.MainPage.DisplayAlert("Alert", "Current side should be less than total number of sides.", "OK");
            }
            else
            {
                int result = die.rollDie();
                ResultValue = result.ToString();
                OnPropertyChanged(nameof(ResultValue));
            }
        }

        void name_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            string name = ((Entry)sender).Text;
            die.setName(name);
        }

        void sides_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            int sides = int.Parse(((Entry)sender).Text);
            die.setTotalSides(sides);
        }

        void currentSide_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            int current = int.Parse(((Entry)sender).Text);
            die.setCurrentSide(current);
        }
    }
}

