using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace EseQLite.View
{
    public sealed partial class DataGridView : UserControl
    {

        public event EventHandler SelectionChanged;


        public DataGridView()
        {
            this.InitializeComponent();
            
        }

        public List<string> HiddenProps{ get; set; }
        public Dictionary<String, String> ColumnNames { get; set; }
        public List<string> ColumnOrder { get; set; }



        /// <summary>
        /// ]
        /// </summary>
        /// <param name="myPropertyInfo"></param>
        /// <param name="pIsHeader"></param>
        /// <returns></returns>
        public DataTemplate Create(PropertyInfo[] myPropertyInfo, bool pIsHeader)
        {
            if (ColumnOrder != null)
            {
                List<PropertyInfo> ordered = new List<PropertyInfo>();
                List<PropertyInfo> unordered = new List<PropertyInfo>();
                for (int i = 0; i < myPropertyInfo.Length; i++)
                {

                    if (ColumnOrder.IndexOf(myPropertyInfo[i].Name) >= 0)
                    {
                        ordered.Add(myPropertyInfo[i]);
                    }
                    else
                    {
                        unordered.Add(myPropertyInfo[i]);
                    }
                }
                ordered = ordered.OrderBy(item => ColumnOrder.IndexOf(item.Name)).ToList<PropertyInfo>();

                ordered.AddRange(unordered);
                myPropertyInfo = ordered.ToArray<PropertyInfo>();
                
            }

            StringBuilder sb = new StringBuilder();
            string text;
            sb.AppendLine("<DataTemplate xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" ");
            sb.AppendLine("xmlns:local=\"using:EseQLite.View\"  >");
            if (pIsHeader)
                sb.AppendLine("<Grid Height=\"30\">");
            else
                sb.AppendLine("<Grid>");
            sb.AppendLine(" <Grid.ColumnDefinitions>");
            for (int i = 0; i < myPropertyInfo.Length; i++){
                if (HiddenProps==null || !HiddenProps.Contains(myPropertyInfo[i].Name))
                {
                    sb.AppendLine("       <ColumnDefinition Width=\"*\" ></ColumnDefinition >");
                }
            }
            sb.AppendLine(" </Grid.ColumnDefinitions >");
            int col = 0;
            for (int i = 0; i < myPropertyInfo.Length; i++) {
                if (HiddenProps == null || !HiddenProps.Contains(myPropertyInfo[i].Name))
                {
                    string text1, text2;
                    text1 = text2 = text = "";
                    if (pIsHeader)
                    {
                        text = " Background=\"" + HeaderColor.ToString() + "\" ";
                    }
                    sb.AppendLine("<Border Padding=\"3\"" + text + " BorderThickness = \"1\" BorderBrush = \"Black\" Grid.Column = \"" + col + "\" >");
                    if (pIsHeader)
                    {
                        if (ColumnNames == null || !ColumnNames.ContainsKey(myPropertyInfo[i].Name))
                        {
                            text1 = " Text = \"" + myPropertyInfo[i].Name + "\" ";
                        } else {
                            text1= " Text = \""+ColumnNames[myPropertyInfo[i].Name]+"\" ";
                        }
                    }
                    else
                    {
                        string extraBinding = "";
                        if(myPropertyInfo[i].PropertyType.Equals(typeof(DateTime?)))
                        {
                            extraBinding = @"
                                <Binding.Converter>
                                        <local:DateConverter></local:DateConverter>
                               </Binding.Converter> ";
                        }
                        text2 = @"
                        <TextBlock.Text>
                            <Binding>
                                <Binding.Path>
                                    " + myPropertyInfo[i].Name + @"
                                </Binding.Path>
                                <Binding.Mode>OneWay</Binding.Mode>
                               "+ extraBinding + @"
                            </Binding> 
                        </TextBlock.Text>
                           ";
                    }
                    sb.AppendLine("<TextBlock "+ text1 +  " VerticalAlignment=\"Center\" HorizontalAlignment =\"Left\" >"+text2+"</TextBlock >");
                    sb.AppendLine("</Border>");
                    col++;
                }
            }
            sb.AppendLine("</Grid>");
            sb.AppendLine("</DataTemplate>");


            string xaml = sb.ToString();

            return XamlReader.Load(xaml) as DataTemplate;
        }


        public object ItemSource
        {
            get { return GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value);
                if (value != null)
                {
                    if (value.GetType().FullName.StartsWith("System.Collections.Generic.List"))
                    {
                        Type t = value.GetType().GenericTypeArguments[0];
                        PropertyInfo[] myPropertyInfo = t.GetProperties();
                        
                        lsvMain.ItemTemplate = Create(myPropertyInfo, false);
                        lsvMain.HeaderTemplate = Create(myPropertyInfo, true);
                    }
                }

            }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(object), typeof(DataGridView), new PropertyMetadata(null));



        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedItem.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(DataGridView), new PropertyMetadata(null));


        public Color HeaderColor
        {
            get { return (Color)GetValue(HeaderColorProperty); }
            set { SetValue(HeaderColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderColorProperty =
            DependencyProperty.Register("HeaderColor", typeof(Color), typeof(DataGridView), new PropertyMetadata(Colors.LightGray));

        private void lsvMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, null);

        }
    }
}
