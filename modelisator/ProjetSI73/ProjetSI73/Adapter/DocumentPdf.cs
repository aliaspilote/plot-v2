using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSI73.Adapter
{
    public class DocumentPdf : Document
    {
        protected ComposantPdf outilPdf = new ComposantPdf();

        public string contenu
        {
            set
            {
                outilPdf.pdfFixeContenu(value);
            }
        }

        public void dessine()
        {
            outilPdf.pdfPrepareAffichage();
            outilPdf.pdfRafraichit();
            outilPdf.pdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.pdfEnvoieImprimante();
        }
    }
}
