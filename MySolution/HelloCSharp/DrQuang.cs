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
    class TestCsharp
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("Bat dau Thread con!!!");

                // gia su chung ta dem tu 0 toi 10
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500); //dung trong khoang 5 giay
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Thread con hoan thanh.");
            }

            catch (ThreadAbortException e)
            {
                Console.WriteLine("Thread Abort Exception!!!");
            }
            finally
            {
                Console.WriteLine("Khong the bat Thread Exception!!!");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Da luong trong C#");
            Console.WriteLine("Vi du minh hoa huy Thread");
            Console.WriteLine("-------------------------------------");

            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("Trong Main Thread: tao Thread con.");
            Thread childThread = new Thread(childref);
            childThread.Start();

            //dung Main Thread trong khoang 2 giay
            Thread.Sleep(2000);

            //bay gio huy thread con
            Console.WriteLine("Trong Main Thread: huy Thread con.");

            childThread.Abort();
            Console.ReadKey();
        }
    }
}

