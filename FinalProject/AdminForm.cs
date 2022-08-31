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
    public partial class AdminForm : Form
    {     
        public AdminForm()
        {
            InitializeComponent();
        }
      

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ViewMember vm = new ViewMember();
            vm.Show();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember am = new AddMember();
            am.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBook ib = new IssueBook();
            ib.Show();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewIssue vi = new ViewIssue();
            vi.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Are You Sure To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

             Application.Exit();
           
            
        }
    }
}
