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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
       

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from LoginTbl where Id = '" + UserId.Text + "' and Password = '" + Password.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-F7TP2B0\\EXCELMAP;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=raima12345");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);



            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Login Valid");

                if (ds.Tables[0].Rows[0][3].ToString() == "Admin")
                {
                    AdminForm admin = new AdminForm();
                    admin.Show();
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "Member")
                {
                    MemberForm member = new MemberForm();
                    member.Show();
                }

            }
            else
            {
                MessageBox.Show("Login Invalid");
                this.ClearContent();

            }


        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            this.ClearContent();
        }

        private void ClearContent()
        {
            this.UserId.Clear();
            this.Password.Clear();
        }
    }
}
