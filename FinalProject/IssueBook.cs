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
    public partial class IssueBook : Form
    {
        private DataAccess Da { get; set; }
        public IssueBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(String sql)
        {
            DataSet ds = this.Da.ExecuteQuery(sql);
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.DataSource = ds.Tables[0];

        }


        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvList.CurrentRow.Cells[0].Value.ToString();
            this.txtMemberName.Text = this.dgvList.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from MemberInfo;";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void BtnIssue_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtMemberName.Text) || String.IsNullOrEmpty(this.txtBookName.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text))
                {
                    MessageBox.Show("Data Missing. Please Fill Up All The Information");
                    return;
                }
                var sql = "insert into IssueTbl  Values('" + this.txtId.Text + "','" + this.txtMemberName.Text + "','" + this.txtBookName.Text + "','" + this.dateTimePicker1.Text + "');";

                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Book Issue Successfull");
                else
                    MessageBox.Show("Book Issue Failed");

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from MemberInfo where id = '" + txtSearch.Text + "' ;";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtMemberName.Clear();
            this.txtBookName.Items.Clear();
            this.dateTimePicker1.Text = " ";
        }
    }
}
