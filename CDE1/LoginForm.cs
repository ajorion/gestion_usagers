﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace gestion_usagers
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if ((Txt_Pwd.Text != "") && (Txt_Pwd.Text != ""))
            {

                if (Fonctions.IsAuthenticated(Txt_Login.Text, Txt_Pwd.Text))
                {
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner un nom d'utilisateur et/ou un mot de passe !",
                    "Erreur de saisie !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            Txt_Login.Clear();
            Txt_Pwd.Clear();

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Btn_Login.PerformClick();
                    break;
            }
        }


    }
}