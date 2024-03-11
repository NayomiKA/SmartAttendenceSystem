using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAttendenceSystem
{
    public partial class frmMenuWindow : Form
    {
        public frmMenuWindow()
        {
            InitializeComponent();
        }

        private void btnCreateQR_Click(object sender, EventArgs e)
        {
            AddNewStudent b = new AddNewStudent();
            b.Show();
            
        }

        private void btnAttendenceSummary_Click(object sender, EventArgs e)
        {
            AttendenceSummary b = new AttendenceSummary();
            b.Show();
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Do you want to logout? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Close();
            }
          
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            StudentInformation b = new StudentInformation();
            b.Show();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            CheckAttendence b = new CheckAttendence();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewAdmin b = new AddNewAdmin();
            b.Show();
        }
    }
}
