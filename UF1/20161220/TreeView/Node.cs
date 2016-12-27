using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace TreeView
{
    [ImplementPropertyChanged]
    public class Node
    {
        public int? Id { get; set; }

        public string Valor { get; set; }

        public List<Node> Fills { get; set; }

        public bool Desplegat { get; set; }

        public int Nivell { get; set; }


        public bool Selected { get; set; }

        public SolidColorBrush SelectionColor
        {
            get
            {
                if (Selected) return new SolidColorBrush(Colors.Lime);
                return new SolidColorBrush(Colors.Transparent);
            }
        }
        public Node( int pId, string pValor)
        {
            Id = pId;
            Valor = pValor;
            Fills = new List<Node>();
            Nivell = 0;
            Desplegat = true;
        }

        public Node( int pId, string pValor, Node pPare): this(pId,pValor)
        {
            pPare.Fills.Add(this);
            Nivell = pPare.Nivell + 1;
        }



        public bool EsFulla()
        {
            return Fills.Count == 0;
        }


        override public string ToString()
        {
            string s = EspaisPerNivell() + $"{Id}>{Valor}\n";
            foreach (Node fill in Fills) {
                s +=  fill.ToString();
            }
            return s;                     

        }

        public string EspaisPerNivell()
        {
            string s = "";
            for(int i=0;i<Nivell;i++)
            {
                s += " ";
            }
            return s;
        }
    }
}
