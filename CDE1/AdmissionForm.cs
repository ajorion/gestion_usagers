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
    public partial class AdmissionForm : Form
    {
        public AdmissionForm()
        {
            InitializeComponent();
        }

        private void AdmissionForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine(sender.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
