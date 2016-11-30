using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    public enum TipusOcupacio
    {
        OCUPADA,
        LLIURE,
        SELECCIONADA
    }
    public class Butaca : INotifyPropertyChanged
    {
        public Butaca( string pDesc, TipusOcupacio pOcupada, TipusButaca pTipusButaca)
        {
            Desc = pDesc;
            Ocupada = pOcupada;
            Tipus = pTipusButaca;
        }
        #region Propietats
        private string mDesc;
        /// <summary>
        /// Descripcíó de la butaca. Per exemple:
        /// "F1 -B7"
        /// </summary>
        public string Desc
        {
            get { return mDesc; }
            set { mDesc = value; }
        }


        public string DescExtraSuperDuper
        {
            get { return mDesc + " - " + Tipus.Preu; }
        }


        //------------------------------------
        private TipusOcupacio mOcupada;

        public TipusOcupacio Ocupada
        {
            get { return mOcupada; }
            set { mOcupada = value;
                OnPropertyChanged("Ocupada");
            }
        }
        //------------------------------------
        private TipusButaca mCodiTipus;

        public event PropertyChangedEventHandler PropertyChanged;

        public TipusButaca Tipus
        {
            get { return mCodiTipus; }
            set { mCodiTipus = value; }
        }
        #endregion

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
