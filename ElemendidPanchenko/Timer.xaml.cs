using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ElemendidPanchenko
{

    public partial class Timer : ContentPage
    {
        string[] hard = new string[] { "Ford Mustang", "Chevrolette Mustang", "Dodge Challenger" };
        public Timer()
        {
            InitializeComponent();
            hardware.ItemsSource = hard;
            hardware.SelectedIndexChanged += Hardware_SelectedIndexChanged;
        }

        private void Hardware_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (hardware.SelectedIndex)
            {
                case 0:
                    mustang.IsVisible = true;
                    ford.IsVisible = true;
                    camaro.IsVisible = false;
                    chevrolet.IsVisible = false;
                    challenger.IsVisible = false;
                    dodge.IsVisible = false;
                    break;
                case 1:
                    mustang.IsVisible = false;
                    ford.IsVisible = false;
                    camaro.IsVisible = true;
                    chevrolet.IsVisible = true;
                    challenger.IsVisible = false;
                    dodge.IsVisible = false;
                    break;
                case 2:
                    mustang.IsVisible = false;
                    ford.IsVisible = false;
                    camaro.IsVisible = false;
                    chevrolet.IsVisible = false;
                    challenger.IsVisible = true;
                    dodge.IsVisible = true;
                    break;
            }
        }
    }
}