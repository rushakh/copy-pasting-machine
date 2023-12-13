using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CopyPasteMachine.Properties;
using System.IO;
using System.Windows.Forms.PropertyGridInternal;

namespace trying_media
{
    
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                try
                { File.Copy(textBox1.Text, textBox2.Text, true); }
                catch (Exception)
                {
                    MessageBox.Show("There was an error, check to make sure everything is in order and then try again.");
                    
                }
                File.Copy(textBox1.Text, textBox2.Text, true);
                MessageBox.Show("Done, unless you encountered an error before this");
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog browsesource = new OpenFileDialog();
            
            if (browsesource.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = browsesource.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browsetarget = new FolderBrowserDialog();
            
            if (browsetarget.ShowDialog() == DialogResult.OK )
            {
                textBox2.Text = Path.Combine (browsetarget. SelectedPath, Path.GetFileName (textBox1.Text));
                
            }

        }
    }
}
