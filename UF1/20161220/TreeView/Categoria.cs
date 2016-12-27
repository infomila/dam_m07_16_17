using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    class Categoria
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public int? ParentId { get; set; }

        private static List<Categoria> _categories;

        public static List<Categoria> getCategories()
        {
            if (_categories == null) {
                _categories = new List<Categoria>();
                _categories.Add(new Categoria() { Id = 0,  Nom = "Arrel", ParentId = null });
                _categories.Add( new Categoria() {Id=1,      Nom="Home", ParentId=0 } );
                _categories.Add(new Categoria() { Id = 2,      Nom = "Roba", ParentId = 1 });
                _categories.Add(new Categoria() { Id = 3,          Nom = "Camises", ParentId = 2 });
                _categories.Add(new Categoria() { Id = 4,          Nom = "Jaquetes", ParentId = 2 });
                _categories.Add(new Categoria() { Id = 5,              Nom = "Estiu", ParentId = 4 });
                _categories.Add(new Categoria() { Id = 6,              Nom = "Hivern", ParentId = 4 });
                _categories.Add(new Categoria() { Id = 7,    Nom = "Dona", ParentId = 0 });
                _categories.Add(new Categoria() { Id = 8,      Nom = "Pantalons", ParentId = 7 });
            }
            return _categories;
        }

    }
}
