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
    /// Biến IsChanged dùng để xác định xem có việc chuyển đổi kí tự hay không. 
    /// Nếu có thì đánh dấu IsChanged = true, ngược lại là false
    /// </summary>
    class ChuyenDoiTiengViet
    {
        public bool IsChanged;
        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là a
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// KiTuVuaGo là kí tự vừa được gõ
        public void KiemTraKiTuA(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("á");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("à");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ả");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ã");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ạ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'a')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("â");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ă");
                IsChanged = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là o
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// KiTuVuaGo là kí tự vừa được gõ
        public void KiemTraKiTuO(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ó");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ò");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ỏ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("õ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ọ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'o')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ô");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ơ");
                IsChanged = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là e
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// KiTuVuaGo là kí tự vừa được gõ
        public void KiemTraKiTuE(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("é");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("è");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẻ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẽ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ẹ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'e')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ê");
                IsChanged = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là i
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// KiTuVuaGo là kí tự vừa được gõ
        public void KiemTraKiTuI(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("í");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ì");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ỉ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ĩ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ị");
                IsChanged = true;
                return;
            }
            else return;
        }

        /// <summary>
        /// Kiểm tra kí tự nếu kí tự trước đó là u
        /// </summary>
        /// <param name="KiTuVuaGo"></param>
        /// KiTuVuaGo là kí tự vừa được gõ
        public void KiemTraKiTuU(char KiTuVuaGo)
        {
            if (KiTuVuaGo == 's')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ú");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'f')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ù");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'r')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ủ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'x')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ũ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'j')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ụ");
                IsChanged = true;
                return;
            }
            else if (KiTuVuaGo == 'w')
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("ư");
                IsChanged = true;
                return;
            }
            else return;
        }
    }
}
