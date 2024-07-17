using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Forms.Carre
{
    /// <summary>
    /// on veut afficher que des carre pure 100%carre
    /// cad on veut avoire une collection personnaliser pour cela on vas cree cette classe qui vas implementer Ilist est on vas gerer ses methode 
    /// </summary>
    public  class ListCarre : IList<Carre> 
    {
        private readonly List<Carre> carreList = new List<Carre>(20);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Carre this[int index] {
            get => ((IList<Carre>)carreList)[index];
            set
            {
                ///
                /// gettype.name c'est le nom de l'objet courant que on vas crée 
                /// throw pour declanché une erreur 
                /// value elle est pres definer dans le seteur 
                /// 

                if( value.GetType().Name != "carre ") throw new ArgumentException("carré seulement");
            } 
        }

        public int Count => ((ICollection<Carre>)carreList).Count;

        public bool IsReadOnly => ((ICollection<Carre>)carreList).IsReadOnly;
        /// <summary>
        /// acces et modification des element par index (entier)
        /// </summary>
        /// <param name="item">position du carre dans la liste</param>
        /// return carre de la position donnée 
        /// <exception cref="ArgumentException">si mon objet est de classe fille de carrer </exception>
        public void Add(Carre item)
        {
            if (item.GetType().Name != "carre ") throw new ArgumentException("carré seulement");
            carreList.Add(item);

        }

        public void Clear()
        {
            ((ICollection<Carre>)carreList).Clear();
        }

        public bool Contains(Carre item)
        {
            return ((ICollection<Carre>)carreList).Contains(item);
        }
        /// <summary>
        /// 
        /// copie tableau dans une liste 
        /// </summary>
        
        public void CopyTo(Carre[] array, int arrayIndex)
        {
            if ( array.Any(x=>x.GetType().Name != "carre "))
                throw new ArgumentException("carré seulement");
            ((ICollection<Carre>)carreList).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Carre> GetEnumerator()
        {
            return ((IEnumerable<Carre>)carreList).GetEnumerator();
        }

        public int IndexOf(Carre item)
        {
            return ((IList<Carre>)carreList).IndexOf(item);
        }

        /// <summary>
        /// inserer le new carre dans la liste 
        /// 
        /// 
        /// </exception>
        public void Insert(int index, Carre item)
        {
            if (item.GetType().Name != "carre ") throw new ArgumentException("carré seulement");
            ((IList<Carre>)carreList).Insert(index,item);
        }

        public bool Remove(Carre item)
        {
            return ((ICollection<Carre>)carreList).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Carre>)carreList).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)carreList).GetEnumerator();
        }
    }
}
