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
    public partial class Form2 : Form
    {
        KeyBoardHook keyBoardHook;
        public Form2()
        {
            InitializeComponent();
            keyBoardHook = new KeyBoardHook();
            keyBoardHook.Install();
<<<<<<< HEAD
            keyBoardHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
        }
        

        public void MyKeyPress(object sender, KeyPressEventArgs e)
=======
<<<<<<< HEAD
            //keyBoardHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
=======
            keyBoardHook.KeyPress += new KeyPressEventHandler(MyKeyPress);
        }
        
        public void MyKeyPress(object sender, KeyPressEventArgs e)
>>>>>>> 99a430858108137c996863e7d58d9dfe33ef6ce8
>>>>>>> 14ed9ed298a0713d902879ce3004f26a45a2c16c
        {
            int c = (int)e.KeyChar;
            c++;
            e.KeyChar = (char)c;
        }
<<<<<<< HEAD


=======
<<<<<<< HEAD

        /*public void MyKeyPress(object sender, KeyPressEventArgs e)
        {
            int c = (int)e.KeyChar;
            c++;
            e.KeyChar = (char)c;
        }*/


=======
>>>>>>> 99a430858108137c996863e7d58d9dfe33ef6ce8
>>>>>>> 14ed9ed298a0713d902879ce3004f26a45a2c16c
    }
}
