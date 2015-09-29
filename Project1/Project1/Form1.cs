using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project1
{
    public partial class Form1 : Form
    {
        StreamReader inputFile = File.OpenText("Words5.txt");
        public Form1()
        {
            InitializeComponent();
            fillList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortListbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = (int)Char.GetNumericValue()
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void sortListbox()
        {
            char[] word = { 'd', 'e', 'l', 't', 'a' };
            string sc = word.ToString();
            MessageBox.Show();
            
        }
        private void fillList()
        {
            string s;
            while ((s = inputFile.ReadLine()) != null)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
