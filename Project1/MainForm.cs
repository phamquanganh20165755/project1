﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gma.System.Windows;
using System.IO;
using System.Diagnostics;

namespace Project1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Class này sẽ thực hiện các chức năng gõ tiếng Việt, ghi các kí tự đã gõ
        /// ra file log.txt, hiện thông báo bởi cho người dùng biết trạng thái của
        /// chương trình (có đang gõ Tiếng Việt hay không, thông tin về chương trình)
        /// Biến prev dùng để xác định xem kí tự ngay trước kí tự vừa gõ
        /// Sử dụng các class File Stream, StreamWriter, UserActivityHook, ChuyenDoiTiengViet
        /// </summary>

        #region Các biến và đối tượng
        char KiTuTruoc;
        FileStream Log;
        StreamWriter WriteToLog;
        UserActivityHook ThucHienHook;
        ChuyenDoiTiengViet ConvertToVN;
        #endregion

        /// <summary>
        /// Form chính
        /// Thiết lập giá trị ban đầu cho prev, tạo đối tượng cho các class
        /// Tạo file log.txt, cho phép ghi vào file
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            KiTuTruoc = '\0';
            Log = new FileStream("log.txt", FileMode.Create, FileAccess.Write);
            WriteToLog = new StreamWriter(Log);
            ConvertToVN = new ChuyenDoiTiengViet();
        }

        /// <summary>
        /// Khi MainForm được load thì tạo đối tượng actHook để thực hiện việc
        /// lấy các phím ra để thao tác
        /// Thêm sự kiện GoTiengViet để sử dụng
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            ThucHienHook = new UserActivityHook();
            ThucHienHook.KeyPress += new KeyPressEventHandler(GoTiengViet);
        }

        /// <summary>
        /// Khi nhấn Start
        /// thì bắt đầu gõ Tiếng Việt và hiện thông báo
        /// </summary>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ThucHienHook.Start();
            NotifyIconThongBao.ShowBalloonTip(10000, "Thông báo!", 
                "Bạn đang gõ tiếng Việt", ToolTipIcon.Info);
        }

        /// <summary>
        /// Khi nhấn Stop
        /// thì dừng gõ Tiếng Việt và hiện thông báo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            ThucHienHook.Stop();
            NotifyIconThongBao.ShowBalloonTip(10000, "Thông báo!", 
                "Bạn vừa dừng gõ tiếng Việt", ToolTipIcon.Info);
        }

        /// <summary>
        /// Thực hiện việc gõ Tiếng Việt bằng cách kiểm tra kí tự trước và kí tự sau
        /// Ghi kí tự ra file log.txt
        /// </summary>
        private void GoTiengViet(object sender, KeyPressEventArgs e)
        {
            WriteToLog.Write(e.KeyChar);
            WriteToLog.Flush();
            if (KiTuTruoc == 'a')    ConvertToVN.KiemTraKiTuA(e.KeyChar);
            if (KiTuTruoc == 'o')    ConvertToVN.KiemTraKiTuO(e.KeyChar);
            if (KiTuTruoc == 'e')    ConvertToVN.KiemTraKiTuE(e.KeyChar);
            if (KiTuTruoc == 'i')    ConvertToVN.KiemTraKiTuI(e.KeyChar);
            if (KiTuTruoc == 'u')    ConvertToVN.KiemTraKiTuU(e.KeyChar);
            /*Nếu có sự thay đổi kí tự thì hủy việc in ra kí tự cũ*/
            if (ConvertToVN.flag == true)
            {
                e.Handled = true;
                ConvertToVN.flag = false;
            }
            KiTuTruoc = e.KeyChar;
        }

        /// <summary>
        /// Mở file log.txt để xem các kí tự vừa gõ
        /// </summary>
        private void ButtonLog_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\log.txt");
        }

        /// <summary>
        /// Hiển thị thông tin khi click vào Icon
        /// </summary>
        private void NotifyIconThongBao_Click(object sender, EventArgs e)
        {
            NotifyIconThongBao.ShowBalloonTip(10000);
        }
    }
}