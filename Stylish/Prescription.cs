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
    public partial class Prescription : Form
    {
        public Prescription(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            lblWelcome.Text = "Welcome.You're logged in as:";
            this.dateTimePicker1.Enabled = false;

            string[] med = new string[3];
            med[0] = "Tablet";
            med[1] = "Syrup";
            med[2] = "Injection";

            comboBox1.DataSource = med;
            string[] med1 = new string[3];
            med1[0] = "Tablet";
            med1[1] = "Syrup";
            med1[2] = "Injection";
            comboBox2.DataSource = med1;
            string[] med2 = new string[3];
            med2[0] = "Tablet";
            med2[1] = "Syrup";
            med2[2] = "Injection";
            comboBox3.DataSource = med2;
            string[] med3 = new string[3];
            med3[0] = "Tablet";
            med3[1] = "Syrup";
            med3[2] = "Injection";
            comboBox4.DataSource = med3;
            string[] med4 = new string[3];
            med4[0] = "Tablet";
            med4[1] = "Syrup";
            med4[2] = "Injection";
            comboBox5.DataSource = med4;
        }

       
        SqlConnection con = new SqlConnection("data source = DESKTOP-PLBQ95Q\\MAHI;" +
                               "database = CSProject;" +
                               "integrated security = SSPI");
        DataTable dt;
       

        private bool IsValid()
        {
            if (textPID.Text == string.Empty)
            {
                MessageBox.Show("Prisoner ID is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {


                    SqlCommand cmd = new SqlCommand("Insert into Prescription VALUES(@PID,@PName,@Problem,@BP,@Visit,@Date,@Test1,@Test2,@Test3,@Test4,@Med1,@MName1,@MTime1,@Med2,@MName2,@MTime2,@Med3,@MName3,@MTime3,@Med4,@MName4,@MTime4,@Med5,@MName5,@MTime5,@Advice)", con);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PID", textPID.Text);
                    cmd.Parameters.AddWithValue("@PName", textPName.Text);
                    cmd.Parameters.AddWithValue("@Problem", txtPrb.Text);
                    cmd.Parameters.AddWithValue("@BP", txtBP.Text);
                    cmd.Parameters.AddWithValue("@Visit", txtVisit.Text);
                    cmd.Parameters.Add("@Date", SqlDbType.DateTime, 500).Value = DateTime.Now;
                    cmd.Parameters.AddWithValue("@Test1", txtTest1.Text);
                    cmd.Parameters.AddWithValue("@Test2", txtTest2.Text);
                    cmd.Parameters.AddWithValue("@Test3", txtTest3.Text);
                    cmd.Parameters.AddWithValue("@Test4", txtTest4.Text);
                    cmd.Parameters.Add("@Med1", SqlDbType.NVarChar, 50).Value = comboBox1.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@MName1", txtMed1.Text);
                    cmd.Parameters.AddWithValue("@MTime1", txtTime1.Text);
                    cmd.Parameters.Add("@Med2", SqlDbType.NVarChar, 50).Value = comboBox2.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@MName2", txtMed2.Text);
                    cmd.Parameters.AddWithValue("@MTime2", txtTime2.Text);
                    cmd.Parameters.Add("@Med3", SqlDbType.NVarChar, 50).Value = comboBox3.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@MName3", txtMed3.Text);
                    cmd.Parameters.AddWithValue("@MTime3", txtTime3.Text);
                    cmd.Parameters.Add("@Med4", SqlDbType.NVarChar, 50).Value = comboBox4.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@MName4", txtMed4.Text);
                    cmd.Parameters.AddWithValue("@MTime4", txtTime4.Text);
                    cmd.Parameters.Add("@Med5", SqlDbType.NVarChar, 50).Value = comboBox5.SelectedItem.ToString();
                    cmd.Parameters.AddWithValue("@MName5", txtMed5.Text);
                    cmd.Parameters.AddWithValue("@MTime5", txtTime5.Text);
                    cmd.Parameters.AddWithValue("@Advice", richTextBox1.Text);




                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Prisoner Info saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    refresh();
                    GetAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh()
        {
            textPID.Text = "";
            textPName.Text = "";
            txtPrb.Text = "";
            txtBP.Text = "";
            txtVisit.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtTest1.Text = "";
             txtTest2.Text = "";
            txtTest3.Text = "";
            txtTest4.Text = "";
          
            txtMed1.Text = "";
            txtTime1.Text = "";
          
            txtMed2.Text = "";
            txtTime2.Text = "";
          
            txtMed3.Text = "";
            txtTime3.Text = "";
           
            txtMed4.Text = "";
            txtTime4.Text = "";
          
            txtMed5.Text = "";
            txtTime5.Text = "";
            richTextBox1.Text = "";

        }

        private void GetAll()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Prescription", con);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Doctor j = new Doctor(lblUser.Text);
            this.Hide();
            j.Show();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            GetAll();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void textBox18_Leave(object sender, EventArgs e)
        {
            
        }

        private void textPID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("PID like '{0}%'", textBox18.Text);
            dataGridView1.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("Update Prescription set PName= @PName,Problem= @Problem, BP= @BP,Visit= @Visit,Date= @Date,Test1= @Test1,Test2= @Test2,Test3= @Test3,Test4= @Test4,Med1= @Med1,MName1= @MName1,MTime1= @MTime1,Med2= @Med2,MName2= @MName2,MTime2= @MTime2,Med3= @Med3,MName3= @MName3,MTime3= @MTime3,Med4= @Med4,MName4= @MName4,Mtime4= @MTime4,Med5= @Med5,MName5= @MName5,MTime5= @MTime5,Advice= @Advice where PID= @PID", con);


                cmd.Parameters.AddWithValue("@PID", textPID.Text);
                cmd.Parameters.AddWithValue("@PName", textPName.Text);
                cmd.Parameters.AddWithValue("@Problem", txtPrb.Text);
                cmd.Parameters.AddWithValue("@BP", txtBP.Text);
                cmd.Parameters.AddWithValue("@Visit", txtVisit.Text);
                cmd.Parameters.Add("@Date", SqlDbType.DateTime, 500).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@Test1", txtTest1.Text);
                cmd.Parameters.AddWithValue("@Test2", txtTest2.Text);
                cmd.Parameters.AddWithValue("@Test3", txtTest3.Text);
                cmd.Parameters.AddWithValue("@Test4", txtTest4.Text);
                cmd.Parameters.Add("@Med1", SqlDbType.NVarChar, 50).Value = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@MName1", txtMed1.Text);
                cmd.Parameters.AddWithValue("@MTime1", txtTime1.Text);
                cmd.Parameters.Add("@Med2", SqlDbType.NVarChar, 50).Value = comboBox2.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@MName2", txtMed2.Text);
                cmd.Parameters.AddWithValue("@MTime2", txtTime2.Text);
                cmd.Parameters.Add("@Med3", SqlDbType.NVarChar, 50).Value = comboBox3.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@MName3", txtMed3.Text);
                cmd.Parameters.AddWithValue("@MTime3", txtTime3.Text);
                cmd.Parameters.Add("@Med4", SqlDbType.NVarChar, 50).Value = comboBox4.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@MName4", txtMed4.Text);
                cmd.Parameters.AddWithValue("@MTime4", txtTime4.Text);
                cmd.Parameters.Add("@Med5", SqlDbType.NVarChar, 50).Value = comboBox5.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@MName5", txtMed5.Text);
                cmd.Parameters.AddWithValue("@MTime5", txtTime5.Text);
                cmd.Parameters.AddWithValue("@Advice", richTextBox1.Text);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Row Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAll();
                refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Release_Click(object sender, EventArgs e)
        {

        }

        private void Refresh1_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textPID_TextChanged_1(object sender, EventArgs e)
        {
            if (textPID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * from Prisoner where PrisonerID= @PrisonerID", con);
                cmd.Parameters.AddWithValue("@PrisonerID", textPID.Text);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    textPName.Text = sdr.GetValue(2).ToString();

                }
                else
                {
                   
                    textPName.Text = "";
                }
                con.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                return;
      
            textPID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textPName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPrb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBP.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtVisit.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTest1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtTest2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtTest3.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtTest4.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            txtMed1.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            txtTime1.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            txtMed2.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            txtTime2.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
            txtMed3.Text = dataGridView1.SelectedRows[0].Cells[18].Value.ToString();
            txtTime3.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();
            comboBox4.Text = dataGridView1.SelectedRows[0].Cells[20].Value.ToString();
            txtMed4.Text = dataGridView1.SelectedRows[0].Cells[21].Value.ToString();
            txtTime4.Text = dataGridView1.SelectedRows[0].Cells[22].Value.ToString();
            comboBox5.Text = dataGridView1.SelectedRows[0].Cells[23].Value.ToString();
            txtMed5.Text = dataGridView1.SelectedRows[0].Cells[24].Value.ToString();
            txtTime5.Text = dataGridView1.SelectedRows[0].Cells[25].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[26].Value.ToString();
           

        }
    }
}
