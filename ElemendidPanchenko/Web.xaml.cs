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
    public partial class Web : ContentPage
    {
        public Web()
        {
            InitializeComponent();
            Browser.Source = "https://www.tthk.ee/";
        }
    }
}