using BddpersonnelContext;
using biblioBDDPersonels1;
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

namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour AjouterServices.xaml
    /// </summary>
    public partial class AjouterServices : Window
    {
        private CBDDPersonels1 bddPersonels = null;

        public AjouterServices()
        {
            InitializeComponent();
            bddPersonels = new CBDDPersonels1();

        }

        private void Fermer(object sender, RoutedEventArgs e)
        {
            //ferme la fenêtre
            this.Close();
        }

        private void AjouterService(object sender, RoutedEventArgs e)
        {
            //enregistre et ajoute le service dans la bdd
            try
            {
                if (TxtBAjService.Text != "") {
                    Service service = new Service();
                    service .Intitule= TxtBAjService.Text;
                    bddPersonels.Ajoutservice(service);
                    this.Close ();
                }
                
            }
            catch(Exception ex) {
                throw ex;
            }   

        }
    }
}
