using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void allBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Conncets the tab to the form
            frmAllBooks boeke = new frmAllBooks();

            boeke.MdiParent = this;

            boeke.Show();
        }

        private void selectGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelectGenre genre = new frmSelectGenre();

            genre.MdiParent = this;

            genre.Show();
        }
    }
}
