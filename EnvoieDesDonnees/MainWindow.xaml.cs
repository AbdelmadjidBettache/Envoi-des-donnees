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

namespace EnvoieDesDonnees
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<User> list;
        public static User connectUser=null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            list = new List<User>();
            list.Add(new User("Depuis", "Maxime", "dmaxime", "123"));
            list.Add(new User("Abed", "Tayeb", "atayeb", "123"));
            list.Add(new User("Bob", "Jack", "bjack", "123"));
        }

        private User findUser(string username,string password)
        {
            foreach (User user in list) 
            {
                if (user.Username==username && user.Password==password)
                {
                    return user;    
                }
            }
            return null;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string username= txtUser.Text;
            string password = txtPass.Text;
           
            if(txtUser.Text != string.Empty && txtPass.Text!= string.Empty)
            {
                User user = findUser(username,password);
                if(user != null)
                {
                    Application.Current.Properties["PRENOM"] = user.Prenom;
                    Application.Current.Properties["NOM"] = user.Nom;
                    //connectUser = user;
                    Session session = new Session();
                    session.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Utilisateur inexistant!");
                }
                
                
            }
            else
            {
                MessageBox.Show("Remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
