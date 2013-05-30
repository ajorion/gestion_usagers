using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace gestion_usagers
{
    public partial class ConsultDossier : Form
    {
        public string num_dossier;
        //SQLiteConnection m_dbConnection; 

        public ConsultDossier(string dossier)
        {
            InitializeComponent();
            
            num_dossier = dossier;
            
        }

        private void ConsultDossier_Load(object sender, EventArgs e)
        {
            var enfant = Db.getDossierEnfant(num_dossier);

            this.listView1.View = System.Windows.Forms.View.Details;

            ColumnHeader columnheader0 = new ColumnHeader();
            columnheader0.Text = "Mesure";

            ColumnHeader columnheader1 = new ColumnHeader();
            columnheader1.Text = "Date de début";
            columnheader1.Width = 150;
            columnheader1.TextAlign = HorizontalAlignment.Left;

            ColumnHeader columnheader2 = new ColumnHeader();
            columnheader2.Text = "Date de fin";
            columnheader2.Width = 120;
            columnheader2.TextAlign = HorizontalAlignment.Left;

            ColumnHeader columnheader3 = new ColumnHeader();
            columnheader3.Text = "Juge des enfants";
            columnheader3.TextAlign = HorizontalAlignment.Left;

            
            listView1.Columns.Add(columnheader0);
            listView1.Columns.Add(columnheader1);
            listView1.Columns.Add(columnheader2);
            listView1.Columns.Add(columnheader3);
            
            try
            {
                while (enfant.Read())
                {
                    this.Text = "Consultation d'un dossier : " + enfant["prenom"].ToString();
                    lbl_nomprenom.Text = enfant["nom"].ToString().ToUpper() + " " + enfant["prenom"].ToString();
                    txb_num_dossier.Text = enfant["num_dossier"].ToString();
                    txb_date_naiss.Text = enfant["date_naissance"].ToString();
                    
                    var status = Db.listeStatuts(enfant["num_dossier"].ToString());

                    while (status.Read())
                    {
                        ListViewItem lvi = new ListViewItem(status["type_statut"].ToString());
                        lvi.SubItems.Add(status["date_debut"].ToString());
                        lvi.SubItems.Add(status["date_fin"].ToString());
                        lvi.SubItems.Add(status["nom_juge"].ToString() + " - " + status["tpe"].ToString());
                        listView1.Items.Add(lvi);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txb_num_dossier_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txb_date_naiss_TextChanged(object sender, EventArgs e)
        {

        }

        public object dossier { get; set; }
    }
}
