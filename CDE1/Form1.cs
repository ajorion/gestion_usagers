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
    public partial class Form1 : Form
    {
        //SQLiteConnection m_dbConnection;

        Timer bg = new Timer();
        private cdeEntities cdeContext;
        private static Logger logger = LogManager.GetCurrentClassLogger();


        public Form1()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_DoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cdeContext = new cdeEntities();


            var query = from enfants in cdeContext.enfantsJeu
                        select enfants;            

            StatusBar mainStatusBar = new StatusBar();

            StatusBarPanel helpPanel = new StatusBarPanel();
            StatusBarPanel InfosPanel = new StatusBarPanel();
            StatusBarPanel datePanel = new StatusBarPanel();
            StatusBarPanel heurePanel = new StatusBarPanel();


            mainStatusBar.Panels.Add(helpPanel);
            InfosPanel.Text = "Connecté en tant que " + Environment.UserDomainName + "\\" + Environment.UserName;
            InfosPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(InfosPanel);

            bg.Tick += (s, ev) => { heurePanel.Text = string.Format("{0:H:m}", DateTime.Now.ToString()); };
            bg.Interval = 500;
            bg.Start();
            heurePanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(heurePanel);
            
            mainStatusBar.ShowPanels = true;

            Controls.Add(mainStatusBar);

            this.listView1.View = System.Windows.Forms.View.Details;

            ColumnHeader columnheader0 = new ColumnHeader();
            columnheader0.Text = "Numéro Dossier";
            
            ColumnHeader columnheader1 = new ColumnHeader();
            columnheader1.Text = "NOM - Prénom";
            columnheader1.Width = 150;
            columnheader1.TextAlign = HorizontalAlignment.Left;

            ColumnHeader columnheader2 = new ColumnHeader();
            columnheader2.Text = "Date d'admission";
            columnheader2.Width = 120;
            columnheader2.TextAlign = HorizontalAlignment.Left;

            ColumnHeader columnheader3 = new ColumnHeader();
            columnheader3.Text = "Service";
            columnheader3.Width = 130;
            columnheader3.TextAlign = HorizontalAlignment.Left;

            listView1.Columns.Add(columnheader0);
            listView1.Columns.Add(columnheader1);
            listView1.Columns.Add(columnheader2);
            listView1.Columns.Add(columnheader3);
            
            var enfantsliste = cdeContext.enfantsJeu.ToList();


            foreach (var enfant in query)
                {

                    ListViewItem lvi = new ListViewItem(enfant.num_dossier);
                    lvi.SubItems.Add(string.Format("{0} {1}", enfant.nom_enfant.ToUpper(), enfant.prenom_enfant));
                    lvi.SubItems.Add(enfant.date_admission);
                    lvi.SubItems.Add(enfant.service);

                    listView1.Items.Add(lvi);
                }
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmissionForm admission_form = new AdmissionForm();

            admission_form.ShowDialog();

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_DoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                ConsultDossier consultForm = new ConsultDossier(listView1.SelectedItems[0].Text);
                consultForm.ShowDialog();
            }
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
       
        }
        
    }
}