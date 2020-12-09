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
    //public partial class MagnetometerTest : ContentPage
    //{
    //    public MagnetometerTest()
    //    {
    //        InitializeComponent();
    //    }
    //}
    public partial class MagnetometerTest
    {
        // Set speed delay for monitoring changes.
        SensorSpeed speed = SensorSpeed.UI;

        public MagnetometerTest()
        {
            // Register for reading changes.
            Magnetometer.ReadingChanged += Magnetometer_ReadingChanged;
        }

        void Magnetometer_ReadingChanged(object sender, MagnetometerChangedEventArgs e)
        {
            var data = e.Reading;
            // Process MagneticField X, Y, and Z
            //dat.Text = $"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z: {data.MagneticField.Z}";
            Console.WriteLine($"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z: {data.MagneticField.Z}");
        }

        public void ToggleMagnetometer()
        {
            try
            {
                if (Magnetometer.IsMonitoring)
                    Magnetometer.Stop();
                else
                    Magnetometer.Start(speed);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        private void get_Clicked(object sender, EventArgs e)
        {
            //var data = e.Reading;
            //// Process MagneticField X, Y, and Z
            //dat.Text = $"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z: {data.MagneticField.Z}";
            //Console.WriteLine($"Reading: X: {data.MagneticField.X}, Y: {data.MagneticField.Y}, Z: {data.MagneticField.Z}");
        }
    }
}