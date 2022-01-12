using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TopUp
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
        }

        //tombol login
        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-KQ9Q6C8H;Initial Catalog=Topup;Integrated Security=True");
            string query = "select * from LoginTable where username = '" + TXTUsername.Text.Trim() + "' and password = '" + TXTPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)   
            {
                menu_form objmenu_form = new menu_form();
                this.Hide();
                objmenu_form.Show();
            }
            else
            {
                MessageBox.Show("Username Or Password Incorrect");
            }


        }

        private void login_form_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
