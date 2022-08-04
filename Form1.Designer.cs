
namespace ProjectDotNet20
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCallAPI = new System.Windows.Forms.TabPage();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.chkGetByte = new System.Windows.Forms.CheckBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageToken = new System.Windows.Forms.TabPage();
            this.txtDataSigned = new System.Windows.Forms.TextBox();
            this.btnSignData = new System.Windows.Forms.Button();
            this.lblDataToSign = new System.Windows.Forms.Label();
            this.txtDataToSign = new System.Windows.Forms.TextBox();
            this.txtBase64Cert = new System.Windows.Forms.TextBox();
            this.btnGetBase64Cert = new System.Windows.Forms.Button();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCallAPI.SuspendLayout();
            this.tabPageToken.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCallAPI);
            this.tabControl1.Controls.Add(this.tabPageToken);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 680);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCallAPI
            // 
            this.tabCallAPI.Controls.Add(this.lblBody);
            this.tabCallAPI.Controls.Add(this.txtBody);
            this.tabCallAPI.Controls.Add(this.txtResponse);
            this.tabCallAPI.Controls.Add(this.chkGetByte);
            this.tabCallAPI.Controls.Add(this.lblContentType);
            this.tabCallAPI.Controls.Add(this.txtContentType);
            this.tabCallAPI.Controls.Add(this.lblMethod);
            this.tabCallAPI.Controls.Add(this.txtMethod);
            this.tabCallAPI.Controls.Add(this.lblHeader);
            this.tabCallAPI.Controls.Add(this.txtHeader);
            this.tabCallAPI.Controls.Add(this.lblURL);
            this.tabCallAPI.Controls.Add(this.txtUrl);
            this.tabCallAPI.Controls.Add(this.button1);
            this.tabCallAPI.Location = new System.Drawing.Point(4, 22);
            this.tabCallAPI.Name = "tabCallAPI";
            this.tabCallAPI.Padding = new System.Windows.Forms.Padding(3);
            this.tabCallAPI.Size = new System.Drawing.Size(803, 654);
            this.tabCallAPI.TabIndex = 0;
            this.tabCallAPI.Text = "CallAPI";
            this.tabCallAPI.UseVisualStyleBackColor = true;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(17, 162);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 26;
            this.lblBody.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(91, 162);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(692, 211);
            this.txtBody.TabIndex = 25;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(23, 450);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(763, 191);
            this.txtResponse.TabIndex = 24;
            // 
            // chkGetByte
            // 
            this.chkGetByte.AutoSize = true;
            this.chkGetByte.Location = new System.Drawing.Point(91, 379);
            this.chkGetByte.Name = "chkGetByte";
            this.chkGetByte.Size = new System.Drawing.Size(66, 17);
            this.chkGetByte.TabIndex = 23;
            this.chkGetByte.Text = "Get byte";
            this.chkGetByte.UseVisualStyleBackColor = true;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(20, 136);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(68, 13);
            this.lblContentType.TabIndex = 22;
            this.lblContentType.Text = "ContentType";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(91, 133);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(695, 20);
            this.txtContentType.TabIndex = 21;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(20, 110);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 20;
            this.lblMethod.Text = "Method";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(91, 107);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(695, 20);
            this.txtMethod.TabIndex = 19;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(20, 44);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(42, 13);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Header";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(91, 41);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(695, 61);
            this.txtHeader.TabIndex = 17;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(20, 14);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 16;
            this.lblURL.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(91, 11);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(695, 20);
            this.txtUrl.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(763, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "SendRequest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPageToken
            // 
            this.tabPageToken.Controls.Add(this.txtDataSigned);
            this.tabPageToken.Controls.Add(this.btnSignData);
            this.tabPageToken.Controls.Add(this.lblDataToSign);
            this.tabPageToken.Controls.Add(this.txtDataToSign);
            this.tabPageToken.Controls.Add(this.txtBase64Cert);
            this.tabPageToken.Controls.Add(this.btnGetBase64Cert);
            this.tabPageToken.Controls.Add(this.txtSerialNo);
            this.tabPageToken.Controls.Add(this.lblSerialNo);
            this.tabPageToken.Location = new System.Drawing.Point(4, 22);
            this.tabPageToken.Name = "tabPageToken";
            this.tabPageToken.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageToken.Size = new System.Drawing.Size(803, 654);
            this.tabPageToken.TabIndex = 1;
            this.tabPageToken.Text = "Token";
            this.tabPageToken.UseVisualStyleBackColor = true;
            // 
            // txtDataSigned
            // 
            this.txtDataSigned.Location = new System.Drawing.Point(100, 313);
            this.txtDataSigned.Multiline = true;
            this.txtDataSigned.Name = "txtDataSigned";
            this.txtDataSigned.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataSigned.Size = new System.Drawing.Size(692, 334);
            this.txtDataSigned.TabIndex = 30;
            // 
            // btnSignData
            // 
            this.btnSignData.Location = new System.Drawing.Point(15, 312);
            this.btnSignData.Name = "btnSignData";
            this.btnSignData.Size = new System.Drawing.Size(75, 52);
            this.btnSignData.TabIndex = 29;
            this.btnSignData.Text = "Get Base64 Cert";
            this.btnSignData.UseVisualStyleBackColor = true;
            this.btnSignData.Click += new System.EventHandler(this.btnSignData_Click);
            // 
            // lblDataToSign
            // 
            this.lblDataToSign.AutoSize = true;
            this.lblDataToSign.Location = new System.Drawing.Point(26, 178);
            this.lblDataToSign.Name = "lblDataToSign";
            this.lblDataToSign.Size = new System.Drawing.Size(64, 13);
            this.lblDataToSign.TabIndex = 28;
            this.lblDataToSign.Text = "DataToSign";
            // 
            // txtDataToSign
            // 
            this.txtDataToSign.Location = new System.Drawing.Point(100, 178);
            this.txtDataToSign.Multiline = true;
            this.txtDataToSign.Name = "txtDataToSign";
            this.txtDataToSign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataToSign.Size = new System.Drawing.Size(692, 129);
            this.txtDataToSign.TabIndex = 27;
            // 
            // txtBase64Cert
            // 
            this.txtBase64Cert.Location = new System.Drawing.Point(100, 51);
            this.txtBase64Cert.Multiline = true;
            this.txtBase64Cert.Name = "txtBase64Cert";
            this.txtBase64Cert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64Cert.Size = new System.Drawing.Size(692, 121);
            this.txtBase64Cert.TabIndex = 26;
            // 
            // btnGetBase64Cert
            // 
            this.btnGetBase64Cert.Location = new System.Drawing.Point(20, 51);
            this.btnGetBase64Cert.Name = "btnGetBase64Cert";
            this.btnGetBase64Cert.Size = new System.Drawing.Size(75, 52);
            this.btnGetBase64Cert.TabIndex = 19;
            this.btnGetBase64Cert.Text = "Get Base64 Cert";
            this.btnGetBase64Cert.UseVisualStyleBackColor = true;
            this.btnGetBase64Cert.Click += new System.EventHandler(this.btnGetBase64Cert_Click);
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(100, 13);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(695, 20);
            this.txtSerialNo.TabIndex = 18;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(17, 16);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(47, 13);
            this.lblSerialNo.TabIndex = 17;
            this.lblSerialNo.Text = "SerialNo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 680);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCallAPI.ResumeLayout(false);
            this.tabCallAPI.PerformLayout();
            this.tabPageToken.ResumeLayout(false);
            this.tabPageToken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCallAPI;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.CheckBox chkGetByte;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageToken;
        private System.Windows.Forms.TextBox txtDataSigned;
        private System.Windows.Forms.Button btnSignData;
        private System.Windows.Forms.Label lblDataToSign;
        private System.Windows.Forms.TextBox txtDataToSign;
        private System.Windows.Forms.TextBox txtBase64Cert;
        private System.Windows.Forms.Button btnGetBase64Cert;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label lblSerialNo;
    }
}

