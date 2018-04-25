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
    public partial class FormGiaoDien : Form
    {
        public FormGiaoDien()
        {
            InitializeComponent();
        }


        private void FormGiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTiepTuc_Click(object sender, EventArgs e)
        {
            MoChucNang();
        }

        void MoChucNang()
        {
            if (CheckBoxTangASCII.Checked == true)
            {
                FormTangASCII f2 = new FormTangASCII();
                f2.Show();
            }
            if (CheckBoxDaoNguocChuoi.Checked == true)
            {
                FormDaoNguocChuoi f3 = new FormDaoNguocChuoi();
                f3.Show();
            }
            if (CheckBoxGoTiengViet.Checked == true)
            {
                FormGoTiengViet f4 = new FormGoTiengViet();
                f4.Show();
            }
        }

    }
}
