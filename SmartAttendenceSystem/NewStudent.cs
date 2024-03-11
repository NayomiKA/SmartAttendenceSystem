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
    public partial class QRCodeGenerator : Form
    {
        public QRCodeGenerator()
        {
            InitializeComponent();
        }

        private void btnCreateQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data =qr.CreateQRCode
        }
    }
}
