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
    public partial class ManageEmp : Form
    {
        public ManageEmp(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";

            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";
            comboBox1.DataSource = gender;

            string[] designation = new string[4];
            designation[0] = "Warden";
            designation[1] = "Jailor";
            designation[2] = "Receptionist";
            designation[3] = "Doctor";
            comboBox2.DataSource = designation;
        }

        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                                  "database = CSProject;" +
                                  "integrated security = SSPI");

        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
      


        User u = new User();

        private void ManageEmp_Load(object sender, EventArgs e)
        {
            refresh();
            DisplayData();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DoubleUserID())
                {
                    return;
                }

                GeneratePass();
                GenerateStatus();

                

                cmd = new SqlCommand("Insert into Employee VALUES(@Id, @Name, @Gender, @DOB, @Designation, @Salary,@Email, @Address, @Image, @UserName, @Password , @Status)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = comboBox1.SelectedItem.ToString();
                cmd.Parameters.Add("@DOB", SqlDbType.DateTime, 500).Value = dtpDOB.Value;
                cmd.Parameters.Add("@Designation", SqlDbType.NVarChar, 50).Value = comboBox2.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@Salary", Convert.ToSingle(txtSalary.Text));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Image", SaveImage());
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", u.password);
                cmd.Parameters.AddWithValue("@Status", u.status);



                con.Open();
                cmd.ExecuteNonQuery();
               
                con.Close();
                refresh();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] SaveImage()
        {
            MemoryStream ms = new MemoryStream();
            picEmp.Image.Save(ms, picEmp.Image.RawFormat);
            return ms.GetBuffer();
        }

        private bool DoubleUserID()
        {
           
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("UserName like '{0}'", txtUserName.Text);
            dataGridView2.DataSource = dv;
            if (dataGridView2.Rows.Count > 1)
            {
                MessageBox.Show("Duplicate UserName found");
                txtUserName.Text = "";
                return true;
            }
            else { return false; }

        }
        private void GeneratePass()
        {

            int minLength = 4;
            int maxLength = 4;

            string charAvailable = "qwertyuioplkjhgfdsazxcvbnm0123456789";

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            int passwordLength = random.Next(minLength, maxLength + 1);

            while (passwordLength-- > 0)
                password.Append(charAvailable[random.Next(charAvailable.Length)]);

            u.password = password.ToString();
            MessageBox.Show("Employee Info saved Successfully. Password: " + password.ToString(), "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void GenerateStatus()
        {

            if ((comboBox2.SelectedItem.ToString().ToLower() == "warden"))
            {
                u.status = 1;
            }
            else if ((comboBox2.SelectedItem.ToString().ToLower() == "jailor"))
            {
                u.status = 2;
            }
            else if ((comboBox2.SelectedItem.ToString().ToLower() == "receptionist"))
            {
                u.status = 3;
            }
            else if ((comboBox2.SelectedItem.ToString().ToLower() == "doctor"))
            {
                u.status = 4;
            }
        
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                cmd = new SqlCommand("UPDATE Employee SET Name=@Name, Gender=@Gender , DOB=@DOB, Designation=@Designation, Salary=@Salary,Email=@Email,Address=@Address, Image=@Image where EmpID='" + txtEmpId.Text + "'", con);
                con.Open();


                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = comboBox1.SelectedItem.ToString();
                cmd.Parameters.Add("@DOB", SqlDbType.DateTime, 500).Value = dtpDOB.Value;
                cmd.Parameters.Add("@Designation", SqlDbType.NVarChar, 50).Value = comboBox2.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@Salary", Convert.ToSingle(txtSalary.Text));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Image", SaveImage());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();

                refresh();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Delete from Employee where EmpID='" + txtEmpId.Text + "'", con);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                refresh();
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
            Warden j = new Warden(lblUser.Text);
            this.Hide();
            j.Show();
        }
        private void DisplayData()
        {
            con.Open();
            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT EmpId,Name,Gender,DOB,Designation,salary,Email,Address,Image,UserName FROM Employee", con);
            adapt.Fill(dt);
            dgvEmp.DataSource = dt;
            con.Close();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmp.SelectedRows.Count == 0)
                return;

            txtEmpId.Text = dgvEmp.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgvEmp.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dgvEmp.SelectedRows[0].Cells[2].Value.ToString();
            dtpDOB.Text = dgvEmp.SelectedRows[0].Cells[3].Value.ToString();


            comboBox2.Text = dgvEmp.SelectedRows[0].Cells[4].Value.ToString();
            txtSalary.Text = dgvEmp.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = dgvEmp.SelectedRows[0].Cells[6].Value.ToString();
            txtAddress.Text = dgvEmp.SelectedRows[0].Cells[7].Value.ToString();
            byte[] bytes = (byte[])dgvEmp.SelectedRows[0].Cells[8].Value;
            MemoryStream ms = new MemoryStream(bytes);
            picEmp.Image = Image.FromStream(ms);
            txtUserName.Text = dgvEmp.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("Name like '{0}%'", textBox1.Text);
            dgvEmp.DataSource = dv;


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Select Image";
            o.Filter = "Image File(*.png;*.jpg;*.jpeg)| *.png; *.jpg; *.jpeg";
           
            if (o.ShowDialog() == DialogResult.OK)
            {
                picEmp.Image = new Bitmap(o.FileName);
            }
        }

        private void refresh()
        {
            txtEmpId.Text = "";
            txtName.Text = "";
            dtpDOB.Value = DateTime.Now;
            comboBox2.SelectedIndex = -1;
            txtSalary.Text = "";
            txtAddress.Text = "";
            comboBox1.SelectedIndex = -1;
            txtEmail.Text = "";
            txtUserName.Text = "";
            picEmp.Image = null;

        }
    }
}
