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
    public partial class FormTangASCII : Form
    {
        TextBox textBox;
        KeyBoardHook keyBoardHook;
        public FormTangASCII()
        {
            InitializeComponent();

            textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.Location = new System.Drawing.Point(12, 67);
            textBox.Size = new System.Drawing.Size(353, 193);
            textBox.Multiline = true;
            this.Controls.Add(textBox);

            keyBoardHook = new KeyBoardHook();
            keyBoardHook.Install();
            keyBoardHook.KeyPress += new KeyPressEventHandler(IncreaseAscii);
            textBox.Text = "";
        }
        
        public void IncreaseAscii(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            int ma_ascii = (int)e.KeyChar;
            ma_ascii++;
            e.KeyChar = (char)ma_ascii;
            textBox.Text = textBox.Text + e.KeyChar;
            textBox.SelectionStart = textBox.MaxLength;
        }


    }
}
