﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modelisator.View
{
    /// <summary>
    /// Logique d'interaction pour ModelisatorFram_View_UserControl.xaml
    /// </summary>
    public partial class ModelisatorFram_View_UserControl : UserControl
    {
        public ModelisatorFram_View_UserControl()
        {
            InitializeComponent();
        }

        
        public Grid PapierpeintGrid
        {
            get { return m_PapierpeintGrid; }
            set { m_PapierpeintGrid = value; }
        }

        public Grid MenuTop_ContentPanel
        {
            get { return m_MenuTop_ContentPanel; }
            set { m_MenuTop_ContentPanel = value; }
        }

        public Grid ProduitChoix_ContentPanel
        {
            get { return m_ProduitChoix_ContentPanel; }
            set { m_ProduitChoix_ContentPanel = value; }
        }

        public Grid Info_ContentPanel
        {
            get { return m_Info_ContentPanel; }
            set { m_Info_ContentPanel = value; }
        }

        public Grid EspaceTravail_ContentPanel
        {
            get { return m_EspaceTravail_ContentPanel; }
            set { m_EspaceTravail_ContentPanel = value; }
        }
        
    }
}
