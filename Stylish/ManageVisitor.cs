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
    public partial class ManageVisitor : Form
    {
        public ManageVisitor(string UserName)
        {
            InitializeComponent();
            dtpDate.Enabled = false;
            txtPID.Enabled = false;

            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";

            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";
            comGender.DataSource = gender;
        }

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                 "database = CSProject;" +
                                 "integrated security = SSPI");

       


        DataTable dt;

        private void ManageVisitor_Load(object sender, EventArgs e)
        {
            refresh();
            GetAll();
        }

        private bool Error()
        {
            errorProvider1.Clear();
            if (txtPID.Text.Length <= 1)
            {
                errorProvider1.SetError(txtPID, "Please,Enter ID");
                return true;
            }
            else if (txtVisitorName.Text.Length <= 1)
            {
                errorProvider1.SetError(txtVisitorName, "Please,Enter Name");
                return true;
            }
            else if (txtRelation.Text.Length <= 1)
            {
                errorProvider1.SetError(txtRelation, "Please,Enter Visitor Relation");
                return true;
            }
            else if (comGender.SelectedIndex == -1)
            {
                errorProvider1.SetError(comGender, "Please,Enter Gender");
                return true;
            }
            else if (txtAddress.Text.Length <= 1)
            {
                errorProvider1.SetError(txtAddress, "Please,Enter Address");
                return true;
            }
            else if (txtMobile.Text.Length <= 1)
            {
                errorProvider1.SetError(txtMobile, "Please,Enter Mobile Number");
                return true;
            }
            else
            {
                return false;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (Valid())
                {
                    if (Error())
                    {
                        return;
                    }
                    SqlCommand cmd = new SqlCommand("Insert into Visitor VALUES(@PID,@VisitorName,@Relation,@Gender,@Address,@Mobile,@Date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PID", txtPID.Text);
                    cmd.Parameters.AddWithValue("@VisitorName", txtVisitorName.Text);
                    cmd.Parameters.AddWithValue("@Relation", txtRelation.Text);
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = comGender.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime, 500).Value = DateTime.Now;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                  

                    MessageBox.Show("Visitor Info saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    refresh();
                    GetAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
       

        private bool Valid()
        {
           
                SqlCommand cmd = new SqlCommand("Select * from Prisoner where PrisonerId= @PrisonerId", con);
                cmd.Parameters.AddWithValue("@PrisonerId", txtPID.Text);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
               
                if (sdr.HasRows)
                {
                    con.Close();
                    return true;
                }
                else
                {

                   
                    MessageBox.Show("Prisoner Id doesn't match");

                    return false;
                }
             
            
        }

        private void refresh()
        {
            txtPID.Text = "";
            txtVisitorName.Text = "";
            txtRelation.Text = "";
            comGender.SelectedIndex = -1;
            txtAddress.Text = "";
            txtMobile.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void GetAll()
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

        private void txtPrisonerName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("PrisonerName like '{0}%'", txtPrisonerName.Text);
            dataGridView1.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Receptionist rp = new Receptionist(lblUser.Text);
            this.Hide();
            rp.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
