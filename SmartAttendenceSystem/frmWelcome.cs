using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAttendenceSystem
{
    public partial class frmWelcome : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public frmWelcome()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=StudentAttendanceSystem.mdb";
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
          

            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from admins where UserName = '" + txtUserName.Text + "' and PassWord='" + txtpwd.Text + "'";

            OleDbDataReader reader = command.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count==1)
            {
               
                MessageBox.Show("Username and password is correct.", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuWindow b = new frmMenuWindow();
                
                b.Show();
                Hide();
            }
            else if (count>1)
            {
                
                DialogResult response = MessageBox.Show("Duplicate UserName and password", "Access Declined", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Retry)
                {
                    txtpwd.SelectionStart = 0;
                    txtpwd.SelectionLength = txtpwd.Text.Length;
                    txtUserName.SelectionStart = 0;
                    txtUserName.SelectionLength = txtUserName.Text.Length;
                    txtUserName.Focus();
                    
                }
                else
                {
                    Close();
                }

            }
            else
            {
               

                DialogResult response = MessageBox.Show("UserName and password is incorrect.", "Access Declined", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (response == DialogResult.Retry)
                {
                    txtpwd.SelectionStart = 0;
                    txtpwd.SelectionLength = txtpwd.Text.Length;
                    txtUserName.SelectionStart = 0;
                    txtUserName.SelectionLength = txtUserName.Text.Length;
                    txtUserName.Focus();

                }
                else
                {
                    Close();
                }
            }

            


            
            connection.Close();
        }

       

        
    }
}
