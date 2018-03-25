using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fMain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!");
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void fMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("You've just press a key!");
        }
    }
}
