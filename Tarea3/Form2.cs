using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MyString = this.textBox1.Text;
            string a = "";
            for (int i = MyString.Length - 1; i >= 0; i--)
            {
                a = a + MyString[i];

            }
            this.textBox2.Text = a.ToString();
        }
    }
}
