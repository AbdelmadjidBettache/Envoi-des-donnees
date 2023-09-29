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

namespace EnvoieDesDonnees
{
    /// <summary>
    /// Logique d'interaction pour Session.xaml
    /// </summary>
    public partial class Session : Window
    {
        public Session()
        {
            InitializeComponent();
            //lblSession.Content = "Bonjour " + MainWindow.connectUser.Prenom + " " + MainWindow.connectUser.Nom;
            lblSession.Content = "Bonjour " + Application.Current.Properties["PRENOM"] + " " + Application.Current.Properties["NOM"];
        }

        
    }
}
