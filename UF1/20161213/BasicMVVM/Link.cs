using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM
{
    class Link : INotifyPropertyChanged
    {
        private int mEstat;

        public int Estat
        {
            get { return mEstat; }
            set { mEstat = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Estat"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
