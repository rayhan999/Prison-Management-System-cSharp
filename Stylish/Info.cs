using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
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
    public partial class Info : Form
    {
        public Info(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
           
        }

        public string status,a,x,y,z;

       

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                              "database = CSProject;" +
                              "integrated security = SSPI");

        DataTable dt;

        private void Info_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadMap()
        {
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLongt.Text);
            map.Position = new PointLatLng(lat, longt);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 17;
            map.DragButton = MouseButtons.Right;

        }

       

        private void Database()
        {
            
        }

        private void TotalPrisoner()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Prisoner", con);
                dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dt;

               
                int x = dataGridView1.Rows.Count;
                txtPrisoner.Text = (x - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalReleasedprisoner()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Released_Prisoner", con);
                dt = new DataTable();

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();

                dataGridView1.DataSource = dt;

              
                int x = dataGridView1.Rows.Count;
                txtReleasedPrisoner.Text = (x - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void TotalWarden()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee where Status=" + lblWarden.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int x = dataGridView1.Rows.Count;
            txtWarden.Text = (x - 1).ToString();
        }

        private void enableUpdate()
        {
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtLat.Text = "23.737418";
            txtLongt.Text = "90.396271";
            txtCell.Text = "300";
            txtAddress.Text = "Shahbag";
            LoadMap();
            TotalPrisoner();
            TotalReleasedprisoner();
            TotalWarden();
            TotalJailor();
            TotalRecep();
            TotalDoctors();
        }

        private void TotalJailor()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee where Status=" + lblJailor.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int x = dataGridView1.Rows.Count;
            txtJailor.Text = (x - 1).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalRecep()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee where Status=" + lblRecep.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int x = dataGridView1.Rows.Count;
            txtReceptionist.Text = (x - 1).ToString();
        }

        private void TotalDoctors()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Employee where Status=" + lblDoctor.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;

            int x = dataGridView1.Rows.Count;
            txtDoctor.Text = (x - 1).ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
