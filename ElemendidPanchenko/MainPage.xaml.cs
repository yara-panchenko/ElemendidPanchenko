using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElemendidPanchenko
{
    public partial class MainPage : ContentPage
    {
        StackLayout stack = new StackLayout();
        List<Button> buttons = new List<Button>();
        public MainPage()
        {

            for (int i = 0; i < 9; i++)
            {
                Button btn = new Button()
                {
                    Text = $"Page {i}"
                };
                buttons.Add(btn);
                stack.Children.Add(btn);
            }
            Content = stack;
            buttons[0].Text = "Entry";
            buttons[0].Clicked += MainPage_Clicked0;
            buttons[1].Text = "Picker";
            buttons[1].Clicked += MainPage_Clicked1;
            buttons[2].Text = "DateTime (current)";
            buttons[2].Clicked += MainPage_Clicked2;
            buttons[3].Text = "TextToSpeech";
            buttons[3].Clicked += MainPage_Clicked3;
            buttons[4].Text = "Map";
            buttons[4].Clicked += MainPage_Clicked4;
            buttons[5].Text = "Phone";
            buttons[5].Clicked += MainPage_Clicked5;
            buttons[6].Text = "Converter";
            buttons[6].Clicked += MainPage_Clicked6;
            buttons[7].Text = "Browser";
            buttons[7].Clicked += MainPage_Clicked7;
            buttons[8].Text = "Magnet";
            buttons[8].Clicked += MainPage_Clicked8;
        }

        private async void MainPage_Clicked8(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagnetometerTest());
        }

        private async void MainPage_Clicked7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Web());
        }
        private async void MainPage_Clicked6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Converti());
        }
        private async void MainPage_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Phone());
        }
        private async void MainPage_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Map());
        }

        private async void MainPage_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TTS());
        }

        private async void MainPage_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tanapaev());
        }

        private async void MainPage_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }

        private async void MainPage_Clicked0(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hardware());
        }
    }
}
