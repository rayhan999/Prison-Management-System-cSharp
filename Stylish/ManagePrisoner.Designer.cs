namespace Stylish
{
    partial class ManagePrisoner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePrisoner));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picPrisoner = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textNID = new System.Windows.Forms.TextBox();
            this.Release = new System.Windows.Forms.Button();
            this.Refresh1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.dtpEntry = new System.Windows.Forms.DateTimePicker();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.textCell = new System.Windows.Forms.TextBox();
            this.textCrime = new System.Windows.Forms.TextBox();
            this.textPName = new System.Windows.Forms.TextBox();
            this.textPID = new System.Windows.Forms.TextBox();
            this.txtNid = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCrime = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.Label();
            this.txtPrisonerName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPrisoner = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrisoner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 80);
            this.panel2.TabIndex = 44;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcome.Location = new System.Drawing.Point(349, 57);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 23);
            this.lblWelcome.TabIndex = 45;
            this.lblWelcome.Text = "You\'re logged in as:";
            this.lblWelcome.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUser.Location = new System.Drawing.Point(512, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(106, 23);
            this.lblUser.TabIndex = 44;
            this.lblUser.Text = "lblUserName";
            this.lblUser.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 38);
            this.btnBack.TabIndex = 44;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(913, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(321, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Prisoner";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBrowse.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(618, 195);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 22);
            this.btnBrowse.TabIndex = 68;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picPrisoner
            // 
            this.picPrisoner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPrisoner.Location = new System.Drawing.Point(474, 100);
            this.picPrisoner.Name = "picPrisoner";
            this.picPrisoner.Size = new System.Drawing.Size(138, 117);
            this.picPrisoner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPrisoner.TabIndex = 67;
            this.picPrisoner.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(474, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(490, 167);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textNID
            // 
            this.textNID.Location = new System.Drawing.Point(191, 390);
            this.textNID.Margin = new System.Windows.Forms.Padding(2);
            this.textNID.Name = "textNID";
            this.textNID.Size = new System.Drawing.Size(232, 20);
            this.textNID.TabIndex = 65;
            // 
            // Release
            // 
            this.Release.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Release.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Release.Location = new System.Drawing.Point(707, 461);
            this.Release.Margin = new System.Windows.Forms.Padding(2);
            this.Release.Name = "Release";
            this.Release.Size = new System.Drawing.Size(88, 50);
            this.Release.TabIndex = 64;
            this.Release.Text = "RELEASE";
            this.Release.UseVisualStyleBackColor = false;
            this.Release.Click += new System.EventHandler(this.Release_Click);
            // 
            // Refresh1
            // 
            this.Refresh1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Refresh1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh1.Location = new System.Drawing.Point(558, 461);
            this.Refresh1.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh1.Name = "Refresh1";
            this.Refresh1.Size = new System.Drawing.Size(88, 50);
            this.Refresh1.TabIndex = 63;
            this.Refresh1.Text = "REFRESH";
            this.Refresh1.UseVisualStyleBackColor = false;
            this.Refresh1.Click += new System.EventHandler(this.Refresh1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(406, 461);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 50);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(261, 461);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 50);
            this.save.TabIndex = 61;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // dtpEntry
            // 
            this.dtpEntry.Location = new System.Drawing.Point(191, 232);
            this.dtpEntry.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEntry.Name = "dtpEntry";
            this.dtpEntry.Size = new System.Drawing.Size(206, 20);
            this.dtpEntry.TabIndex = 59;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Location = new System.Drawing.Point(191, 316);
            this.dtpRelease.Margin = new System.Windows.Forms.Padding(2);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(206, 20);
            this.dtpRelease.TabIndex = 58;
            // 
            // textCell
            // 
            this.textCell.Location = new System.Drawing.Point(191, 351);
            this.textCell.Margin = new System.Windows.Forms.Padding(2);
            this.textCell.Name = "textCell";
            this.textCell.Size = new System.Drawing.Size(232, 20);
            this.textCell.TabIndex = 57;
            // 
            // textCrime
            // 
            this.textCrime.Location = new System.Drawing.Point(191, 190);
            this.textCrime.Margin = new System.Windows.Forms.Padding(2);
            this.textCrime.Name = "textCrime";
            this.textCrime.Size = new System.Drawing.Size(232, 20);
            this.textCrime.TabIndex = 56;
            // 
            // textPName
            // 
            this.textPName.Location = new System.Drawing.Point(191, 145);
            this.textPName.Margin = new System.Windows.Forms.Padding(2);
            this.textPName.Name = "textPName";
            this.textPName.Size = new System.Drawing.Size(232, 20);
            this.textPName.TabIndex = 55;
            // 
            // textPID
            // 
            this.textPID.Location = new System.Drawing.Point(191, 105);
            this.textPID.Margin = new System.Windows.Forms.Padding(2);
            this.textPID.Name = "textPID";
            this.textPID.Size = new System.Drawing.Size(232, 20);
            this.textPID.TabIndex = 54;
            // 
            // txtNid
            // 
            this.txtNid.AutoSize = true;
            this.txtNid.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNid.Location = new System.Drawing.Point(142, 393);
            this.txtNid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNid.Name = "txtNid";
            this.txtNid.Size = new System.Drawing.Size(32, 14);
            this.txtNid.TabIndex = 53;
            this.txtNid.Text = "NID:";
            // 
            // txtCellNo
            // 
            this.txtCellNo.AutoSize = true;
            this.txtCellNo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCellNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCellNo.Location = new System.Drawing.Point(113, 354);
            this.txtCellNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(61, 14);
            this.txtCellNo.TabIndex = 52;
            this.txtCellNo.Text = "CELL NO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(76, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 51;
            this.label5.Text = "RELEASE DATE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(88, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 50;
            this.label4.Text = "ENTRY DATE:";
            // 
            // txtCrime
            // 
            this.txtCrime.AutoSize = true;
            this.txtCrime.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCrime.Location = new System.Drawing.Point(126, 190);
            this.txtCrime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCrime.Name = "txtCrime";
            this.txtCrime.Size = new System.Drawing.Size(48, 14);
            this.txtCrime.TabIndex = 49;
            this.txtCrime.Text = "CRIME:";
            // 
            // txtPID
            // 
            this.txtPID.AutoSize = true;
            this.txtPID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPID.Location = new System.Drawing.Point(105, 110);
            this.txtPID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(69, 14);
            this.txtPID.TabIndex = 48;
            this.txtPID.Text = "Prisoner Id";
            // 
            // txtPrisonerName
            // 
            this.txtPrisonerName.AutoSize = true;
            this.txtPrisonerName.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrisonerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrisonerName.Location = new System.Drawing.Point(78, 150);
            this.txtPrisonerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPrisonerName.Name = "txtPrisonerName";
            this.txtPrisonerName.Size = new System.Drawing.Size(96, 14);
            this.txtPrisonerName.TabIndex = 47;
            this.txtPrisonerName.Text = "Prisoner Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 70;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(471, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Prisoner Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(795, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(93, 72);
            this.dataGridView2.TabIndex = 72;
            this.dataGridView2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(704, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Total Prisoner:";
            // 
            // txtTotalPrisoner
            // 
            this.txtTotalPrisoner.Location = new System.Drawing.Point(788, 107);
            this.txtTotalPrisoner.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrisoner.Name = "txtTotalPrisoner";
            this.txtTotalPrisoner.Size = new System.Drawing.Size(52, 20);
            this.txtTotalPrisoner.TabIndex = 74;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(138, 461);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 50);
            this.btnLoad.TabIndex = 75;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(191, 279);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(44, 20);
            this.txtYear.TabIndex = 77;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(55, 282);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 76;
            this.label3.Text = "Punishment Period:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(270, 279);
            this.txtMonth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(49, 20);
            this.txtMonth.TabIndex = 78;
            this.txtMonth.TextChanged += new System.EventHandler(this.txtMonth_TextChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(353, 279);
            this.txtDays.Margin = new System.Windows.Forms.Padding(2);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(44, 20);
            this.txtDays.TabIndex = 79;
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(192, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(267, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Months";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(350, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Days";
            // 
            // ManagePrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtTotalPrisoner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picPrisoner);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textNID);
            this.Controls.Add(this.Release);
            this.Controls.Add(this.Refresh1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dtpEntry);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.textCell);
            this.Controls.Add(this.textCrime);
            this.Controls.Add(this.textPName);
            this.Controls.Add(this.textPID);
            this.Controls.Add(this.txtNid);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCrime);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtPrisonerName);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "ManagePrisoner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePrisoner";
            this.Load += new System.EventHandler(this.ManagePrisoner_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPrisoner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picPrisoner;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNID;
        private System.Windows.Forms.Button Release;
        private System.Windows.Forms.Button Refresh1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker dtpEntry;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.TextBox textCell;
        private System.Windows.Forms.TextBox textCrime;
        private System.Windows.Forms.TextBox textPName;
        private System.Windows.Forms.TextBox textPID;
        private System.Windows.Forms.Label txtNid;
        private System.Windows.Forms.Label txtCellNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCrime;
        private System.Windows.Forms.Label txtPID;
        private System.Windows.Forms.Label txtPrisonerName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPrisoner;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}