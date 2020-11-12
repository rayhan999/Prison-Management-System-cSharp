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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string status;
        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                  "database = CSProject;" +
                                  "integrated security = SSPI");
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Employee where UserName= @UserName and Password= @Password", con);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);


                con.Open();


                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                cmd.ExecuteNonQuery();

                if (dt.Rows.Count.Equals(1))
                {
                    status = dt.Rows[0][12].ToString().Trim();
                    if (status == "1")
                    {
                        Warden wr = new Warden(txtUsername.Text);
                        this.Hide();
                        wr.Show();
                    }
                    else if (status == "2")
                    {
                        Jailor j = new Jailor(txtUsername.Text);
                        this.Hide();
                        j.Show();
                    }

                    else if (status == "3")
                    {
                        Receptionist rc = new Receptionist(txtUsername.Text);
                        this.Hide();
                        rc.Show();

                    }

                    else if (status == "4")
                    {
                        Doctor d = new Doctor(txtUsername.Text);
                        this.Hide();
                        d.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong UserName & Password");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }
    }
}
