using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Y2KeyBoardHook;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

<<<<<<< HEAD
        void OpenForm()
        {
            if (checkBox1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if (checkBox2.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (checkBox3.Checked == true)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (checkBox1.Checked||checkBox2.Checked||checkBox3.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======
<<<<<<< HEAD
        void OpenForm()
        {
            if (checkBox1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if (checkBox2.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (checkBox3.Checked == true)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (checkBox1.Checked||checkBox2.Checked||checkBox3.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======
<<<<<<< HEAD
        void OpenForm()
        {
            if (checkBox1.Checked == true)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if (checkBox2.Checked == true)
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (checkBox3.Checked == true)
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (checkBox1.Checked||checkBox2.Checked||checkBox3.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send("Hello");
>>>>>>> f24581e35b522bf99ec8167ceb2c21ff469c30fa
>>>>>>> 99a430858108137c996863e7d58d9dfe33ef6ce8
>>>>>>> 14ed9ed298a0713d902879ce3004f26a45a2c16c
        }
    }
}
