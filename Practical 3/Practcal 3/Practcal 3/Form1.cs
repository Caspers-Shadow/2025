using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Practical 3
 * 43054226
 * 48282928
 */

namespace Practcal_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }

        private void listDVDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Making this form a parent to frmDVDForm
            frmDVDNew DVDForm = new frmDVDNew();

            DVDForm.MdiParent = this;

            DVDForm.Show();
        }
    }
}
