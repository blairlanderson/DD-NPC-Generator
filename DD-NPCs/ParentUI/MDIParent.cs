using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//project specific includes
using NameGeneratorUI;

namespace ParentUI
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();

            NameGen_Splash ngs = new NameGen_Splash();
            ngs.MdiParent = this;
            ngs.Show();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
