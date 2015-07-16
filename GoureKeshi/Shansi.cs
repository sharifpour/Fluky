using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoureKeshi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       int p=0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int b = int.Parse(listBox3.Items.Count.ToString());
                Random objRandom = new Random();
                int intRandomNumber = 0;
                intRandomNumber = objRandom.Next(b);
                label1.Text = intRandomNumber.ToString();
                int h = int.Parse(label1.Text);
                // MessageBox.Show(h.ToString());
                label3.Text = listBox3.Items[h].ToString();
                p++;
                listBox2.Items.Add(p.ToString() + ". " + label3.Text);
                label2.Show();
                listBox3.Items.Remove(label3.Text);
            }
            catch
            {
           //     MessageBox.Show("نامی را برای قرعه کشی اضافه کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    listBox3.Items.Add(textBox1.Text);
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = Application.ExecutablePath;
                }
                else
                    MessageBox.Show("لطفا متنی را برای قرعه کشی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox3.Hide();
            label2.Hide();
            label1.Hide();
            webBrowser1.Hide();
            webBrowser2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                listBox3.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Select();
            }
            else
                MessageBox.Show("لطفا متنی را برای قرعه کشی وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://learn-site.com");
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = System.Drawing.Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
           button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int s = int.Parse(listBox1.SelectedIndex.ToString());
                listBox1.Items.Remove(listBox1.Items[s].ToString());
            }
            catch
            {

            }
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label3.Text = "";
            label2.Text = "";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Transparent;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Black;
        }
    }
}
