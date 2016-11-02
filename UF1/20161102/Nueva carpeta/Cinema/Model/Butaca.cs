using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    class Butaca
    {
        public Butaca( string pDesc, bool pOcupada, int pCodiTipusButaca)
        {
            Desc = pDesc;
            Ocupada = pOcupada;
            Tipus = pCodiTipusButaca;
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
        //------------------------------------
        private bool mOcupada;

        public bool Ocupada
        {
            get { return mOcupada; }
            set { mOcupada = value; }
        }
        //------------------------------------
        private int mCodiTipus;

        public int Tipus
        {
            get { return mCodiTipus; }
            set { mCodiTipus = value; }
        }
        #endregion
    }
}
