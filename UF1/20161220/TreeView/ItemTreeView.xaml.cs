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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace TreeView
{
    public sealed partial class ItemTreeView : UserControl
    {
        public ItemTreeView(ArbreView pArbre)
        {
            this.InitializeComponent();
            Arbre = pArbre;
        }

        public ArbreView Arbre { get; set; }


        public Node UnNode
        {
            get { return (Node)GetValue(UnNodeProperty); }
            set { SetValue(UnNodeProperty, value);
                if(value!=null)
                {
                    DataContext = value;
                    btnCategoria.Content = UnNode.Valor;
                    btnPlegar.Content = UnNode.EsFulla() ? "" : ">";
                    foreach(Node fill in UnNode.Fills)
                    {
                        ItemTreeView itv = new ItemTreeView(Arbre);
                        itv.UnNode = fill;
                        stkPanelFills.Children.Add(itv);
                    }
                }
            }
        }

        // Using a DependencyProperty as the backing store for UnNode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnNodeProperty =
            DependencyProperty.Register("UnNode", typeof(Node), typeof(ItemTreeView), new PropertyMetadata(null));

        private void btnPlegar_Click(object sender, RoutedEventArgs e)
        {
            if(UnNode.Desplegat)
            {
                stkPanelFills.Visibility = Visibility.Collapsed;
            } else
            {
                stkPanelFills.Visibility = Visibility.Visible;
            }
            UnNode.Desplegat = !UnNode.Desplegat;
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            //UnNode.Selected = !UnNode.Selected;
            Arbre.SelectedItem = UnNode;
        }
    }
}
