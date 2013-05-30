using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace gestion_usagers
{
    class Db
    {
        static SQLiteConnection m_dbConnection;
        static string num_dossier;
        static string db = "Data Source=./cde.db;Version=3;";

        public static SQLiteDataReader getDernieresEntrees()
        {
            m_dbConnection = new SQLiteConnection(db);

            m_dbConnection.Open();

            string query = "SELECT * FROM enfants ORDER BY date_admission DESC LIMIT 5";
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            return reader;

            m_dbConnection.Close();
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
            m_dbConnection.Close();

        }

        public static SQLiteDataReader listeStatuts (string id_enfant)
        {
            m_dbConnection = new SQLiteConnection(db);

            m_dbConnection.Open();
            
            string query = string.Format(@"SELECT statuts.id_statut, statuts.id_enfant, statuts.date_debut, statuts.date_fin,
                            type_statuts.id_statut, type_statuts.type_statut
                            FROM statuts, type_statuts
                            WHERE statuts.id_enfant='{0}'
                            AND statuts.id_statut=type_statuts.id_statut", id_enfant);
            
            SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            return reader;

            m_dbConnection.Close();
        }
    }

}
