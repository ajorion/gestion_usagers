using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace gestion_usagers
{
    public partial class listeEnfants : Form
    {

        private cdeEntities cdeContext;
        public listeEnfants()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_DoubleClick);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listeEnfants_Load(object sender, EventArgs e)
        {
            cdeContext = new cdeEntities();

            var query = from enfants in cdeContext.enfantsJeu
                        let total = cdeContext.enfantsJeu.Count()
                        select enfants;

            this.listView1.View = System.Windows.Forms.View.Details;

            ColumnHeader col_numdossier = new ColumnHeader();
            col_numdossier.Text = "N° dossier";
            col_numdossier.Width = 20;

            ColumnHeader col_nom = new ColumnHeader();
            col_nom.Text = "NOM";
            col_nom.Width = 200;

            ColumnHeader col_prenom = new ColumnHeader();
            col_prenom.Text = "Prénom";
            col_prenom.Width = 200;

            ColumnHeader col_service = new ColumnHeader();
            col_service.Text = "Service";

            listView1.Columns.Add(col_numdossier);
            listView1.Columns.Add(col_nom);
            listView1.Columns.Add(col_prenom);
            listView1.Columns.Add(col_service);

            foreach (var enfant in query)
            {
                ListViewItem lvi = new ListViewItem(enfant.ID.ToString());
                lvi.SubItems.Add(enfant.nom_enfant);
                lvi.SubItems.Add(enfant.prenom_enfant);
                lvi.SubItems.Add(enfant.service);

                listView1.Items.Add(lvi);
            }
            this.toolStripStatusLabel1.Text = string.Format(@"{0} résultats", query.Count());
        }

        private void listView1_DoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems != null)
            {
                ConsultDossier consultForm = new ConsultDossier(Int32.Parse(listView1.SelectedItems[0].Text));
                consultForm.Show();
            }
        }

    }
}
