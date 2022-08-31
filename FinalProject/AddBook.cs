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
    public partial class AddBook : Form
    {
        private DataAccess Da { get; set; }
        public AddBook()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(this.txtBookName.Text) || String.IsNullOrEmpty(this.txtAuthor.Text)||String.IsNullOrEmpty(this.txtPublication.Text)||String.IsNullOrEmpty(this.dateTimePicker1.Text)||String.IsNullOrEmpty(this.txtPrice.Text)||String.IsNullOrEmpty(this.txtQuantity.Text))
                {
                    MessageBox.Show("Data Missing. Please Fill Up All The Information");
                    return;
                }
                var sql = "insert into ViewBooklist (bname,author,publication,date,price,quantity)" + " Values('" + this.txtBookName.Text + "','" + this.txtAuthor.Text + "','" + this.txtPublication.Text + "','" + this.dateTimePicker1 + "','" + this.txtPrice.Text + "','" + this.txtQuantity.Text + "');";

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
            this.txtBookName.Clear();
            this.txtAuthor.Clear();
            this.txtPublication.Clear();
            this.dateTimePicker1.Text = "";
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
        }
    }

       
    
}
