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
    public partial class AddMember : Form
    {
        private DataAccess Da { get; set; }
        public AddMember()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
       

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtContact.Text)||String.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show("Data Missing. Please Fill Up All The Information");
                    return;
                }
                var sql = "insert into MemberInfo  Values('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.txtContact.Text + "','" + this.txtEmail.Text + "');";

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
            this.txtName.Clear();
            this.txtContact.Clear();
            this.txtEmail.Clear();
            
        }

       
    }
}
