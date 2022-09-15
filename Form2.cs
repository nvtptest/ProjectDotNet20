using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectDotNet20
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = this.openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
                return;
            try
            {
                byte[] buffer = File.ReadAllBytes(openFileDialog1.FileName);

                txtResult.Text = BitConverter.ToString(buffer).Replace("-", "");
            }
            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
        }

        private void btnBinaryToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string bitString = txtResult.Text;
                //string bitString = File.ReadAllText("D:\\dll.txt");

                Int64 length = (bitString.Length) / 2;

                byte[] byteArray = new byte[length];

                for (int i = 0; i < length; i++)
                {
                    string stringBit = bitString.Substring(i * 2, 2);
                    byteArray[i] = Convert.ToByte(stringBit, 16);
                }


                using (var fs = new FileStream(txtFileName.Text, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
            }
        }
    }
}
