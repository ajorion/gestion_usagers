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

namespace gestion_usagers
{
    public partial class Form1 : Form
    {

        Timer bg = new Timer();
        private cdeEntities cdeContext;
        private static Logger logger = LogManager.GetCurrentClassLogger();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            cdeContext = new cdeEntities();


            var query = from enfants in cdeContext.enfantsJeu
                        select enfants;            

            StatusBar mainStatusBar = new StatusBar();

            StatusBarPanel helpPanel = new StatusBarPanel() ;
            StatusBarPanel InfosPanel = new StatusBarPanel();
            StatusBarPanel heurePanel = new StatusBarPanel();

            helpPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            mainStatusBar.Panels.Add(helpPanel);

            bg.Tick += (s, ev) => { heurePanel.Text = string.Format("{0:H:m}", DateTime.Now.ToString()); };
            bg.Interval = 500;
            bg.Start();
            //heurePanel.AutoSize = StatusBarPanelAutoSize.Spring;
            heurePanel.Width = 200;
            heurePanel.Alignment = HorizontalAlignment.Right;
            mainStatusBar.Panels.Add(heurePanel);
            
            mainStatusBar.ShowPanels = true;

            Controls.Add(mainStatusBar);  
            
            InfosPanel.Text = "Connecté en tant que " + Environment.UserDomainName + "\\" + Environment.UserName;
            //InfosPanel.AutoSize = StatusBarPanelAutoSize.Spring;
            InfosPanel.Width = 200;
            InfosPanel.Alignment = HorizontalAlignment.Right;
            
            mainStatusBar.Panels.Add(InfosPanel);


                       
            
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

            AdmissionForm childForm = null;

            foreach (Form f in this.MdiChildren)
            {
                if (f is AdmissionForm)
                {
                    childForm = (AdmissionForm)f;
                    break;
                }
            }

            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
                MessageBox.Show("Fenêtre \"" + childForm.Text + "\" déjà ouverte.");
            }
            else
            {
                childForm = new AdmissionForm();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listeEnfants liste_form = new listeEnfants();

            listeEnfants childForm = null;

            foreach (Form f in this.MdiChildren)
            {
                if (f is listeEnfants)
                {
                    childForm = (listeEnfants)f;
                    break;
                }
            }

            if (childForm != null)
            {
                childForm.Show();
                childForm.Focus();
                MessageBox.Show("Fenêtre \"" + childForm.Text + "\" déjà ouverte.");
            }
            else
            {
                childForm = new listeEnfants();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.Focus();
            }
        }
        
    }
}
