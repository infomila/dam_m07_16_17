using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    class ConversorArbre
    {
        public static Node ConvertirArbre(List<Categoria> llista)
        {
            // Busquem la categoria arrel i creem el node arrel
            foreach (Categoria c in llista)
            {
                if (c.ParentId == null)
                {
                    Node arrel = new TreeView.Node(c.Id, c.Nom);
                    muntarNodeAmbPare(arrel, llista);
                    return arrel;
                }
            }
            return null;
        }

        private static void muntarNodeAmbPare(Node nodePare, List<Categoria> llista)
        {            
            // busquem els elements de la llista que tenen com 
            // a pare el Id
            foreach(Categoria c in llista)
            {
                if(c.ParentId == nodePare.Id) {
                    // per cada element de la llista que trobi, muntarem el node usant-lo
                    // a ell com a pare
                    Node fill = new TreeView.Node(c.Id, c.Nom, nodePare);

                    muntarNodeAmbPare(fill, llista);
                    // afegirem els nodes com a fills del node actual                    
                }
            }                        
        }
    }
}
