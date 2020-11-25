using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElemendidPanchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hardware : ContentPage
    {
        Entry MyEntry = new Entry();
        Entry MyEntry2 = new Entry();
        Entry MyEntry3 = new Entry();
        public Hardware()
        {
            MyEntry = new Entry { Text = "4" };
            MyEntry.Keyboard = Keyboard.Numeric;
            MyEntry.BackgroundColor = Color.White;
            MyEntry2 = new Entry { Text = "5" };
            MyEntry2.Keyboard = Keyboard.Numeric;
            MyEntry2.BackgroundColor = Color.White;
            MyEntry3 = new Entry { Text = "8" };
            MyEntry3.Keyboard = Keyboard.Numeric;
            MyEntry3.BackgroundColor = Color.White;

            MyEntry.TextChanged += MyEntry_TextChanged;
            MyEntry2.TextChanged += MyEntry_TextChanged;
            MyEntry3.TextChanged += MyEntry_TextChanged;


            StackLayout stack = new StackLayout
            {

            };
            stack.Children.Add(MyEntry);
            stack.Children.Add(MyEntry2);
            stack.Children.Add(MyEntry3);
            Content = stack;
        }
        private void MyEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            if (MyEntry.Text != null && MyEntry.Text != "")
            {
                R = int.Parse(MyEntry.Text);
            }
            if (MyEntry2.Text != null && MyEntry2.Text != "")
            {
                G = int.Parse(MyEntry2.Text);
            }
            if (MyEntry3.Text != null && MyEntry3.Text != "")
            {
                B = int.Parse(MyEntry3.Text);
            }
            BackgroundColor = Color.FromRgb(R, G, B);
        }
    }
}