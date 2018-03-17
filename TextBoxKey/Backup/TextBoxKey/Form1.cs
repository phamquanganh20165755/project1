using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using gma.System.Windows;
using System.Runtime.InteropServices;

namespace TextBoxKey
{
    public partial class Form1 : Form
    {
        string[] vni1, vni2;
        char c;
        int i, vitri;
        string tam;
        bool controlV = false;
        UserActivityHook actHook;
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
           UIntPtr dwExtraInfo);
        public Form1()
        {
            actHook = new UserActivityHook(false, true);
            actHook.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            InitializeComponent();
            vni1 = File.ReadAllLines("vni.txt");
            vni2 = new string[vni1.Length];
            for (i = 0; i < vni1.Length; i++)
            {
                vitri = vni1[i].IndexOf('\t');
                vni2[i] = vni1[i].Substring(vitri + 1);
                vni1[i] = vni1[i].Substring(0, vitri);
            }
            Array.Sort(vni1, vni2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 32)
            {
                textBox1.Text = textBox2.Text = "";
                return;
            }
            if (controlV)
            {
                controlV = false;
                return;
            }
            c = (char)e.KeyChar;
            textBox1.Text += c; //o6t
            textBox2.Text += c; //ôt
            vitri = Array.BinarySearch(vni1, textBox1.Text);
            if (vitri >= 0)
            {
                //xoá mấy phần tử đứng trước
                tam = "";
                for (i = 0; i < textBox2.Text.Length - 1; i++)
                    tam += "{BS}";
                SendKeys.Send(tam);
                //thêm từ
                if (checkBox1.Checked == true)
                {
                    Clipboard.SetText(vni2[vitri], TextDataFormat.UnicodeText);
                    keybd_event(0x11, 0, 0, UIntPtr.Zero); //...CTRL key down
                    controlV = true; // thông báo true khi nút v được nhấn trong tổ hợp ctrl+v sẽ không xử lý
                    keybd_event(0x56, 0, 0, UIntPtr.Zero); //...V key down
                    keybd_event(0x56, 0, 0x02, UIntPtr.Zero); //...V key up
                    keybd_event(0x11, 0, 0x02, UIntPtr.Zero); //...CTRL key up
                }
                else SendKeys.Send(vni2[vitri]);
                textBox2.Text = vni2[vitri];
                e.Handled = true;
            }
            else
            {
                vitri = ~vitri;
                if (vni1.Length == vitri || vni1[vitri].ToUpper().IndexOf(textBox1.Text.ToUpper()) != 0)
                {
                    textBox1.Text = textBox2.Text = c.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                vni1 = File.ReadAllLines("vni.txt");
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
                vni1 = File.ReadAllLines("telex.txt");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}