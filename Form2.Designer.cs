namespace ProjectDotNet20
{
    partial class Form2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnBinaryToFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileTextToDll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "File to binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 64);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(775, 374);
            this.txtResult.TabIndex = 1;
            // 
            // btnBinaryToFile
            // 
            this.btnBinaryToFile.Location = new System.Drawing.Point(259, 13);
            this.btnBinaryToFile.Name = "btnBinaryToFile";
            this.btnBinaryToFile.Size = new System.Drawing.Size(147, 23);
            this.btnBinaryToFile.TabIndex = 2;
            this.btnBinaryToFile.Text = "BinaryToFile";
            this.btnBinaryToFile.UseVisualStyleBackColor = true;
            this.btnBinaryToFile.Click += new System.EventHandler(this.btnBinaryToFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(573, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(215, 22);
            this.txtFileName.TabIndex = 3;
            // 
            // btnFileTextToDll
            // 
            this.btnFileTextToDll.Location = new System.Drawing.Point(13, 35);
            this.btnFileTextToDll.Name = "btnFileTextToDll";
            this.btnFileTextToDll.Size = new System.Drawing.Size(159, 23);
            this.btnFileTextToDll.TabIndex = 4;
            this.btnFileTextToDll.Text = "File txt binary to DLL";
            this.btnFileTextToDll.UseVisualStyleBackColor = true;
            this.btnFileTextToDll.Click += new System.EventHandler(this.btnFileTextToDll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "File txt chứa text binary và đẩy vào Path DLL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Path DLL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFileTextToDll);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBinaryToFile);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnBinaryToFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileTextToDll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}