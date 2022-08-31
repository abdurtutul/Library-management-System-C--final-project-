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
    public partial class ViewBooklist : Form
    {
        private DataAccess Da { get; set; }
        public ViewBooklist()
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

        

       
    }
    
}
