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
using BddpersonnelContext;
using biblioBDDPersonels1;
using System.Data.SqlClient;

namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour WinDeconnexion.xaml
    /// </summary>
   
    public partial class WinDeconnexion : Window
    {
        private CBDDPersonels1 bddPersonels = null;
        public WinDeconnexion()
        {
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {

            //ferme la fenêtre
            this.Close();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {

            //se décnnecter et reviens à un utilisateur classique
            bddPersonels = new CBDDPersonels1();
            try
            {
                this.DialogResult = false;
                //faire une fonction dans la main wi
            }
            catch (Exception ex)
            {
                throw ex;
            }


            this.Close();
        }
    }
}
