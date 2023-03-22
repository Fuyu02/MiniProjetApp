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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BddpersonnelContext;
using biblioBDDPersonels1;


namespace AppliWPF_BDD_Personels
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CBDDPersonels1 bddPersonels=null;
        public MainWindow()
        {
            InitializeComponent();
            bddPersonels= new CBDDPersonels1();
            List<Service> services=bddPersonels.GetAllServices();
            LbServices.ItemsSource = services;
            CBxTypeRecherche.Items.Add("Type"); // le rendre invisible
            CBxTypeRecherche.Items.Add("Nom");
            CBxTypeRecherche.Items.Add("Prénom");
            CBxTypeRecherche.Items.Add("Fonction");
            CBxTypeRecherche.Items.Add("Service");
        }




        /*private void FermerApp(object sender, RoutedEventArgs e)
        {
            //fermer l'application
            Application.Current.Shutdown();
        }*/

        private void Trier(object sender, RoutedEventArgs e)
        {
            //bouton trier qui ouvre la fenêtre de tri(pas moi qui gère)
        }

        private void Connexion(object sender, RoutedEventArgs e)
        {
            //bouton qui ouvre une fenêtre de connexion, après connexion en gestionnaire n'apparait plus
            WinConnexion Login= new WinConnexion();
            Login.ShowDialog();
        }

        private void Rechercher(object sender, RoutedEventArgs e)
        {
            //prend le contenu de la textbox pour faire la recherche (le reste pas moi)
        }




        //pour le menu
        //mode alignement menu
        // pas validé fait rien
        // on peut faire la visibilité et définir quand le rendre visible
    }
}
