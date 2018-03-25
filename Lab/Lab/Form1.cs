using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab
{
    public partial class Form1 : Form
    {
        string[] vni1, vni2;
        char c;
        int i, vitri;
        
        public Form1()
        {
            InitializeComponent();
            vni1 = File.ReadAllLines("vni2.txt");
            vni2 = new string[vni1.Length];
            for (i = 0; i < vni1.Length; i++)
            {
                vitri = vni1[i].IndexOf('\t');
                vni2[i] = vni2[1].Substring(vitri + 1);
                vni1[i] = vni1[1].Substring(0, vitri);
            }
            Array.Sort(vni1, vni2);
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            c = (char)e.KeyChar;
            txtTam1.Text += c;
            txtTam2.Text += c;
            vitri = Array.BinarySearch(vni1, txtTam1.Text);
            if (vitri >= 0)
            {
                //Xóa các phần tử đứng trước
                textBox1.Select(textBox1.SelectionStart - txtTam2.Text.Length + 1, txtTam2.Text.Length - 1);
                textBox1.SelectedText = "";
                //thêm từ
                textBox1.SelectedText = txtTam2.Text = vni2[vitri];
                e.Handled = true;
            }
            else
            {
                vitri = ~vitri;
                if (vni1.Length == vitri || vni1[vitri].IndexOf(txtTam1.Text) != 0)
                {
                    txtTam1.Text = txtTam2.Text = c.ToString();
                }
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                vni1 = File.ReadAllLines("vni2.txt");
                vni2 = new string[vni1.Length];
                for (i = 0; i < vni1.Length; i++)
                {
                    vitri = vni1[i].IndexOf('\t');
                    vni2[i] = vni1[i].Substring(vitri + 1);
                    vni1[i] = vni1[i].Substring(0, vitri);
                }
                Array.Sort(vni1, vni2);
            }
            else
            {
                vni1 = File.ReadAllLines("telex2.txt");
                vni2 = new string[vni1.Length];
                for (i = 0; i < vni1.Length; i++)
                {
                    vitri = vni1[i].IndexOf('\t');
                    vni2[i] = vni1[i].Substring(vitri + 1);
                    vni1[i] = vni1[i].Substring(0, vitri);
                }
                Array.Sort(vni1, vni2);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
