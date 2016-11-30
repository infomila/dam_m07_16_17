using Cinema.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Cinema
{
    public sealed partial class ControlButaca : UserControl
    {
        public ControlButaca()
        {
            this.InitializeComponent();

            this.RegisterPropertyChangedCallback(
                ControlButaca.OcupadaProperty,
                new DependencyPropertyChangedCallback(ChangeState));

            
            Binding bg = new Binding();
            bg.Path = new PropertyPath("Ocupada");
            this.SetBinding(ControlButaca.OcupadaProperty, bg);

        }


        private  void ChangeState(DependencyObject obj, DependencyProperty pr)
        {
            if (MyButaca.Ocupada == TipusOcupacio.LLIURE)
            {
                grid.Background = new SolidColorBrush(Colors.Green);
            }
            else if (MyButaca.Ocupada == TipusOcupacio.OCUPADA)
            {
                grid.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                grid.Background = new SolidColorBrush(Colors.Yellow);

            }
        }

        public Butaca MyButaca
        {
            get { return (Butaca)GetValue(MyPropertyProperty); }
            set {
                SetValue(MyPropertyProperty, value);
                    DataContext = value ;
            }
        }
        

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyButaca", typeof(Butaca), typeof(ControlButaca), 
                new PropertyMetadata(null));





        private TipusOcupacio Ocupada
        {
            get { return (TipusOcupacio)GetValue(OcupadaProperty); }
            set { SetValue(OcupadaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Ocupada.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OcupadaProperty =
            DependencyProperty.Register("Ocupada", typeof(TipusOcupacio), typeof(ControlButaca), new PropertyMetadata(0));



    }
}
