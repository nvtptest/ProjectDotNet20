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
            txtBody.Text = "{\"username\": \"0100109106-999\",\"password\": \"123456a@A\"}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listCryptType = {"SHA1", "SHA256" };
            this.cboCryptoType.DataSource = listCryptType;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            //string pzResponse = "";
            //Utilities.webRequest2("http://192.168.1.211:8080/send"
            //    , "start_date=2022-08-02&end_date=2022-08-02", "", "", "multipart/form-data;"
            //    , "POST", false, out pzResponse
            //    );
            //txtResponse.Text = pzResponse;
            //return;
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)(0xc0 | 0x300 | 0xc00);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR_Protocols: " + ex.Message);
            }

            string pzResponse = "";

            Utilities.webRequest2(txtUrl.Text, txtBody.Text, "", txtHeader.Text,
                        txtContentType.Text, txtMethod.Text, chkGetByte.Checked, out pzResponse);

            txtResponse.Text = pzResponse;
        }

        private void btnSignString_Click(object sender, EventArgs e)
        {
            try
            {
                txtDataSigned.Text = Utilities.signHashString(txtDataToSign.Text, txtSerialNo.Text, this.cboCryptoType.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                txtDataSigned.Text = ex.Message;
            }
        }
    }
}
