using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EseQLite.View
{
    
    class AlternateStyleSelector : StyleSelector
    {
        private static long num = 0;

        public Style EvenStyle { get; set; }
        public Style OddStyle { get; set; }


        protected override Style SelectStyleCore(object item, DependencyObject container)
        {
           // ListViewItem lvItem = (ListViewItem)container;
            //ListView listView = ItemsControl.ItemsControlFromItemContainer(lvItem) as ListView;

            // Get the index of a ListViewItem

           // int index = listView.IndexFromContainer(lvItem); //listView.ItemContainerGenerator.IndexFromContainer(lvItem);
            //int indexBIS = listView.IndexFromContainer(item);
            num++;
            if (num % 2 == 0)
            {
                return EvenStyle;
            }
            else
            {
                return OddStyle;
            }

        }
    }
}
