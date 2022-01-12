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
    public partial class crystalreport : Form
    {
        public crystalreport()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=LAPTOP-KQ9Q6C8H;Initial Catalog=Topup;Integrated Security=True";
        private void crystalreport_Load(object sender, EventArgs e)
        {

        }

        private void dgvreport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DataTable table = null;
            string query = "select * from TransaksiTab";
            try
            {
                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
            }
            catch (Exception)
            {
                //handle caught exception
            }

            if (table != null)
            {
                dgvreport.DataSource = table.DefaultView;
            }
        }
    }
}
