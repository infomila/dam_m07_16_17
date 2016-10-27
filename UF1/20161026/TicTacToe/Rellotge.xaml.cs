using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TicTacToe
{
    public sealed partial class Rellotge : UserControl
    {
        public Rellotge()
        {
            this.InitializeComponent();
        }






        public DateTime Hora
        {
            get { return (DateTime)GetValue(HoraProperty); }
            set {
                SetValue(HoraProperty, value);

                int correccioPatillera = 90;
                double angleMinuts = value.Minute * 360 / 60 - correccioPatillera;
                RotateTransform t = (RotateTransform)pMinuts.RenderTransform;
                t.Angle = angleMinuts;

                double angleSegons = value.Second * 360 / 60 - correccioPatillera;
                t = (RotateTransform)pSegons.RenderTransform;
                t.Angle = angleSegons;

                double angleHora = (value.Hour % 12) * 360 / 12  - correccioPatillera;
                t = (RotateTransform)pHores.RenderTransform;
                t.Angle = angleHora;
            }
        }

        // Using a DependencyProperty as the backing store for Hora.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HoraProperty =
            DependencyProperty.Register("Hora", typeof(DateTime), typeof(Rellotge), new PropertyMetadata(DateTime.Now));

     

    }
}
