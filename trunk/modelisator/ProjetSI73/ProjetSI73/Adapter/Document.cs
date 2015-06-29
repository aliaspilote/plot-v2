using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Adapter
{
    public interface Document
{
  string contenu { set; }
  void dessine();
  void imprime();
}

}
