using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace gestion_usagers
{
    class Db
    {
        
        static string db = "Data Source=./cde.db;Version=3;";
        static SQLiteConnection m_dbConnection;

        public static SQLiteDataReader getDernieresEntrees()
        {
            m_dbConnection = new SQLiteConnection(db);
            m_dbConnection.Open();

            string query = "SELECT * FROM enfants ORDER BY date_admission DESC LIMIT 5";
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader;      
        }
                
        public static SQLiteDataReader getDossierEnfant(string num_dossier)
        {
            m_dbConnection = new SQLiteConnection(db);
            m_dbConnection.Open();

            string query = string.Format(@"SELECT nom, prenom, date_admission, date_naissance, lieu_naissance, service, num_dossier
                                        FROM enfants
                                        WHERE num_dossier='{0}'",
                                        num_dossier);

            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            return reader;
        }

        public static SQLiteDataReader listeStatuts(string id_enfant)
        {
            m_dbConnection = new SQLiteConnection(db);
            m_dbConnection.Open();

            string query = string.Format(@"SELECT statuts.id_statut, statuts.id_enfant, statuts.date_debut, statuts.date_fin, statuts.id_juge, statuts.date_audience,
                            type_statuts.id_statut, type_statuts.type_statut,
                            juges.id_juge, juges.nom_juge, juges.tpe
                            FROM statuts, type_statuts, juges
                            WHERE statuts.id_enfant='{0}'
                            AND statuts.id_statut=type_statuts.id_statut
                            AND statuts.id_juge=juges.id_juge", id_enfant);

            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            return reader;
        }

        /*
        public static SQLiteDataReader echeancesStatut()
        {
            m_dbConnection = new SQLiteConnection(db);
            m_dbConnection.Open();

            
        }
         * */

    }

}
