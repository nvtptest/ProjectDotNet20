using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ProjectDotNet20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUrl.Text = "https://api-vinvoice.viettel.vn/auth/login";
            txtContentType.Text = "application/json";
            txtMethod.Text = "POST";
            txtBody.Text = "{\"username\": \"0900234699\",\"password\": \"123456aA@\"}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERR_Protocols: " + ex.Message);
            }

            string pzResponse = "";

            Utilities.webRequest2(txtUrl.Text, txtBody.Text, "", txtHeader.Text,
                        txtContentType.Text, txtMethod.Text, chkGetByte.Checked, out pzResponse);

            txtResponse.Text = pzResponse;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetBase64Cert_Click(object sender, EventArgs e)
        {
            try
            {
                txtBase64Cert.Text = Utilities.getBase64CertBySerial(txtSerialNo.Text);
            }
            catch (Exception ex)
            {
                txtBase64Cert.Text = ex.Message;
            }
        }

        private void btnSignData_Click(object sender, EventArgs e)
        {
            try
            {
                txtDataSigned.Text = Utilities.signHashCert(txtDataToSign.Text, txtSerialNo.Text);
            }
            catch (Exception ex)
            {
                txtDataSigned.Text = ex.Message;
            }
        }
    }
}
