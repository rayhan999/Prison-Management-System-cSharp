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
    public partial class Warden : Form
    {
        public Warden(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome. You're logged in as: ";

           

        }

        private void LoadImage()
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                 "database = CSProject;" +
                                 "integrated security = SSPI");

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

        private void btnEmpManage_Click(object sender, EventArgs e)
        {
            ManageEmp mp = new ManageEmp(lblUser.Text);
            this.Hide();
            mp.Show();
        }

        private void btnCheckPrisoner_Click(object sender, EventArgs e)
        {
            CheckPrisoner cp = new CheckPrisoner(lblUser.Text);
            this.Hide();
            cp.Show();
        }

        private void btnCheckReleased_Click(object sender, EventArgs e)
        {
            CheckReleased cr = new CheckReleased(lblUser.Text);
             this.Hide();
            cr.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass(lblUser.Text);
            this.Hide();
            cp.Show();
        }

        private void btnPrisonInfo_Click(object sender, EventArgs e)
        {
            Info i = new Info(lblUser.Text);
            this.Hide();
            i.Show();
        }

        private void btnCheckVisitor_Click(object sender, EventArgs e)
        {
            CheckVisitor cv = new CheckVisitor(lblUser.Text);
            this.Hide();
            cv.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void Warden_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
