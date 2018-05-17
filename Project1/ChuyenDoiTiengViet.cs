using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// Class này sẽ chuyển đổi kí tự sang tiếng Việt dựa trên việc so sánh 
    /// kí tự trước và kí tự cuối. Nếu người dùng gõ theo quy tắc TELEX thì nó
    /// sẽ sử dụng các hàm SendKeys.Send để thay thế các kí tự thành tiếng Việt
    /// Biến flag dùng để xác định xem có việc chuyển đổi kí tự hay không. 
    /// Nếu có thì đánh dấu flag = true, ngược lại là false
    /// </summary>
    class ChuyenDoiTiengViet
    {
        public bool flag;
        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là a
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// ki_tu_cuoi_cung là kí tự vừa được gõ
        public void KiemTraKiTuA(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("á");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("à");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ả");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ã");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ạ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'a')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("â");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ă");
                flag = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là o
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// ki_tu_cuoi_cung là kí tự vừa được gõ
        public void KiemTraKiTuO(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ó");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ò");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ỏ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("õ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ọ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'o')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ô");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ơ");
                flag = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là e
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// ki_tu_cuoi_cung là kí tự vừa được gõ
        public void KiemTraKiTuE(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("é");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("è");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẻ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẽ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẹ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'e')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ê");
                flag = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là i
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// ki_tu_cuoi_cung là kí tự vừa được gõ
        public void KiemTraKiTuI(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("í");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ì");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ỉ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ĩ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ị");
                flag = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là u
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// ki_tu_cuoi_cung là kí tự vừa được gõ
        public void KiemTraKiTuU(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ú");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ù");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ủ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ũ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ụ");
                flag = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ư");
                flag = true;
                return;
            }
            else return;
        }
    }
}
