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
    public partial class Form2 : Form
    {
        KeyBoardHook keyBoardHook;
        public Form2()
        {
            InitializeComponent();
            keyBoardHook = new KeyBoardHook();
            keyBoardHook.Install();
            //keyBoardHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            c++;
            e.KeyChar = (char)c;
        }

        /*public void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            c++;
            e.KeyChar = (char)c;
        }*/


    }
}
