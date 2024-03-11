namespace SmartAttendenceSystem
{
    partial class QRCodeGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.txtNmae = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCreateQR);
            this.panel1.Controls.Add(this.txtNmae);
            this.panel1.Controls.Add(this.txtReg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 590);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateQR.BackColor = System.Drawing.Color.Magenta;
            this.btnCreateQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateQR.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateQR.Location = new System.Drawing.Point(86, 433);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(269, 101);
            this.btnCreateQR.TabIndex = 10;
            this.btnCreateQR.Text = "Generate QR Code";
            this.btnCreateQR.UseVisualStyleBackColor = false;
            this.btnCreateQR.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // txtNmae
            // 
            this.txtNmae.Location = new System.Drawing.Point(217, 134);
            this.txtNmae.Name = "txtNmae";
            this.txtNmae.Size = new System.Drawing.Size(180, 22);
            this.txtNmae.TabIndex = 3;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(217, 69);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(180, 22);
            this.txtReg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name : ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegNo : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtSave);
            this.panel2.Controls.Add(this.txtReview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(476, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 590);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(137, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtSave
            // 
            this.txtSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSave.BackColor = System.Drawing.Color.Magenta;
            this.txtSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSave.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSave.Location = new System.Drawing.Point(170, 343);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(269, 101);
            this.txtSave.TabIndex = 12;
            this.txtSave.Text = "Save to Data";
            this.txtSave.UseVisualStyleBackColor = false;
            // 
            // txtReview
            // 
            this.txtReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReview.BackColor = System.Drawing.Color.Magenta;
            this.txtReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtReview.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReview.Location = new System.Drawing.Point(170, 459);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(269, 101);
            this.txtReview.TabIndex = 11;
            this.txtReview.Text = "Review Sample ID";
            this.txtReview.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Grade";
            // 
            // QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QRCodeGenerator";
            this.Text = "QR Code Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNmae;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateQR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.Button txtReview;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}