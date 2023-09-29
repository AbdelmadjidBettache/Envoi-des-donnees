using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvoieDesDonnees
{
    public class User
    {
        private string nom;
        private string prenom;
        private string username;
        private string password;

        public User(string nom, string prenom, string username, string password)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Username = username;
            this.Password = password;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
