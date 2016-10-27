using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace EmployeeCardCustomControl
{
    public sealed partial class EmployeeCard : UserControl 
    {
        public EmployeeCard()
        {
            this.InitializeComponent();
        }



        public string Nom
        {
            get { return (string)GetValue(NomProperty); }
            set
            {
                 SetValue(NomProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Nom.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NomProperty =
            DependencyProperty.Register("Nom", typeof(string), typeof(EmployeeCard), 
                new PropertyMetadata(""/*, new PropertyChangedCallback(OnNameChanged)*/));

        /*private static void OnNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            EmployeeCard ec = (EmployeeCard)d;
            ec.txbName.Text = e.NewValue.ToString();
        }
        */
        //----------------------------------------------


        public string Desc
        {
            get { return (string)GetValue(DescProperty); }
            set { SetValue(DescProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for Desc.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescProperty =
            DependencyProperty.Register("Desc", typeof(string), typeof(EmployeeCard), 
                new PropertyMetadata(""));

        //----------------------------------------------




        public ImageSource Foto
        {
            get { return (ImageSource)GetValue(FotoProperty); }
            set { SetValue(FotoProperty, value);               
            }
        }

        // Using a DependencyProperty as the backing store for Foto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FotoProperty =
            DependencyProperty.Register("Foto", typeof(ImageSource), typeof(EmployeeCard), null);



    }
}
