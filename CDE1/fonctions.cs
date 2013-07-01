using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace gestion_usagers
{
    class Fonctions
    {
        
        /* Fonction IsAuthenticated() utilisée pendant le developpement */
        /// <summary>
        /// Fonction utilisée pour l'identification dans l'application. 
        /// (Utilisée uniquement durant le développement)
        /// </summary>
        /// <param name="utilisateur">Chaîne de caractères représentant le nom d'utilisateur.</param>
        /// <param name="mdp">Chaîne de caractères représentant le mot de passe saisi.</param>
        /// <returns>1 si l'authentification a réussi, 0 si elle a échoué.</returns>
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

        /* Partie pour l'authentification à l'AD - non utilisée en période de développement */
       /*  
       public static bool IsAuthenticated(string utilisateur, string mdp)
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
