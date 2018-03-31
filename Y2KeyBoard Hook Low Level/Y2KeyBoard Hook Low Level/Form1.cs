using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Y2KeyBoard_Hook_Low_Level
{
    public partial class Form1 : Form
    {
        Y2KeyBoardHook _keyboardHook;
        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;

            ListBox listBox1 = new ListBox();
            listBox1.Location = new Point(10, 10);
            listBox1.Size = new Size(200, 200);

            this.Controls.Add(listBox1);

            _keyboardHook = new Y2KeyBoardHook();
            _keyboardHook.Install();

            //e.KeyCode: Lấy phím từ sự kiện nhấn hay nhả phím
            //listBox1.Items.Add: Ghi lại các sự kiện đó
            _keyboardHook.KeyDown += (sender, e) =>
            {
                listBox1.Items.Add("KeyDown: " + e.KeyCode);

                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                listBox1.Items.Add("KeyUp: " + e.KeyCode);

                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
