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
    public partial class FormGoTiengViet : Form
    {
        TextBox textBox;
        KeyBoardHook keyBoardHook;

        //Biến flag dùng để đánh dấu có việc dịch sang Tiếng Việt không
        bool flag;
        public FormGoTiengViet()
        {
            InitializeComponent();

            textBox = new TextBox();
            textBox.Name = "textBox";
            textBox.Location = new System.Drawing.Point(12, 73);
            textBox.Size = new System.Drawing.Size(359, 199);
            textBox.Multiline = true;
            this.Controls.Add(textBox);

            keyBoardHook = new KeyBoardHook();
            keyBoardHook.Install();
            keyBoardHook.KeyPress += new KeyPressEventHandler(TranslateToVNmese);
            
            flag = false;
        }

        public void TranslateToVNmese(object sender, KeyPressEventArgs e)
        {
            int chieu_dai_xau = textBox.TextLength;
            if (chieu_dai_xau < 1)
            {

            }
            else
            {
                char ki_tu_truoc = textBox.Text[chieu_dai_xau - 1];
                KiemTraKiTu(ki_tu_truoc, e.KeyChar);
                if (flag == true)
                {
                    e.Handled = true;
                    flag = false;
                }
            }
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
                else if (ki_tu_cuoi_cung == 'a')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("â");
                    flag = true;
                    return;
                }
                else return;
            else if (ki_tu_truoc == 'â')
                if (ki_tu_cuoi_cung == 's')
                {
                    SendKeys.Send("{BACKSPACE}");
                    SendKeys.Send("ấ");
                    flag = true;
                    return;
                }
                else return;
            else return;
        }
    }
}
