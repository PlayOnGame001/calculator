using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string Act;
        public string Num1;
        public bool n2;
        public Form1()
        {
            n2 = false; 
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (n2) //это условие которое спасло мой код надеюсь на долго 
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //if (n2) //вот тут гребанная ошибка если мы напишем сюда действие для второго числа тогда у нас програма отработает дай боже
            //один раз и высосет всю жизнь пока ты поймешь как ее решить ( у меня ушло минут 40) 
            //{
            //    n2 = false;
            //    textBox1.Text = "0";
            //}
            Button B = (Button)sender;
            Act = B.Text;
            Num1 = textBox1.Text;
            n2 = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sum1, sum2, res;
            res = 0;
            sum1 = Convert.ToDouble(Num1);
            sum2 = Convert.ToDouble(textBox1.Text);
            if (Act == "+")
            {
                res = sum1 + sum2;
            }
            if (Act == "-")
            {
                res = sum1 - sum2;
            }
            if (Act == "*")
            {
                res = sum1 * sum2;
            }
            if (Act == "/")
            {
                res = sum1 / sum2;
            }
            Act = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }
    }
}
