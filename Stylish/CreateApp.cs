using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Stylish
{
    public partial class CreateApp : Form
    {
        public CreateApp(string UserName)
        {
            InitializeComponent();
            FillCombo();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";
        }

        

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                 "database = CSProject;" +
                                 "integrated security = SSPI");

        DataTable dt;
       

        private void FillCombo()
        {
            SqlCommand cmd = new SqlCommand("Select * from Employee where Status='"+ 4 +"' ", con);
      


            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string str = sdr.GetString(2);
                comDocName.Items.Add(str);
            }
            con.Close();

      
        }

        private void CreateApp_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            LoadAll();
        }

        private void LoadAll()
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

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            textPID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textPName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textCrime.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dtpEntry.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dtpRelease.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textCell.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textNID.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            byte[] bytes = (byte[])dataGridView1.SelectedRows[0].Cells[8].Value;
            MemoryStream ms = new MemoryStream(bytes);
            picPrisoner.Image = Image.FromStream(ms);
            btnSave.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("PrisonerName like '{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

        private bool IsValid()
        {
            if (textPName.Text == string.Empty)
            {
                MessageBox.Show("Prisoner ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    

                    SqlCommand cmd = new SqlCommand("Insert into CreateApp VALUES(@PrisonerId,@PrisonerName,@Crime,@EntryDate,@ReleaseDate,@CellNo,@Nid,@Image,@DocName)", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@PrisonerId", textPID.Text);
                    cmd.Parameters.AddWithValue("@PrisonerName", textPName.Text);
                    cmd.Parameters.AddWithValue("@Crime", textCrime.Text);
                    cmd.Parameters.Add("@EntryDate", SqlDbType.DateTime, 500).Value = DateTime.Now;
                    cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime, 500).Value = dtpRelease.Value.Date;
                    cmd.Parameters.AddWithValue("@CellNo", textCell.Text);
                    cmd.Parameters.AddWithValue("@Nid", textNID.Text);
                    cmd.Parameters.AddWithValue("@Image", SaveImage());
                    cmd.Parameters.Add("@DocName", SqlDbType.NVarChar, 50).Value = comDocName.SelectedItem.ToString();



                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Appointment created Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private byte[] SaveImage()
        {
            MemoryStream ms = new MemoryStream();
            picPrisoner.Image.Save(ms, picPrisoner.Image.RawFormat);
            return ms.GetBuffer();
        }


        private void refresh()
        {
            textPID.Text = "";
            textPName.Text = "";
            textCrime.Text = "";
            dtpEntry.Value = DateTime.Now;
            dtpRelease.Value = DateTime.Now;
            textCell.Text = "";
            textNID.Text = "";
            picPrisoner.Image = null;

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Jailor j = new Jailor(lblUser.Text);
            this.Hide();
            j.Show();
        }
    }
}
