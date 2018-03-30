using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Y2KeyBoard_Hook_Low_Level
{
    class Y2KeyBoardHook
    {
        //Các hàm và hằng Win32 API
        #region Win32 API Functions and Constants

        //Import các thư viện dll vào để thêm 3 hàm Win32 API cần thiết
        //Thêm tham số SetLastError để lấy được lỗi nếu cài đặt hook thất bại

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            KeyboardHookDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        //Hằng số xác định kiểu hook
        private const int WH_KEYBOARD_LL = 13;

        //Giá trị hai thông điệp KeyUp và KeyDown
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x101;

        #endregion

        private KeyboardHookDelegate _hookProc;
        private IntPtr _hookHandle = IntPtr.Zero;

        //Tạo một delegate tương ứng với nhiệm vụ "con trỏ hàm"
        public delegate IntPtr KeyboardHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

        //Cấu trúc lưu thông tin sự kiện bàn phím mức low-level
        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardHookStruct
        {
            public int VirtualKeyCode;
            public int ScanCode;
            public int Flags;
            public int Time;
            public int ExtraInfo;
        }

        #region Keyboard Events

        public event KeyEventHandler KeyDown;
        public event KeyEventHandler KeyUp;

        #endregion

        // destructor
        ~Y2KeyBoardHook()
        {
            Uninstall();
        }

        public void Install()
        {
            _hookProc = KeyboardHookProc;
            _hookHandle = SetupHook(_hookProc);

            if (_hookHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        private IntPtr SetupHook(KeyboardHookDelegate hookProc)
        {
            IntPtr hInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

            return SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }

        private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyboardHookStruct kbStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    if (KeyDown != null)
                        KeyDown(null, new KeyEventArgs((Keys)kbStruct.VirtualKeyCode));
                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    if (KeyUp != null)
                        KeyUp(null, new KeyEventArgs((Keys)kbStruct.VirtualKeyCode));
                }
            }

            return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
        }

        public void Uninstall()
        {
            UnhookWindowsHookEx(_hookHandle);
        }
    }
}
