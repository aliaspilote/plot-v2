using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Modelisator.Model;

namespace Modelisator.Forms.Model
{
    public class MenuTop_CouleursForm_Model
    {

        public Contexte Ctx;
        public MenuTop_CouleursForm_Model() { }
        public MenuTop_CouleursForm_Model(Contexte ctx)
        {
            Ctx = ctx;
            lesCouleurs = new List<PropertyInfo>();
            InitialiserListCouleur();
            CouleurBrush = new SolidColorBrush((Color) ColorConverter.ConvertFromString("LightBlue"));
        }

        public void InitialiserListCouleur()
        {
            Type colors = typeof(System.Drawing.Color);
            PropertyInfo[] colorInfo = colors.GetProperties(BindingFlags.Public |BindingFlags.Static);
            foreach (PropertyInfo info in colorInfo)
            {
                lesCouleurs.Add(info);
            }
        }

        public void laCouleurchoisie(PropertyInfo clr)
        {
            CouleurBrush = new SolidColorBrush((Color) ColorConverter.ConvertFromString(clr.Name)); 
        }

        public List<PropertyInfo> lesCouleurs { get; set; }

        private SolidColorBrush m_CouleurBrush;

        public SolidColorBrush CouleurBrush
        {
            get { return m_CouleurBrush; }
            set
            {
                m_CouleurBrush = value;
            }
        }

        public void RAZ_GP_valeur()
        {
            foreach (var GP in Produit.GrandeurPhysiques)
            {
                GP.Value.Valeur = 0;
                GP.Value.Entree = false;
                GP.Value.Calcule = false;
            }
        }




    }
}
