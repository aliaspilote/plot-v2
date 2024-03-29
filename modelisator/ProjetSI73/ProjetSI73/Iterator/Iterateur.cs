﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Iterator
{
    public abstract class Iterateur<TElement> where TElement : Element
    {
        public string motCleRequete { protected get; set; }
        protected int index;
        public IList<TElement> contenu { protected get; set; }


        public void debut()
        {
            index = 0;
            int taille = contenu.Count;
            while ((index < taille) &&
              (!contenu[index].motCleValide(motCleRequete)))
                index++;
        }

        public void suivant()
        {
            int taille = contenu.Count;
            index++;
            while ((index < taille) &&
              (!contenu[index].motCleValide(motCleRequete)))
                index++;
        }

        public TElement item()
        {
            if (index < contenu.Count)
                return contenu[index];
            else
                return null;
        }
    }
}
