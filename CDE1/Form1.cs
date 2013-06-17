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
    public partial class Form1 : Form
    {
        //SQLiteConnection m_dbConnection;

        Timer bg = new Timer();

        public Form1()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_DoubleClick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Console.Write(string.Format("{0:dd/MM/yyyy}", DateTime.Now));

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
            
            /*
            if (System.IO.File.Exists("cde.db"))
            {
                m_dbConnection = new SQLiteConnection("Data Source=./cde.db;Version=3;");

                m_dbConnection.Open();

                string query = "SELECT * FROM enfants ORDER BY date_admission DESC LIMIT 5";
                SQLiteCommand command = new SQLiteCommand(query, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string nom = reader["nom"].ToString().ToUpper() + " " + reader["prenom"].ToString();
                    string date_adm = reader["date_admission"].ToString();
                    string sce = reader["service"].ToString();

                    ListViewItem lvi = new ListViewItem(reader["num_dossier"].ToString());

                    lvi.SubItems.Add(nom);
                    lvi.SubItems.Add(date_adm);
                    lvi.SubItems.Add(sce);
                    listView1.Items.Add(lvi);

                }

            }
            else
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add("Aucun enregistrement");
                listView1.Items.Add(lvi);
            }
            */
            var entrees = Db.getDernieresEntrees();

            while (entrees.Read())
            {

                string nom = entrees["nom"].ToString().ToUpper() + " " + entrees["prenom"].ToString();
                string date_adm = entrees["date_admission"].ToString();
                string sce = entrees["service"].ToString();

                ListViewItem lvi = new ListViewItem(entrees["num_dossier"].ToString());

                lvi.SubItems.Add(nom);
                lvi.SubItems.Add(date_adm);
                lvi.SubItems.Add(sce);
                listView1.Items.Add(lvi);
            }

            StatusBar mainStatusBar = new StatusBar();
            
            StatusBarPanel InfosPanel = new StatusBarPanel();
            StatusBarPanel datePanel = new StatusBarPanel();
            StatusBarPanel heurePanel = new StatusBarPanel();


            InfosPanel.Text = "Connecté en tant que " + Environment.UserDomainName + "\\" + Environment.UserName;
            InfosPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(InfosPanel);
            /*
            datePanel.Text = DateTime.Today.ToLongDateString();
            datePanel.ToolTipText = DateTime.Today.ToString();
            datePanel.AutoSize = StatusBarPanelAutoSize.Contents; 
            mainStatusBar.Panels.Add(datePanel);
            */
            bg.Tick += (s, ev) => { heurePanel.Text = string.Format("{0:H:m}", DateTime.Now.ToString()); };
            bg.Interval = 500;
            bg.Start();
            heurePanel.AutoSize = StatusBarPanelAutoSize.Contents;
            mainStatusBar.Panels.Add(heurePanel);

            mainStatusBar.ShowPanels = true;
                        
            Controls.Add(mainStatusBar);


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
                //MessageBox.Show(listView1.SelectedItems[0].Text);
                ConsultDossier c_d = new ConsultDossier(listView1.SelectedItems[0].Text);
                c_d.ShowDialog();
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
        
    }
}
