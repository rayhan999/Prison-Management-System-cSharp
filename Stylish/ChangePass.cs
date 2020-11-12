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
    public partial class ChangePass : Form
    {
        public ChangePass(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "You're logged in as:";
        }

        public string status;

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                 "database = CSProject;" +
                                 "integrated security = SSPI");

        public string password;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Employee where UserName= @UserName and Password= @Password", con);
                cmd.Parameters.AddWithValue("@UserName", lblUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtOldPass.Text);


                con.Open();


                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                cmd.ExecuteNonQuery();

                if (dt.Rows.Count.Equals(1))
                {
                    password = dt.Rows[0][1].ToString();

                    if (txtNewPass.Text.Equals(txtConfirmPass.Text))
                    {
                        update();
                        Form1 f = new Form1();
                        this.Hide();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("New password & Confirm Password should be same");
                    }
                }
                else
                {
                    MessageBox.Show("Old password is not right!!!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void update()
        {
            SqlCommand cmd = new SqlCommand("Update Employee set  Password= @Password where UserName =@UserName", con);
            cmd.Parameters.AddWithValue("@UserName", lblUser.Text);
            cmd.Parameters.AddWithValue("@Password", txtNewPass.Text);


            cmd.ExecuteNonQuery();


            MessageBox.Show("Password changed successfully. Please log in again.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           

            try
            {
                SqlCommand cmd = new SqlCommand("Select Status from Employee where UserName= @UserName ", con);
                cmd.Parameters.AddWithValue("@UserName", lblUser.Text);


                con.Open();


                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                cmd.ExecuteNonQuery();

                if (dt.Rows.Count.Equals(1))
                {
                    status = dt.Rows[0][0].ToString().Trim();
                    if (status == "1")
                    {
                        Warden wr = new Warden(lblUser.Text);
                        this.Hide();
                        wr.Show();
                    }
                    else if (status == "2")
                    {
                        Jailor j = new Jailor(lblUser.Text);
                        this.Hide();
                        j.Show();
                    }

                    else if (status == "3")
                    {
                        Receptionist rc = new Receptionist(lblUser.Text);
                        this.Hide();
                        rc.Show();
                    }
                    else if (status == "4")
                    {
                        Doctor d = new Doctor(lblUser.Text);
                        this.Hide();
                        d.Show();
                    }
                }
                else
                {
                   
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
