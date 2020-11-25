using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElemendidPanchenko
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TTS : ContentPage
    {
        float Volume_;
        float Pitch_;
        public TTS()
        {
            InitializeComponent();
        }

        private async void speek_Clicked(object sender, EventArgs e)
        {
            SpeechOptions settings = new SpeechOptions() //настройки голоса
            {
                Volume = Volume_, //громкость
                Pitch = Pitch_, //тон

            };
            if (text.Text != null)
            {
                await TextToSpeech.SpeakAsync(text.Text, settings); //перевод текста в речь
            }
            else if (text.Placeholder != null)
            {
                await TextToSpeech.SpeakAsync(text.Placeholder, settings);
            }
        }

        private void peetch_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Pitch_ = (float)peetch.Value;
        }

        private void voolume_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Volume_ = (float)voolume.Value;
        }
    }
}
