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
    public partial class Receptionist : Form
    {
        public Receptionist(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";

           
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

        private bool VisitingHour()
        {
            var visitingHour = DateTime.Now.Hour;
            if (visitingHour >= 1 && visitingHour <= 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnVisitorManage_Click(object sender, EventArgs e)
        {
            if (VisitingHour())
            {
                ManageVisitor mv = new ManageVisitor(lblUser.Text);
                this.Hide();
                mv.Show();
            }
            else
            {
                MessageBox.Show("Wait until visiting Hour");
            }

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass(lblUser.Text);
            this.Hide();
            cp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info i = new Info(lblUser.Text);
            this.Hide();
            i.Show();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            LoadImage();
        }
    }
}
