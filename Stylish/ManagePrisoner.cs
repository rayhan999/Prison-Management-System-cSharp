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
    public partial class ManagePrisoner : Form
    {
        public ManagePrisoner(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome. You're logged in as: ";
            this.dtpEntry.Enabled = false;
            this.dtpRelease.Enabled = false;
        }

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                "database = CSProject;" +
                                "integrated security = SSPI");

        DataTable dt;
        

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("PrisonerName like '{0}%'", textBox1.Text);
            dataGridView1.DataSource = dv;
        }

       private void getAll()
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
                txtTotalPrisoner.Text = (x - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private bool cell_check()
        {

            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("CellNo like '{0}'", Convert.ToInt32(textCell.Text));
            dataGridView2.DataSource = dv;
            if (dataGridView2.Rows.Count > 4)
            {
                MessageBox.Show("Cell is fillup");
                textCell.Text = "";
                return true;
            }
            else { return false; }

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cell_check())
                {
                    return;
                }

                if (IsValid())
                {
                   

                    SqlCommand cmd = new SqlCommand("Insert into Prisoner VALUES(@PrisonerId,@PrisonerName,@Crime,@EntryDate,@ReleaseDate,@CellNo,@Nid,@image)", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PrisonerId", textPID.Text);
                    cmd.Parameters.AddWithValue("@PrisonerName", textPName.Text);
                    cmd.Parameters.AddWithValue("@Crime", textCrime.Text);
                    cmd.Parameters.Add("@EntryDate", SqlDbType.DateTime, 500).Value = DateTime.Now;
                    cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime, 500).Value = dtpRelease.Value.Date;
                    cmd.Parameters.AddWithValue("@CellNo", textCell.Text);
                    cmd.Parameters.AddWithValue("@Nid", textNID.Text);
                    cmd.Parameters.AddWithValue("@image", SaveImage());



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Prisoner Info saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    refresh();
                    getAll();
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

       

        private bool IsValid()
        {
            if (textPName.Text == string.Empty)
            {
                MessageBox.Show("Prisoner ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void refresh()
        {
            textPID.Text = "";
            textPName.Text = "";
            textCrime.Text = "";
            dtpEntry.Value = DateTime.Now;
            txtYear.Text = "";
            txtMonth.Text = "";
            txtDays.Text = "";
            dtpRelease.Value = DateTime.Now;
            textCell.Text = "";
            textNID.Text = "";
            picPrisoner.Image = null;

        }

       
    


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                   
                    SqlCommand cmd = new SqlCommand("Update Prisoner set  PrisonerName= @PrisonerName,Crime = @Crime,EntryDate = @EntryDate,ReleaseDate= @ReleaseDate,CellNo= @CellNo,Nid= @Nid,Image= @image where PrisonerId= @PrisonerId", con);


                    cmd.Parameters.AddWithValue("@PrisonerId", textPID.Text);
                    cmd.Parameters.AddWithValue("@PrisonerName", textPName.Text);
                    cmd.Parameters.AddWithValue("@Crime", textCrime.Text);
                    cmd.Parameters.Add("@EntryDate", SqlDbType.DateTime, 500).Value = dtpEntry.Value.Date;
                    cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime, 500).Value = dtpRelease.Value.Date;
                    cmd.Parameters.AddWithValue("@CellNo", textCell.Text);
                    cmd.Parameters.AddWithValue("@Nid", textNID.Text);
                    cmd.Parameters.AddWithValue("@image", SaveImage());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Row Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    refresh();

                    getAll();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Refresh1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        public void RemovePrisoner()
        {
           SqlCommand cmd = new SqlCommand("Delete from Prisoner where PrisonerId='" + textPID.Text + "'", con);
              

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                
        }

        private void Release_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dresult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dresult == DialogResult.Yes)
                {
                   
                    SqlCommand cmd = new SqlCommand("Insert into Released_Prisoner VALUES(@PrisonerId,@PrisonerName,@Crime,@EntryDate,@ReleaseDate,@CellNo,@Nid,@image)", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@PrisonerId", textPID.Text);
                    cmd.Parameters.AddWithValue("@PrisonerName", textPName.Text);
                    cmd.Parameters.AddWithValue("@Crime", textCrime.Text);
                    cmd.Parameters.Add("@EntryDate", SqlDbType.DateTime, 500).Value = dtpEntry.Value.Date;
                    cmd.Parameters.Add("@ReleaseDate", SqlDbType.DateTime, 500).Value = DateTime.Now;
                    cmd.Parameters.AddWithValue("@CellNo", textCell.Text);
                    cmd.Parameters.AddWithValue("@Nid", textNID.Text);
                   cmd.Parameters.AddWithValue("@image", SaveImage());


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Info Added in Released Prisoner List", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RemovePrisoner();
                    refresh();
                    getAll();

                   

                }
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
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
           Jailor j = new Jailor(lblUser.Text);
            this.Hide();
            j.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Select Image";
            o.Filter = "Image File(*.png;*.jpg;*.jpeg)| *.png; *.jpg; *.jpeg";
         
            if (o.ShowDialog() == DialogResult.OK)
            {
                picPrisoner.Image = new Bitmap(o.FileName);
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagePrisoner_Load(object sender, EventArgs e)
        {
            getAll();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (txtYear.Text.Length >= 1)
            {
                dtpRelease.Value = DateTime.Now.AddYears(Convert.ToInt32(txtYear.Text));
            }
            else { dtpRelease.Value = DateTime.Now; }
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            if (txtDays.Text.Length >= 1)
            { dtpRelease.Value = DateTime.Now.AddDays(Convert.ToInt32(txtDays.Text)); }
            else { dtpRelease.Value = DateTime.Now; }
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtMonth.Text.Length >= 1)
            { dtpRelease.Value = DateTime.Now.AddMonths(Convert.ToInt32(txtMonth.Text)); }

            else { dtpRelease.Value = DateTime.Now; }
        }
    }
}
