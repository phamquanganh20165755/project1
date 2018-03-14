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
    public delegate void MyDelegate1(int p1);
    class TestCsharp
    {
        public static void Main(string[] args)
        {
            Bell b = new Bell();
            b.Alarm += AlarmHandler;
            b.Alarm += AlarmHandler2;
            b.OnAlarm();
            Console.ReadKey();
        }

        private static void B_Alarm(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void AlarmHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Ring Ring Cuckoo!!\a");
        }
        static void AlarmHandler2(object sender, EventArgs e)
        {
            Console.WriteLine("Day di hoc de");
        }
    }
    class Bell
    {
        public event EventHandler Alarm;
        public void OnAlarm()
        {
            if (Alarm != null) Alarm(this,EventArgs.Empty);
        }
    }
}

