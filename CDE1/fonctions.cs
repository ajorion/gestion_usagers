using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_usagers
{
    class Fonctions
    {
        /* Fonction IsAuthenticated() utilisée pendant le developpement */
        public static bool IsAuthenticated(string utilisateur, string mdp)
        {
            bool authenticated = false;

            if ((utilisateur == "test") && (mdp == "test"))
            {
                authenticated = true;
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur / Mot de passe : test",
                    "Identifiants test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                authenticated = false;
            }

            return authenticated;
        }


        public static bool isAdmin(string login)
        {
            bool admin = false;

            if (login == "ajorion")
            {
                admin = true;
            }
            else
            {
                admin = false;
            }

            return admin;
        }

        /* Partie pour l'authentification à l'AD - non utilisée en période de développement
         
       public bool IsAuthenticated(string utilisateur, string mdp)
       {
           bool authenticated = false;

           try
           {
               DirectoryEntry entry = new DirectoryEntry("LDAP://SERVEUR", utilisateur, mdp);
               object nativeObject = entry.NativeObject;
               authenticated = true;
           }
           catch (DirectoryServicesCOMException cex)
           {
               MessageBox.Show(cex.Message,
                   "Erreur", 
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message, 
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
           }
           return authenticated;
       }
       */
    }


}
