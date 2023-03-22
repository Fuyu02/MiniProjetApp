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
    /// Logique d'interaction pour WinConnexion.xaml
    /// </summary>
    public partial class WinConnexion : Window
    {
        public WinConnexion()
        {
            InitializeComponent();
        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SeConnecter(object sender, RoutedEventArgs e)
        {
            //se connecter en gestionnaire en récupérant ce qui est marqué grâce à la base pour vérifier
            // ouvrir une fenêtre d'erreur si c'est incorect
        }
    }
}
