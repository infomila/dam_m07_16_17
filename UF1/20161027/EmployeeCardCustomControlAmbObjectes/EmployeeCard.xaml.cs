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



        public Empleat Emp
        {
            get { return (Empleat)GetValue(EmpProperty); }
            set {
                SetValue(EmpProperty, value);

                //------------------------------------------
                // !IMPORTANT !!!!!
                //------------------------------------------
                /*
                        ,--. 
                       ([ oo] 
                        `- ^\
                      _  I`-'
                    ,o(`-V' 
                    |( `-H-'
                    |(`--A-'
                    |(`-/_\'\
                    O `'I ``\\ 
                    (\  I    |\,
                     \\-T-"`, |H    
                 */
                DataContext = value;
                //------------------------------------------
            }
        }

        // Using a DependencyProperty as the backing store for Emp.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EmpProperty =
            DependencyProperty.Register("Emp", 
                typeof(Empleat), 
                typeof(EmployeeCard), 
                new PropertyMetadata(null));


    }
}
