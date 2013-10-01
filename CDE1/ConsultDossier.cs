﻿using System;
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

namespace gestion_usagers
{
    /// <summary>
    ///  Classe gérant l'affichage des informations du dossier de l'usager
    /// </summary>
    public partial class ConsultDossier : Form
    {
        public string num_dossier;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private cdeEntities enfantsContext;

        //SQLiteConnection m_dbConnection; 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dossier">Permet de récupérer l'ID du dossier de l'usager concerné
        /// afin de récupérer les informations de la base de données.
        /// </param>
        public ConsultDossier(string dossier)
        {
            InitializeComponent();
            
            num_dossier = dossier;
            
        }

        private void ConsultDossier_Load(object sender, EventArgs e)
        {
             var enfant = Db.getDossierEnfant(num_dossier);

            enfantsContext = new cdeEntities();

            
            var query = from enfants in enfantsContext.enfantsJeu
                        where enfants.num_dossier == num_dossier
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

            }
            /*
            try
            {
                while (enfant.Read())
                {
                    this.Text = "Consultation d'un dossier : " + enfant["prenom"].ToString() + " " + enfant["nom"].ToString();
                    lbl_nomprenom.Text = enfant["nom"].ToString().ToUpper() + " " + enfant["prenom"].ToString();
                    toolStripLabel1.Text = "N° dossier : " + enfant["num_dossier"].ToString();
                    lbl_date_naiss.Text = enfant["date_naissance"].ToString() + " à " + enfant["lieu_naissance"].ToString();
                    label5.Text = enfant["date_admission"].ToString();
                    label6.Text = enfant["service"].ToString();
                     
                    txb_nom_pere.Text = enfant["nom_pere"].ToString();
                    txb_nais_pere.Text = enfant["dn_pere"].ToString();
                    txb_adrr_pere.Text = enfant["adresse_pere"].ToString();
                    txb_cp_pere.Text = enfant["cp_pere"].ToString();
                    txb_ville_pere.Text = enfant["ville_pere"].ToString();

                    txb_nom_mere.Text = enfant["nom_mere"].ToString();
                    txb_nais_mere.Text = enfant["dn_mere"].ToString();
                    txb_addr_mere.Text = enfant["adresse_mere"].ToString();
                    txb_cp_mere.Text = enfant["cp_mere"].ToString();
                    txb_ville_mere.Text = enfant["ville_mere"].ToString();

                   
                    if (enfant["sexe"].ToString() == "m")
                    {
                        sexe_img.Image = Properties.Resources._1371236677_male;
                        sexe_img.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    if (enfant["sexe"].ToString() == "f")
                    {
                        sexe_img.Image = Properties.Resources._1371236480_female;
                        sexe_img.SizeMode = PictureBoxSizeMode.CenterImage;
                    }

                    // TODO: voir pour changer de méthode car là, c'est un peu sale...
                    if (enfant["ap_pere"].ToString() == "1")
                    {
                        chkb_ap_pere.Checked = true;
                    }

                    if (enfant["ap_mere"].ToString() == "1")
                    {
                        chkb_ap_mere.Checked = true;
                    }

                    var status = Db.listeStatuts(enfant["num_dossier"].ToString());
                    while (status.Read())
                    {
                        ListViewItem lvi = new ListViewItem(status["type_statut"].ToString());
                        lvi.SubItems.Add(status["date_debut"].ToString());
                        lvi.SubItems.Add(status["date_fin"].ToString());
                        lvi.SubItems.Add(status["nom_juge"].ToString() + " - " + status["tpe"].ToString());
                        lvi.SubItems.Add(status["date_audience"].ToString());
                        listView1.Items.Add(lvi);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        */
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
