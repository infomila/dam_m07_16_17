using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Cinema.Model
{
    public class TipusButaca
    {

        public TipusButaca( int pCodi, string pDesc, decimal pPreu, Color pColor)
        {
            Codi = pCodi;
            Desc = pDesc;
            Preu = pPreu;
            Color = pColor;
        }

        private int mCodi;

        public int Codi
        {
            get { return mCodi; }
            set { mCodi = value; }
        }

        private string mDesc;

        public string Desc
        {
            get { return mDesc; }
            set { mDesc = value; }
        }

        private decimal mPreu;

        public decimal Preu
        {
            get { return mPreu; }
            set { mPreu = value; }
        }

        private Color mColor;

        public Color Color
        {
            get { return mColor; }
            set { mColor = value; }
        }



    }
}
