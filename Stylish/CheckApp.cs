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

namespace Stylish
{
    public partial class CheckApp : Form
    {
        public CheckApp(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";
        }

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                               "database = CSProject;" +
                               "integrated security = SSPI");

        DataTable dt;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckApp_Load(object sender, EventArgs e)
        {
            getList();
        }

        private void getList()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from CreateApp", con);
                dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dt;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Doctor j = new Doctor(lblUser.Text);
            this.Hide();
            j.Show();
        }
    }
}
