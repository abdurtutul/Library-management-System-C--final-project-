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
    public partial class AddReports : Form
    {
        private DataAccess Da { get; set; }
        public AddReports()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtname.Text) || String.IsNullOrEmpty(this.txtbname.Text) || String.IsNullOrEmpty(this.dateTimePicker1.Text) || String.IsNullOrEmpty(this.dateTimePicker2.Text))
               
                {
                   MessageBox.Show("Data Missing. Please Fill Up All The Information");
                   return;
                }
                    var sql = "insert into BookReports  Values('" + this.txtId.Text + "','" + this.txtname.Text + "','" + this.txtbname.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "');";

                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data Insertion Successfull");
                    else
                        MessageBox.Show("Data Insertion Failed");
                

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }



        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtname.Clear();
            this.txtbname.Clear();
            this.dateTimePicker1.Text = "";
            this.dateTimePicker2.Text = "";

        }
    }
}

