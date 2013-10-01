namespace gestion_usagers
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.modulesToolStripMenuItem,
            this.fenêtresToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.fenêtresToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.system_log_out;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDossiersToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // gestionDossiersToolStripMenuItem
            // 
            this.gestionDossiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.admissionToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.gestionDossiersToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.system_users;
            this.gestionDossiersToolStripMenuItem.Name = "gestionDossiersToolStripMenuItem";
            this.gestionDossiersToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gestionDossiersToolStripMenuItem.Text = "Gestion dossiers";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::gestion_usagers.Properties.Resources.application_view_list;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 22);
            this.toolStripMenuItem2.Text = "Liste des enfants";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.list_add;
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.Click += new System.EventHandler(this.admissionToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.system_search;
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.edit_find_replace;
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Image = global::gestion_usagers.Properties.Resources.help_browser;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // baseDeDonnéesToolStripMenuItem
            // 
            this.baseDeDonnéesToolStripMenuItem.Name = "baseDeDonnéesToolStripMenuItem";
            this.baseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::gestion_usagers.Properties.Resources.logo_CDE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des dossiers des usagers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    }
}

