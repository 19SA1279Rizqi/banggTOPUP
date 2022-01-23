using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopUp
{
    public partial class crystal : Form
    {
        public crystal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void crystal_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=LAPTOP-KQ9Q6C8H;Initial Catalog=Topup;Integrated Security=True";
            PgSqlConnection conn = new PgSqlConnection(cs);
            PgSqlConnection cmd = new PgSqlConnection();
            PgSqlDataAdapter adptr = new PgSqlDataAdapter();
    
            string qry = "select * from .dbo.tb";
       
            DataTable dt = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = qry;
            conn.Open();
            adptr.SelectCommand = cmd;
            adptr.fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        }
}
