namespace SmartAttendenceSystem
{
    partial class frmMenuWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnAttendenceSummary = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(738, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "SLYTHERIN HIGH SCHOOL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 150);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "QR Attendence system";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SmartAttendenceSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(167, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SmartAttendenceSystem.Properties.Resources.menuwinImg1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnStudentInfo);
            this.panel2.Controls.Add(this.btnAttendenceSummary);
            this.panel2.Controls.Add(this.btnScan);
            this.panel2.Controls.Add(this.btnCreateQR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 495);
            this.panel2.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(506, 304);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 65);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHelp.Location = new System.Drawing.Point(307, 304);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(154, 65);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudentInfo.BackColor = System.Drawing.Color.Maroon;
            this.btnStudentInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentInfo.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudentInfo.Location = new System.Drawing.Point(192, 182);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(269, 101);
            this.btnStudentInfo.TabIndex = 12;
            this.btnStudentInfo.Text = "Student Information";
            this.btnStudentInfo.UseVisualStyleBackColor = false;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnAttendenceSummary
            // 
            this.btnAttendenceSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttendenceSummary.BackColor = System.Drawing.Color.Maroon;
            this.btnAttendenceSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendenceSummary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendenceSummary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttendenceSummary.Location = new System.Drawing.Point(506, 182);
            this.btnAttendenceSummary.Name = "btnAttendenceSummary";
            this.btnAttendenceSummary.Size = new System.Drawing.Size(269, 101);
            this.btnAttendenceSummary.TabIndex = 11;
            this.btnAttendenceSummary.Text = "Attendence Summary";
            this.btnAttendenceSummary.UseVisualStyleBackColor = false;
            this.btnAttendenceSummary.Click += new System.EventHandler(this.btnAttendenceSummary_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnScan.BackColor = System.Drawing.Color.Maroon;
            this.btnScan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScan.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScan.Location = new System.Drawing.Point(506, 39);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(269, 101);
            this.btnScan.TabIndex = 10;
            this.btnScan.Text = "Scan for attendance";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateQR.BackColor = System.Drawing.Color.Maroon;
            this.btnCreateQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateQR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateQR.Location = new System.Drawing.Point(192, 39);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(269, 101);
            this.btnCreateQR.TabIndex = 9;
            this.btnCreateQR.Text = "Add New Student";
            this.btnCreateQR.UseVisualStyleBackColor = false;
            this.btnCreateQR.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(813, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 101);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add New Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenuWindow";
            this.Text = "QR attendence system";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnAttendenceSummary;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnCreateQR;
        private System.Windows.Forms.Button button1;
    }
}