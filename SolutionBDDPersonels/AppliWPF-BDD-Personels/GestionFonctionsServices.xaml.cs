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
    /// Logique d'interaction pour GestionFonctionsServices.xaml
    /// </summary>
    public partial class GestionFonctionsServices : Window
    {
        private CBDDPersonels1 bddPersonels = null;
        public GestionFonctionsServices()
        {
            InitializeComponent();
            bddPersonels=new CBDDPersonels1();
            List<Service> services = bddPersonels.GetAllServices();
            List<Fonction> fonctions = bddPersonels.GetAllFonctions();
            LbServices.ItemsSource = services;
            LbFonctions.ItemsSource = fonctions;

        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        

        private void ouvrirAjservices(object sender, RoutedEventArgs e)
        {
            //ouvre la fenêtre d'ajout

            AjouterServices AjouterS = new AjouterServices();
            AjouterS.ShowDialog();

        }

        private void ouvrirAjfonctions(object sender, RoutedEventArgs e)
        {
            //ouvre la fenêtre d'ajout

            AjouterFonctions AjouterF= new AjouterFonctions();
            AjouterF.ShowDialog();
        }











        //Pour afficher le contenu dans les ListeBox pour 

       

        private void LbFonctions_Selected(object sender, RoutedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            Fonction f = lb.SelectedItem as Fonction;

            try
            {
                TxtBNomSorF.Text = f.Intitule.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la selection de service");
            }
        }

        private void LbServices_Selected(object sender, RoutedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            Service s = lb.SelectedItem as Service;

            try
            {
                //ici pour afficher dans le textbox
                TxtBNomSorF.Text = s.Intitule.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur lors de la selection de service");
            }
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            //enregistrer le contenu modifier de la textbox dans service ou fonction
            
            Fonction f = new Fonction();
            Service s = new Service();
            List<Service> services = bddPersonels.GetAllServices();
            List<Fonction> fonctions = bddPersonels.GetAllFonctions();
            try
            {
                if (LbServices.SelectedItem!=null)
                {
                    
                    foreach (Service service in services)
                    {
                        if (LbServices.SelectedItem.ToString() == service.Intitule)
                        {
                            s = service;
                            bddPersonels.Modifservice(s);
                            //pour mettre les changements en dynamique
                            LbServices.Items.Clear();
                            List<Service> serv = bddPersonels.GetAllServices();
                            LbServices.ItemsSource = services;
                        }
                    }
                    
                }
                if(LbFonctions.SelectedItem != null) 
                {
                    foreach (Fonction fonction in fonctions)
                    {
                        if (LbFonctions.SelectedItem.ToString() == fonction.Intitule)
                        {
                            f = fonction;
                            bddPersonels.ModifFonction(f);
                            //pour mettre les changements en dynamique
                            LbServices.Items.Clear();
                            List<Fonction> fonc = bddPersonels.GetAllFonctions();
                            LbServices.ItemsSource = fonctions;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
