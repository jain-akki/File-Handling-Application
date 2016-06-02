using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtBox1.Text,FileMode.Create,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(txtBox2.Text);
            sw.Flush();
            fs.Close();
            MessageBox.Show("Content is written in file Successfully");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtBox1.Text, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            txtBox3.Text = sr.ReadToEnd();
            fs.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(txtBox1.Text, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            int i = (str.IndexOf(txtBox4.Text, 0));
            if (i > -1)
            {
                MessageBox.Show("This word is exist in the File");
            }
            else 
            {
                MessageBox.Show("This word is not exist in the file try another words");
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            txtBox4.Clear();
            txtBox1.ForeColor = Color.Gray;
            txtBox1.Text = "Enter Path & File name here.... ";
            txtBox2.ForeColor = Color.Gray;
            txtBox2.Text = "Enter text here.... ";
            txtBox4.ForeColor = Color.Gray;
            txtBox4.Text = "Search word here.... ";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "This Application is made by T.F.C.(Akshay: The Freak Coder)"
                , "About"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information
            );
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Page is Under Development "
                , "Help Section"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information
            );
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtBox1.ForeColor = Color.Gray;
            txtBox1.Text = "Enter Path & File name here.... ";
            txtBox2.ForeColor = Color.Gray;
            txtBox2.Text = "Enter text here.... ";
            txtBox4.ForeColor = Color.Gray;
            txtBox4.Text = "Search word here.... ";
        }

        private void txtBox1_Enter(object sender, EventArgs e)
        {
            if (txtBox1.Text == "Enter Path & File name here.... ")
            {
                txtBox1.ForeColor = Color.Black;
                txtBox1.Text = ""; 
            }
        }

        private void txtBox1_Leave(object sender, EventArgs e)
        {
            if (txtBox1.Text == "")
            {
                txtBox1.ForeColor = Color.Gray;
                txtBox1.Text = "Enter Path & File name here.... ";
            }
        }

        private void txtBox2_Enter(object sender, EventArgs e)
        {
            if (txtBox2.Text == "Enter text here.... ")
            {
                txtBox2.ForeColor = Color.Black;
                txtBox2.Text = "";
            }
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            if (txtBox2.Text == "")
            {
                txtBox2.ForeColor = Color.Gray;
                txtBox2.Text = "Enter text here.... ";
            }
        }

        private void txtBox4_Enter(object sender, EventArgs e)
        {
            if (txtBox4.Text == "Search word here.... ")
            {
                txtBox4.ForeColor = Color.Black;
                txtBox4.Text = "";
            }
        }

        private void txtBox4_Leave(object sender, EventArgs e)
        {
            if (txtBox4.Text == "")
            {
                txtBox4.ForeColor = Color.Gray;
                txtBox4.Text = "Search word here.... ";
            }
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBox1.Text != "" && txtBox1.Text != "Enter Path & File name here.... ")
            {
                btn2.Enabled = true;
            }
            else
                btn2.Enabled = false;
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            if (txtBox2.Text != "" && txtBox2.Text != "Enter text here.... ")
            {
                btn1.Enabled = true;
            }
            else
                btn1.Enabled = false;
        }

        private void txtBox4_TextChanged(object sender, EventArgs e)
        {
            if (txtBox4.Text != "" && txtBox4.Text != "Search word here.... ")
            {
                btn3.Enabled = true;
            }
            else
                btn3.Enabled = false;
        }

    }
}
