
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
            this.tabPageToken = new System.Windows.Forms.TabPage();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.btnGetBase64Cert = new System.Windows.Forms.Button();
            this.txtBase64Cert = new System.Windows.Forms.TextBox();
            this.txtDataToSign = new System.Windows.Forms.TextBox();
            this.lblDataToSign = new System.Windows.Forms.Label();
            this.btnSignData = new System.Windows.Forms.Button();
            this.txtDataSigned = new System.Windows.Forms.TextBox();
            this.tabCallAPI = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.chkGetByte = new System.Windows.Forms.CheckBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnSignString = new System.Windows.Forms.Button();
            this.cboCryptoType = new System.Windows.Forms.ComboBox();
            this.tabPageToken.SuspendLayout();
            this.tabCallAPI.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageToken
            // 
            this.tabPageToken.Controls.Add(this.cboCryptoType);
            this.tabPageToken.Controls.Add(this.btnSignString);
            this.tabPageToken.Controls.Add(this.txtDataSigned);
            this.tabPageToken.Controls.Add(this.txtDataToSign);
            this.tabPageToken.Controls.Add(this.txtBase64Cert);
            this.tabPageToken.Controls.Add(this.txtSerialNo);
            this.tabPageToken.Controls.Add(this.btnSignData);
            this.tabPageToken.Controls.Add(this.lblDataToSign);
            this.tabPageToken.Controls.Add(this.btnGetBase64Cert);
            this.tabPageToken.Controls.Add(this.lblSerialNo);
            this.tabPageToken.Location = new System.Drawing.Point(4, 25);
            this.tabPageToken.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageToken.Name = "tabPageToken";
            this.tabPageToken.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageToken.Size = new System.Drawing.Size(1073, 808);
            this.tabPageToken.TabIndex = 1;
            this.tabPageToken.Text = "Token";
            this.tabPageToken.UseVisualStyleBackColor = true;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(23, 20);
            this.lblSerialNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(60, 16);
            this.lblSerialNo.TabIndex = 17;
            this.lblSerialNo.Text = "SerialNo";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(133, 16);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(925, 22);
            this.txtSerialNo.TabIndex = 18;
            // 
            // btnGetBase64Cert
            // 
            this.btnGetBase64Cert.Location = new System.Drawing.Point(27, 63);
            this.btnGetBase64Cert.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetBase64Cert.Name = "btnGetBase64Cert";
            this.btnGetBase64Cert.Size = new System.Drawing.Size(100, 64);
            this.btnGetBase64Cert.TabIndex = 19;
            this.btnGetBase64Cert.Text = "Get Base64 Cert";
            this.btnGetBase64Cert.UseVisualStyleBackColor = true;
            this.btnGetBase64Cert.Click += new System.EventHandler(this.btnGetBase64Cert_Click);
            // 
            // txtBase64Cert
            // 
            this.txtBase64Cert.Location = new System.Drawing.Point(133, 63);
            this.txtBase64Cert.Margin = new System.Windows.Forms.Padding(4);
            this.txtBase64Cert.Multiline = true;
            this.txtBase64Cert.Name = "txtBase64Cert";
            this.txtBase64Cert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase64Cert.Size = new System.Drawing.Size(921, 148);
            this.txtBase64Cert.TabIndex = 26;
            // 
            // txtDataToSign
            // 
            this.txtDataToSign.Location = new System.Drawing.Point(133, 219);
            this.txtDataToSign.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataToSign.Multiline = true;
            this.txtDataToSign.Name = "txtDataToSign";
            this.txtDataToSign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataToSign.Size = new System.Drawing.Size(921, 158);
            this.txtDataToSign.TabIndex = 27;
            // 
            // lblDataToSign
            // 
            this.lblDataToSign.AutoSize = true;
            this.lblDataToSign.Location = new System.Drawing.Point(35, 219);
            this.lblDataToSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataToSign.Name = "lblDataToSign";
            this.lblDataToSign.Size = new System.Drawing.Size(80, 16);
            this.lblDataToSign.TabIndex = 28;
            this.lblDataToSign.Text = "DataToSign";
            // 
            // btnSignData
            // 
            this.btnSignData.Location = new System.Drawing.Point(20, 384);
            this.btnSignData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignData.Name = "btnSignData";
            this.btnSignData.Size = new System.Drawing.Size(100, 64);
            this.btnSignData.TabIndex = 29;
            this.btnSignData.Text = "SignHash";
            this.btnSignData.UseVisualStyleBackColor = true;
            this.btnSignData.Click += new System.EventHandler(this.btnSignData_Click);
            // 
            // txtDataSigned
            // 
            this.txtDataSigned.Location = new System.Drawing.Point(133, 385);
            this.txtDataSigned.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataSigned.Multiline = true;
            this.txtDataSigned.Name = "txtDataSigned";
            this.txtDataSigned.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataSigned.Size = new System.Drawing.Size(921, 410);
            this.txtDataSigned.TabIndex = 30;
            // 
            // tabCallAPI
            // 
            this.tabCallAPI.Controls.Add(this.lblBody);
            this.tabCallAPI.Controls.Add(this.txtBody);
            this.tabCallAPI.Controls.Add(this.txtResponse);
            this.tabCallAPI.Controls.Add(this.txtContentType);
            this.tabCallAPI.Controls.Add(this.txtMethod);
            this.tabCallAPI.Controls.Add(this.txtHeader);
            this.tabCallAPI.Controls.Add(this.txtUrl);
            this.tabCallAPI.Controls.Add(this.chkGetByte);
            this.tabCallAPI.Controls.Add(this.lblContentType);
            this.tabCallAPI.Controls.Add(this.lblMethod);
            this.tabCallAPI.Controls.Add(this.lblHeader);
            this.tabCallAPI.Controls.Add(this.lblURL);
            this.tabCallAPI.Controls.Add(this.button1);
            this.tabCallAPI.Location = new System.Drawing.Point(4, 25);
            this.tabCallAPI.Margin = new System.Windows.Forms.Padding(4);
            this.tabCallAPI.Name = "tabCallAPI";
            this.tabCallAPI.Padding = new System.Windows.Forms.Padding(4);
            this.tabCallAPI.Size = new System.Drawing.Size(1073, 808);
            this.tabCallAPI.TabIndex = 0;
            this.tabCallAPI.Text = "CallAPI";
            this.tabCallAPI.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1017, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "SendRequest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(121, 14);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(925, 22);
            this.txtUrl.TabIndex = 15;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(27, 17);
            this.lblURL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(34, 16);
            this.lblURL.TabIndex = 16;
            this.lblURL.Text = "URL";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(121, 50);
            this.txtHeader.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(925, 74);
            this.txtHeader.TabIndex = 17;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(27, 54);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(53, 16);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Header";
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(121, 132);
            this.txtMethod.Margin = new System.Windows.Forms.Padding(4);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(925, 22);
            this.txtMethod.TabIndex = 19;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(27, 135);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(52, 16);
            this.lblMethod.TabIndex = 20;
            this.lblMethod.Text = "Method";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(121, 164);
            this.txtContentType.Margin = new System.Windows.Forms.Padding(4);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(925, 22);
            this.txtContentType.TabIndex = 21;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(27, 167);
            this.lblContentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(84, 16);
            this.lblContentType.TabIndex = 22;
            this.lblContentType.Text = "ContentType";
            // 
            // chkGetByte
            // 
            this.chkGetByte.AutoSize = true;
            this.chkGetByte.Location = new System.Drawing.Point(121, 466);
            this.chkGetByte.Margin = new System.Windows.Forms.Padding(4);
            this.chkGetByte.Name = "chkGetByte";
            this.chkGetByte.Size = new System.Drawing.Size(79, 20);
            this.chkGetByte.TabIndex = 23;
            this.chkGetByte.Text = "Get byte";
            this.chkGetByte.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(31, 554);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(1016, 234);
            this.txtResponse.TabIndex = 24;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(121, 199);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(921, 259);
            this.txtBody.TabIndex = 25;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(23, 199);
            this.lblBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(39, 16);
            this.lblBody.TabIndex = 26;
            this.lblBody.Text = "Body";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCallAPI);
            this.tabControl1.Controls.Add(this.tabPageToken);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 837);
            this.tabControl1.TabIndex = 0;
            // 
            // btnSignString
            // 
            this.btnSignString.Location = new System.Drawing.Point(20, 456);
            this.btnSignString.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignString.Name = "btnSignString";
            this.btnSignString.Size = new System.Drawing.Size(100, 64);
            this.btnSignString.TabIndex = 31;
            this.btnSignString.Text = "SignString";
            this.btnSignString.UseVisualStyleBackColor = true;
            this.btnSignString.Click += new System.EventHandler(this.btnSignString_Click);
            // 
            // cboCryptoType
            // 
            this.cboCryptoType.FormattingEnabled = true;
            this.cboCryptoType.Location = new System.Drawing.Point(8, 254);
            this.cboCryptoType.Name = "cboCryptoType";
            this.cboCryptoType.Size = new System.Drawing.Size(121, 24);
            this.cboCryptoType.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 837);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPageToken.ResumeLayout(false);
            this.tabPageToken.PerformLayout();
            this.tabCallAPI.ResumeLayout(false);
            this.tabCallAPI.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageToken;
        private System.Windows.Forms.TextBox txtDataSigned;
        private System.Windows.Forms.TextBox txtDataToSign;
        private System.Windows.Forms.TextBox txtBase64Cert;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Button btnSignData;
        private System.Windows.Forms.Label lblDataToSign;
        private System.Windows.Forms.Button btnGetBase64Cert;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TabPage tabCallAPI;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.CheckBox chkGetByte;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnSignString;
        private System.Windows.Forms.ComboBox cboCryptoType;
    }
}

