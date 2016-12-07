using EseQLite.Db;
using EseQLite.Model;
using EseQLite.View;
using EseQLite.ViewModel;
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

namespace EseQLite
{
    /// <summary>
    /// Pàgina de gestió d'hotels
    /// </summary>
    public sealed partial class MainPage : Page
    {



         

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        public MainPageViewModel ViewModel { get; set; }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            MainPageViewModel mpvm = new MainPageViewModel();
            this.DataContext = mpvm;
            ViewModel = mpvm;

            /*
            HotelDB edb = new HotelDB();
            lsvHotels.ItemsSource = HotelDB.getHotels();

            Mode = ModeEnum.VIEW;
            seleccionaPrimerHotel();
            updateBotoEntrada();*/
        }
        /*
        private void lsvHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mostraSeleccio();
        }

        private void mostraSeleccio()
        {

            Hotel h = (Hotel)lsvHotels.SelectedItem;
            if (h != null)
            {
                enableTextChanged(false);
                txtCodi.Text = h.Codi.ToString();
                txtName.Text = h.Nom;
                txtPoblacio.Text = h.Poblacio;
                enableTextChanged(true);
                Mode = ModeEnum.VIEW;
                dgvEntrades.HiddenProps = new List<string> {"NIF","NomClient", "DataEntrada" ,"Codi"};
                dgvSortides.HiddenProps = new List<string> { "Capacitat", "Codi" };
                dgvEntrades.ColumnNames = new Dictionary<string, string> {
                    { "Num", "Número"} };
                dgvSortides.ColumnNames = new Dictionary<string, string> {
                    { "Num", "Número"} ,
                    { "DataEntrada", "Data d'entrada"} ,
                    { "NomClient", "Client"}
                };
                dgvSortides.ColumnOrder = new List<string> { "Num", "Planta"};
                dgvEntrades.ItemSource = HabitacioDB.getHabitacions(h.Codi, true);
                dgvSortides.ItemSource = HabitacioDB.getHabitacions(h.Codi, false);

            }
        }

        private void enableTextChanged(bool enable)
        {
            if(enable)
            {
                txtName.TextChanged += common_TextChanged;
                txtPoblacio.TextChanged += common_TextChanged;

                valida();
            }
            else
            {
                txtName.TextChanged -= common_TextChanged;
                txtPoblacio.TextChanged -= common_TextChanged;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Hotel h = null;
            if (Mode == ModeEnum.MODIFIED)
            {
                HotelDB.updateData(Int32.Parse(txtCodi.Text), txtName.Text, txtPoblacio.Text);
                h = (Hotel)lsvHotels.SelectedItem;
                h.Nom = txtName.Text;
                h.Poblacio = txtPoblacio.Text;
            }
            else
            {
                HotelDB.insertData(txtName.Text, txtPoblacio.Text);

            }


            // Actualitza la llista.
            lsvHotels.ItemsSource = HotelDB.getHotels();

            if (Mode == ModeEnum.NEW)
            {
                // Selecciona l'últim de la llista ( l'acabem d'inserir )
                Hotel ultimHotel = ((List<Hotel>)lsvHotels.ItemsSource).Last<Hotel>();
                lsvHotels.SelectedItem = ultimHotel;
                
            }
            else
            {
                // Busquem l'hotel que té el codi !!
                Hotel hotelSeleccionat = ((List<Hotel>)lsvHotels.ItemsSource).Find(ht => (ht.Codi == h.Codi));
                lsvHotels.SelectedItem = hotelSeleccionat;
            }
            Mode = ModeEnum.VIEW;
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            HotelDB.deleteData(((Hotel)lsvHotels.SelectedItem).Codi);

            lsvHotels.ItemsSource = HotelDB.getHotels();
        }

        enum ModeEnum
        {
            VIEW, MODIFIED, NEW
        }

        ModeEnum mMode;
        ModeEnum Mode
        {
            get
            {
                return mMode;
            }
            set
            {
                mMode = value;
                btnSave.IsEnabled = btnCancel.IsEnabled = (Mode== ModeEnum.NEW || Mode== ModeEnum.MODIFIED);
                btnNew.IsEnabled = btnDelete.IsEnabled = (Mode == ModeEnum.VIEW  );
                 
            }
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Mode = ModeEnum.NEW;
            enableTextChanged(false);
            txtCodi.Text = "<new>";
            txtName.Text = "";
            txtPoblacio.Text = "";
            enableTextChanged(true);
        }

        private void common_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Mode == ModeEnum.VIEW)
            {
                Mode = ModeEnum.MODIFIED;
            }
            valida();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == ModeEnum.NEW)
            {
                seleccionaPrimerHotel();
            }
            else
            {
                // refresca les dades amb les originals.
                mostraSeleccio();
            }
            
            
        }

        private void seleccionaPrimerHotel()
        {
            lsvHotels.SelectedItem = ((List<Hotel>)lsvHotels.ItemsSource).First<Hotel>();
            mostraSeleccio();
        }

        private void valida()
        {
            bool hiHaErrors=false;

            hiHaErrors = validaCamp(hiHaErrors, txtName.Text, "Nom", txbErrNom);
            hiHaErrors = validaCamp(hiHaErrors, txtPoblacio.Text, "Poblacio", txbErrPob);
            // Només fem les validacions generals quan no hi ha errors individuals....no tindria sentit.
            if(!hiHaErrors)
            {
                string missatgeError;
                long? pCodiHotel = null;
                if (lsvHotels.SelectedItem != null)
                {
                    pCodiHotel = ((Hotel)lsvHotels.SelectedItem).Codi;
                }
                if (!Hotel.validaGeneral(pCodiHotel, txtName.Text, txtPoblacio.Text, out missatgeError))
                {
                    txbErrGeneric.Text = missatgeError;
                    hiHaErrors = true;
                } else
                {
                    txbErrGeneric.Text = "";
                }
            }
            btnSave.IsEnabled = !hiHaErrors;
        }

        private bool validaCamp(bool hiHaErrors, string textField, string propertyName, TextBlock errorTextBlock)
        {
            bool isOk;
            string errMsg;

            isOk = Hotel.valida(textField, out errMsg, propertyName);
            if (!isOk)
            {
                errorTextBlock.Text = errMsg;
                return true;
            }
            else
            {
                errorTextBlock.Text = "";
                return hiHaErrors;
            }
        }

        private void txbClientNIF_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateBotoEntrada();
        }

        private void updateBotoEntrada()
        {
            Client c = ClientDB.getClient(txbClientNIF.Text);
            if(c!=null)
            {
                txbClientName.Text = c.Nom;
            }
            bool potFerSortida = ( c!=null && dgvEntrades.SelectedItem!=null);
            btnEntrada.IsEnabled = true;// potFerSortida;
        }

        private void dgvEntrades_SelectionChanged(object sender, EventArgs e)
        {            
            updateBotoEntrada();
        }

        private void btnEntrada_Click(object sender, RoutedEventArgs e)
        {
            Habitacio h = ((Habitacio)dgvEntrades.SelectedItem);
            HabitacioDB.ocupaHabitacio(h.Codi, h.Num, txbClientNIF.Text, DateTime.Now);
            dgvEntrades.ItemSource = HabitacioDB.getHabitacions(h.Codi, true);
            dgvSortides.ItemSource = HabitacioDB.getHabitacions(h.Codi, false);
        }

        private void btnSortida_Click(object sender, RoutedEventArgs e)
        {
            Habitacio h = ((Habitacio)dgvSortides.SelectedItem);
            HabitacioDB.alliberaHabitacio(h.Codi, h.Num);
            dgvEntrades.ItemSource = HabitacioDB.getHabitacions(h.Codi, true);
            dgvSortides.ItemSource = HabitacioDB.getHabitacions(h.Codi, false);
        }*/
    }
   

}
