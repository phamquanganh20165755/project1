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
    public partial class FormDaoNguocChuoi : Form
    {
        TextBox textBox;
        KeyBoardHook keyBoardHook;
        public FormDaoNguocChuoi()
        {
            InitializeComponent();

            textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.Location = new System.Drawing.Point(22, 67);
            textBox.Size = new System.Drawing.Size(353, 203);
            textBox.Multiline = true;
            this.Controls.Add(textBox);

            keyBoardHook = new KeyBoardHook();
            keyBoardHook.Install();
            keyBoardHook.KeyPress += new KeyPressEventHandler(ReversedString);
        }

        public void ReversedString(object sender, KeyPressEventArgs e)
        {
            textBox.SelectionStart = 0;
        }
    }
}
