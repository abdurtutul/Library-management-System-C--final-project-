using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
        }
       

        private void bookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooklist vbl = new ViewBooklist();
            vbl.Show();


        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMemberList vml = new ViewMemberList();
            vml.Show();
        }

        private void addReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReports ar = new AddReports();
            ar.Show();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewReports vr = new ViewReports();
            vr.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)

        {


            if (MessageBox.Show("Are You Sure To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                Application.Exit();

        }
    }
}
