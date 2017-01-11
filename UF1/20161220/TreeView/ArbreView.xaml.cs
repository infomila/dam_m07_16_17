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

/// <summary>
/// <para></para>
/// <code lang="C#"><![CDATA[TreeView t = new TreeView();]]></code>
/// <list type="number">
///  <item>
///   <description>Primer</description>
///  </item>
///  <item>
///   <description>Segon</description>
///  </item>
///  <item>
///   <description>Tercer</description>
///  </item>
///  <item>
///   <description>Quart</description>
///  </item>
/// </list>
/// <para></para>
/// </summary>
/// <example>
/// <para></para>
/// <code lang="C#"><![CDATA[]]></code>
/// </example>
namespace TreeView
{
    /// <example>
    ///   <para />
    ///   <code lang="C#" source="../ArbreView.xaml.cs" region="prop" />
    /// </example>
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public sealed partial class ArbreView : UserControl
    {

        public event EventHandler SelectionChanged;

        public ArbreView()
        {
            this.InitializeComponent();


        }



 
        public Node Arrel
        {
            get { return (Node)GetValue(ArrelProperty); }
            set
            {
                SetValue(ArrelProperty, value);
                stkContenidorPrincipal.Children.Clear();
                mostrarNodeIDescendentsRecursiu(Arrel);
            }
        }

        // Using a DependencyProperty as the backing store for Arrel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArrelProperty =
            DependencyProperty.Register("Arrel", typeof(Node), typeof(ArbreView), new PropertyMetadata(null));

        private void mostrarNodeIDescendentsRecursiu(Node n)
        {
            ItemTreeView itv = new ItemTreeView(this);
            itv.UnNode = n;
            stkContenidorPrincipal.Children.Add(itv);
        }

 
        private void seleccionaActualNodeRecursiu(Node actual)
        {
            actual.Selected = (actual == SelectedItem);
            foreach (Node n in actual.Fills)
            {
                seleccionaActualNodeRecursiu(n);
            }
        }

        private void mostrarNodeIDescendents(Node n)
        {
            mostrarNode(n);
            if (n.Desplegat)
            {
                foreach (Node f in n.Fills)
                {
                    mostrarNodeIDescendents(f);
                }
            }
        }

        private void mostrarNode(Node n)
        {
            Grid g = new Grid();
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            Button btnDesplega = new Button();
            btnDesplega.Content = ">";
            btnDesplega.Tag = n;
            btnDesplega.Click += BtnDesplega_Click;
            TextBlock txtNode = new TextBlock();
            txtNode.Text = $"{n.EspaisPerNivell()}{n.Id}>{n.Valor}";
            sp.Children.Add(btnDesplega);
            sp.Children.Add(txtNode);
            g.Children.Add(sp);


            stkContenidorPrincipal.Children.Add(g);
        }

        private void BtnDesplega_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Node n = (Node)b.Tag;
            n.Desplegat = !n.Desplegat;
            stkContenidorPrincipal.Children.Clear();
            mostrarNodeIDescendents(Arrel);
        }




        public Node SelectedItem
        {
            get { return (Node)GetValue(SelectedItemProperty); }
            set
            {
                if (value != SelectedItem)
                {
                    SetValue(SelectedItemProperty, value);
                    SelectionChanged?.Invoke(this, new EventArgs());
                }
                seleccionaActualNodeRecursiu(Arrel);
            }
        }
        #region prop
        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(Node), typeof(ArbreView), new PropertyMetadata(null));

        #endregion

    }
}
