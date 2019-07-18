using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ITHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SendingFiles sendingFiles = new SendingFiles();
        
        

        public void button1_Click(object sender, EventArgs e)
        {
            // sendingFiles.Ping(textBox1.Text, out string IPadress);
            sendingFiles.Send(textBox1.Text, out string IPadress);

            
                richTextBox1.Text = IPadress;
                        
        }














        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
