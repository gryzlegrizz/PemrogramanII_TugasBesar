using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TB_714220040_714220046.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang FormBrg = new FormBarang();
            FormBrg.MdiParent = this;
            FormBrg.WindowState = FormWindowState.Maximized;
            FormBrg.Show();
        }

        private void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
