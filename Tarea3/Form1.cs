using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyString = this.txt1.Text;
            int a = 0;
            char asd = ' ';
            for (int x=0; x < MyString.Length; x++)
            {
                if ((MyString[x] == ' ' && asd != ' ') || (x == MyString.Length - 1 && MyString[x] != ' '))
                {
                    a++;
                };
                asd = MyString[x];
            }
            this.txt2.Text = a.ToString();

        }
        
    }
}
