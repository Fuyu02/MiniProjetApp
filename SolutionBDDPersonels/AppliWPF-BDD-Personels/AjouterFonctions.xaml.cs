using BddpersonnelContext;
using biblioBDDPersonels1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour AjouterFonctions.xaml
    /// </summary>
    public partial class AjouterFonctions : Window
    {
        private CBDDPersonels1 bddPersonels = null;
        public AjouterFonctions()
        {
            InitializeComponent();
            bddPersonels = new CBDDPersonels1();
            
        }

        private void AnnulerAjoutFclick(object sender, RoutedEventArgs e)
        {
            //ferme la fenêtre
            this.Close();
        }



        private void AjouterFonctionclick(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (TxtBNomFonction.Text != "") // et recherche si existe déjà dans la bdd
                {
                    Fonction fonction = new Fonction();
                    fonction = TxtBNomFonction.Text.ToString();
                    bddPersonels.Ajoutfonction(fonction);
                }
            }
            catch(Exception ex) {
                throw ex;
            }   
            
        }
    }
}
