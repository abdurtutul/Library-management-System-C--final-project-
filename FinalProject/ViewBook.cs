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
    public partial class ViewBook : Form
    {
        private DataAccess Da { get; set; }
        public ViewBook()
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


        private void BtnShow_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from ViewBooklist;";
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
                string sql = "select * from ViewBooklist where bname = '" + txtSearch.Text + "' ;";
                this.PopulateGridView(sql);
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


                var sql = "delete from ViewBooklist where id ='" + this.txtId.Text + "';";


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

       

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                var sql = @"update ViewBookList
                            set bname ='" + this.txtBookName.Text + @"',
                             author ='" + this.txtAuthor.Text + @"',
                             publication ='" + this.txtPublication.Text + @"',
                             date ='" + this.dateTimePicker1.Text + @"',
                             price ='" + this.txtPrice.Text + @"',
                             quantity ='" + this.txtQuantity.Text + @"'
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

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            
                this.txtId.Text = this.dgvList.CurrentRow.Cells[0].Value.ToString();
                this.txtBookName.Text = this.dgvList.CurrentRow.Cells[1].Value.ToString();
                this.txtAuthor.Text = this.dgvList.CurrentRow.Cells[2].Value.ToString();
                this.txtPublication.Text = this.dgvList.CurrentRow.Cells[3].Value.ToString();
                this.dateTimePicker1.Text = this.dgvList.CurrentRow.Cells[4].Value.ToString();
                this.txtPrice.Text = this.dgvList.CurrentRow.Cells[5].Value.ToString();
                this.txtQuantity.Text = this.dgvList.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtBookName.Clear();
            this.txtAuthor.Clear();
            this.txtPublication.Clear();
            this.dateTimePicker1.Text = "";
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
        }

       
    }
}
