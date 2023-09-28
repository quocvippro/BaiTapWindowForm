using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maytinhcamtay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tb1.Text= tb1.Text+("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tb1.Text = tb1.Text + ("9");
        }
        String s;
        //dau cong
        private void btncong_Click(object sender, EventArgs e)
        {
            //   int sodautien= Convert.ToInt16(tb1.Text);
            s = tb1.Text;
            tb1.Text = tb1.Text + ("+");

        }
        //in ket qua
        private void btnbang_Click(object sender, EventArgs e)
        {
            string s2= tb1.Text.Remove(0,s.Length + 1);
            int a = Convert.ToInt32(s);
            int b = Convert.ToInt32(s2);
            if (tb1.Text.Contains("+"))
            { 
                tb1.Text=Convert.ToString(a+b);
            }
           else if (tb1.Text.Contains("-"))
            {
                tb1.Text = Convert.ToString(a-b);
            }
            else if (tb1.Text.Contains("x"))
            {
                tb1.Text= Convert.ToString(a*b);
            }
            else if (tb1.Text.Contains(":"))
            {
                double d = Convert.ToDouble(a)/ Convert.ToDouble(b); 
                tb1.Text = Convert.ToString(d);
            }


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            tb1.Text = ("");
            s = ("");
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            s = tb1.Text;
            tb1.Text = tb1.Text + ("-");
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            s = tb1.Text;
            tb1.Text = tb1.Text + ("x");

        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            s = tb1.Text;
            tb1.Text = tb1.Text + (":");

        }
    }
}
