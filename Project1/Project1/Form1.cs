using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gma.System.Windows;

namespace Project1
{
    public partial class Form1 : Form
    {
        bool flag;
        char prev;
        UserActivityHook actHook;
        public Form1()
        {
            InitializeComponent();
            prev = '\0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actHook = new UserActivityHook();
            actHook.KeyPress += new KeyPressEventHandler(GoTiengViet);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            actHook.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            actHook.Stop();
        }

        private void GoTiengViet(object sender, KeyPressEventArgs e)
        {
            KiemTraKiTu(prev, e.KeyChar);
            if (flag == true)
            {
                e.Handled = true;
                flag = false;
            }
            prev = e.KeyChar;
        }

        void KiemTraKiTu(char ki_tu_truoc, char ki_tu_cuoi_cung)
        {
            if (ki_tu_truoc == 'a')
                if (ki_tu_cuoi_cung == 's')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("á");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'f')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("à");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'r')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("ả");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'x')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("ã");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'j')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("ạ");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'a')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("â");
                    flag = true;
                    return;
                }
                else if (ki_tu_cuoi_cung == 'w')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("ă");
                    flag = true;
                    return;
                }
                else return;
            else return;
        }
    }
}
