using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace EditorArticles.ViewModel
{
    [ImplementPropertyChanged]
    public class EditorArticlesViewModel
    {
        public EditorArticlesViewModel()
        {

            Articles = new ObservableCollection<ArticleViewModel>();
            Articles.Add(new ArticleViewModel() {
                Color = "#ff00ff00",
                Descripcio = "El meu primer article",
                Nom = "ARTICULISSIM",
                Icona = 2 });
            Articles.Add(new ArticleViewModel()
            {
                Color = "#ffffee00",
                Descripcio = "El meu segon article",
                Nom = " IS BACK",
                Icona = 1
            });
        }


        public ObservableCollection<ArticleViewModel> Articles { get; set; }

        public ArticleViewModel ArticleSelected { get; set; }



        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ArticleSelected!=null) ArticleSelected.Nom = "KAKA";
        }
    }
}
