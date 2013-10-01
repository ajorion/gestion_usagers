using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using NLog;
using System.Globalization;

namespace gestion_usagers
{
    /// <summary>
    ///  Classe gérant l'affichage des informations du dossier de l'usager
    /// </summary>
    public partial class ConsultDossier : Form
    {
        public int n_id;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private cdeEntities enfantsContext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dossier">Permet de récupérer l'ID du dossier de l'usager concerné
        /// afin de récupérer les informations de la base de données.
        /// </param>
        
        public ConsultDossier(int id)
        {
            InitializeComponent();
            
            n_id = id;
            
        }

        private void ConsultDossier_Load(object sender, EventArgs e)
        {

            enfantsContext = new cdeEntities();

            
            var query = from enfants in enfantsContext.enfantsJeu
                        where enfants.ID == n_id
                        select enfants;
            
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
            columnheader3.Width = -2;

            ColumnHeader columnheader4 = new ColumnHeader();
            columnheader4.Text = "Prochaine audience";
            columnheader4.TextAlign = HorizontalAlignment.Left;
            columnheader4.Width = -2;

            
            listView1.Columns.Add(columnheader0);
            listView1.Columns.Add(columnheader1);
            listView1.Columns.Add(columnheader2);
            listView1.Columns.Add(columnheader3);
            listView1.Columns.Add(columnheader4);
            listView1.Sorting = SortOrder.Ascending;

            foreach (var value in query)
            {
                this.Text = string.Format(@"Consultation d'un dossier : {0} {1}", value.prenom_enfant, value.nom_enfant.ToUpper());

                lbl_nomprenom.Text = string.Format(@"{0} {1}", value.nom_enfant, value.prenom_enfant);
                lbl_num_dossier.Text = value.num_dossier;
                lbl_date_naiss.Text = (string.IsNullOrEmpty(value.lieu_naissance.ToString())) ? value.date_naissance : value.date_naissance + " à " + value.lieu_naissance; 
                label5.Text = value.date_admission;
                label6.Text = value.service;
                txb_nom_pere.Text = value.nom_pere;
                txb_nais_pere.Text = (string.IsNullOrEmpty(value.ln_pere)) ? value.dn_pere : value.dn_pere + " à " + value.ln_pere;
                txb_adrr_pere.Text = value.adresse_pere;
                txb_cp_pere.Text = value.cp_pere;
                txb_ville_pere.Text = value.ville_pere;
                txb_phonepere.Text = (string.IsNullOrEmpty(value.tel_pere)) ? "*" : value.tel_pere;
                txb_mobilepere.Text = (string.IsNullOrEmpty(value.mobile_pere)) ? "*" : value.mobile_pere;
            }
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_nomprenom_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_naiss_Click(object sender, EventArgs e)
        {

        }

        private void lst_ets_scol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
