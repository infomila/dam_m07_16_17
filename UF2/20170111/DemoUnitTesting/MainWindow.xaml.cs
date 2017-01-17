using DemoUnitTesting.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoUnitTesting
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Persona> persones = new List<Persona>();

            persones.Add(new Persona("11111111H", "Paco", "Jones", DateTime.Now));
            persones.Add(new Persona("11111112H", "Raquel", "Jones", DateTime.Now));
            persones.Add(new Persona("11111113H", "Maria", "Jones", DateTime.Now));

            dtgPersones.ItemsSource = persones;

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
             txtNom.Text =  ((Persona)dtgPersones.SelectedItem).Nom;
        }
    }
}
