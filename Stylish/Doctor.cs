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
using System.IO;

namespace Stylish
{
    public partial class Doctor : Form
    {
        public Doctor(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";

            
        }

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                "database = CSProject;" +
                                "integrated security = SSPI");

        private void LoadImage()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT image FROM Employee where UserName='" + lblUser.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] b = new byte[0];
                b = (Byte[])(dr["image"]);
                MemoryStream ms = new MemoryStream(b);
                pictureBox2.Image = Image.FromStream(ms);
               

            }
            con.Close();
        }

        private void btnManagePrescription_Click(object sender, EventArgs e)
        {
            Prescription p = new Prescription(lblUser.Text);
            this.Hide();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Info i = new Info(lblUser.Text);
            this.Hide();
            i.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

            ChangePass cp = new ChangePass(lblUser.Text);
            this.Hide();
            cp.Show();
        }

        private void btnChkApp_Click(object sender, EventArgs e)
        {
            CheckApp ca = new CheckApp(lblUser.Text);
                  this.Hide();
            ca.Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
