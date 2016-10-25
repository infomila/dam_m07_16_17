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

namespace App1
{
    public sealed partial class Gauge : UserControl
    {
        public Gauge()
        {
            this.InitializeComponent();
            

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform r = (RotateTransform)canvasAgulla.RenderTransform;

            //  RotateTransform r1 = new RotateTransform();

            r.Angle++;
           // recAgulla.RenderTransform = r1;
        }



        public int Angle
        {
            get { return (int)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value);
                RotateTransform r = (RotateTransform)canvasAgulla.RenderTransform;

               r.Angle = value;
            }
        }

        // Using a DependencyProperty as the backing store for Angle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register("Angle", typeof(int), typeof(Gauge), new PropertyMetadata(0));


    }
}
