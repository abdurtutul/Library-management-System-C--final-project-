using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ViewReports : Form
    {
        private DataAccess Da { get; set; }
        public ViewReports()
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

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from BookReports;";
                this.PopulateGridView(sql);
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
                string sql = "select * from BookReports where id = '" + txtSearch.Text + "' ;";
                this.PopulateGridView(sql);

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }



        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvList.CurrentRow.Cells[0].Value.ToString();
            this.txtMemberName.Text = this.dgvList.CurrentRow.Cells[1].Value.ToString();
            this.txtBookName.Text = this.dgvList.CurrentRow.Cells[2].Value.ToString();
            this.dateTimePicker1.Text = this.dgvList.CurrentRow.Cells[3].Value.ToString();
            this.dateTimePicker2.Text = this.dgvList.CurrentRow.Cells[4].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                var sql = @"update BookReports
                            set name ='" + this.txtMemberName.Text + @"',
                            bname='" + this.txtBookName.Text + @"',
                            idate ='" + this.dateTimePicker1.Text + @"',
                            rdate ='" + this.dateTimePicker2.Text + @"'
                            where id = '" + this.txtId.Text + "';";


                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Data Update Successfull");
                else
                    MessageBox.Show("Data Update Failed");

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                var sql = "delete from BookReports where id ='" + this.txtId.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView(sql);


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtMemberName.Clear();
            this.txtBookName.Clear();
            this.dateTimePicker1.Text = " ";
            this.dateTimePicker2.Text = " ";
        }
    }
}
