using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Threading;

namespace Quang
{
    public delegate void MyEventHandler(string msg);
    public class Window
    {
        public event MyEventHandler Click;

        public Window (int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow() { }
        public void FireEvent()
        {
            if (Click != null)
                Click("Event fire");
        }
        int top;
        private int left;
    }
    public class ListBox : Window
    {
        public ListBox(int top, int left) : base(top, left) { }
        public ListBox(int top, int left, string theContents) : base(top, left)
        {
            mListBoxContents = theContents;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("DrawWindow's ListBox");
        }
        private string mListBoxContents;
        class TestCsharp
        {
            public static void Main(string[] args)
            {
                Window w = new Window(100, 100);
                w.Click += w_Click;
                w.FireEvent();
                Console.ReadKey();
            }
            static void w_Click(string msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}

