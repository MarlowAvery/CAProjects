using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAProj1;

namespace CAProj1GUI
{
    public partial class Form1 : Form
    {
        string ISAResult = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                ISAResult = ISASimulator.ISASim(selectedFileName);
                richTextBox1.Text = ISAResult;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd1.FileName, richTextBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "^Open a file!\nYou can save your output as well!";
        }
    }
}
